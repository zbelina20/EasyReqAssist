using EasyReqAssist.API;
using EasyReqAssist.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EasyReqAssist.Forms
{
    public partial class FrmNoviZahtjev : Form
    {
        private FrmPopisZahtjeva PopisZahtjeva;
        public FrmNoviZahtjev(FrmPopisZahtjeva frmPopisZahtjeva)
        {
            InitializeComponent();
            PopisZahtjeva = frmPopisZahtjeva;
        }

        private void btnOdustani_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnSpremiZahtjev_Click(object sender, EventArgs e)
        {
            if(txtIdentifikator.Text == "" || txtZahtjev.Text == "")
            {
                MessageBox.Show("Morate upisati identifikator i zahtjev!", "Upozorenje", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtIdentifikator.BackColor = Color.IndianRed;
                txtZahtjev.BackColor = Color.IndianRed;
            }
            else
            {
                Zahtjev noviZahtjev = new Zahtjev {
                    RedniBroj = RedniBrojZahtjeva(),
                    Identifikator = txtIdentifikator.Text,
                    NazivZahtjeva = txtZahtjev.Text,
                    DatumKreiranja = dtpDatumZahjteva.Value,
                    Vrsta = txtVrsta.Text,
                    Obrazlozenje = txtObrazlozenje.Text,
                    Prioritet = txtPrioritet.Text,
                    Izvor = txtIzvor.Text,
                    Status = txtStatus.Text,
                    NacinProvjere = txtNacinProvjere.Text
                };

                PopisZahtjeva.UcitajNoviZahtjev(noviZahtjev);
                Close();
            }
        }

        private int RedniBrojZahtjeva()
        {
            if(PopisZahtjeva.OdabraniProjekt.ListaZahtjeva.Count == 0 || PopisZahtjeva.OdabraniProjekt.ListaZahtjeva == null)
            {
                return 1;
            }
            else if(PopisZahtjeva.OdabraniProjekt.ListaZahtjeva.Count != PopisZahtjeva.OdabraniProjekt.ListaZahtjeva.LastOrDefault().RedniBroj)
            {
                return PopisZahtjeva.OdabraniProjekt.ListaZahtjeva.Count - 1;
            }
            else
            {
                return PopisZahtjeva.OdabraniProjekt.ListaZahtjeva.Count + 1;
            }
        }

        private void FrmNoviZahtjev_Load(object sender, EventArgs e)
        {
           labelZahtjev.Text += " " + (RedniBrojZahtjeva()).ToString();
        }

        private async void btnProvjeriZahtjev_Click(object sender, EventArgs e)
        {
            if(txtZahtjev.Text == "")
            {
                MessageBox.Show("Morate napisati zahtjev kako bi se mogao provjeriti!", "Upozorenje", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                txtOdgovorAPIa.Clear();
                var chatClient = new OpenAIChatClient();
                string odgovor = await chatClient.GetChatResponse(txtZahtjev.Text);
                var jsonOdgovor = JsonSerializer.Deserialize<JsonElement>(odgovor);
                var AIOdgovor = jsonOdgovor
                    .GetProperty("choices")[0]
                    .GetProperty("message")
                    .GetProperty("content")
                    .GetString();
                txtOdgovorAPIa.Text = AIOdgovor;
            }
        }
    }
}
