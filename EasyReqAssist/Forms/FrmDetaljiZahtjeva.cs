using EasyReqAssist.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EasyReqAssist.Forms
{
    public partial class FrmDetaljiZahtjeva : Form
    {
        private Zahtjev OdabraniZahtjev = new Zahtjev();
        private FrmPopisZahtjeva PocetniZaslon;
        public FrmDetaljiZahtjeva(Zahtjev odabraniZahtjev, FrmPopisZahtjeva pocetniZaslon)
        {
            InitializeComponent();
            OdabraniZahtjev = odabraniZahtjev;
            PocetniZaslon = pocetniZaslon;
        }

        private void btnOdustani_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void FrmDetaljiZahtjeva_Load(object sender, EventArgs e)
        {
            labelZahtjev.Text += " " + OdabraniZahtjev.RedniBroj.ToString();
            PopuniPodatkeZahtjeva();
        }

        private void PopuniPodatkeZahtjeva()
        {
            txtIdentifikator.Text = OdabraniZahtjev.Identifikator;
            txtZahtjev.Text = OdabraniZahtjev.NazivZahtjeva;
            dtpDatumZahjteva.Value = OdabraniZahtjev.DatumKreiranja;
            txtVrsta.Text = OdabraniZahtjev.Vrsta;
            txtObrazlozenje.Text = OdabraniZahtjev.Obrazlozenje;
            txtPrioritet.Text = OdabraniZahtjev.Prioritet;
            txtIzvor.Text = OdabraniZahtjev.Izvor;
            txtStatus.Text = OdabraniZahtjev.Status;
            txtNacinProvjere.Text = OdabraniZahtjev.NacinProvjere;
        }

        private void btnIzmijeniZahtjev_Click(object sender, EventArgs e)
        {
            btnSpremiZahtjev.Enabled = true;
            txtIdentifikator.Enabled = true;
            txtZahtjev.Enabled = true;
            dtpDatumZahjteva.Enabled = true;
            txtVrsta.Enabled = true;
            txtObrazlozenje.Enabled = true;
            txtPrioritet.Enabled = true;
            txtIzvor.Enabled = true;
            txtStatus.Enabled = true;
            txtNacinProvjere.Enabled = true;
        }

        private void btnSpremiZahtjev_Click(object sender, EventArgs e)
        {
            if (txtIdentifikator.Text == "" || txtZahtjev.Text == "")
            {
                MessageBox.Show("Morate upisati identifikator i zahtjev!", "Upozorenje", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtIdentifikator.BackColor = Color.IndianRed;
                txtZahtjev.BackColor = Color.IndianRed;
            }
            else
            {
                Zahtjev azuriraniZahtjev = new Zahtjev {
                    RedniBroj = OdabraniZahtjev.RedniBroj,
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
                
                PocetniZaslon.IzmijeniPostojeciZahtjev(azuriraniZahtjev);
                Close();
            }
        }
    }
}
