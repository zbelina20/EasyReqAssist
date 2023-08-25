using EasyReqAssist.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EasyReqAssist.Forms
{
    public partial class FrmNoviZahtjev : Form
    {
        private FrmPocetniZaslon pocetniZaslon;
        public FrmNoviZahtjev(FrmPocetniZaslon frmPocetniZaslon)
        {
            InitializeComponent();
            this.pocetniZaslon = frmPocetniZaslon;
        }

        private void btnOdustani_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnSpremiZahtjev_Click(object sender, EventArgs e)
        {
            if(txtID.Text == "" || txtZahtjev.Text == "")
            {
                MessageBox.Show("Morate upisati identifikator i zahtjev!", "Greška", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtID.BackColor = Color.IndianRed;
                txtZahtjev.BackColor = Color.IndianRed;
            }
            else
            {
                Zahtjev noviZahtjev = new Zahtjev {
                    ID = txtID.Text,
                    NazivZahtjeva = txtZahtjev.Text,
                    DatumKreiranja = dtpDatumZahjteva.Value,
                    Vrsta = txtVrsta.Text,
                    Obrazlozenje = txtObrazlozenje.Text,
                    Prioritet = txtPrioritet.Text,
                    Izvor = txtIzvor.Text,
                    Status = txtStatus.Text,
                    NacinProvjere = txtNacinProvjere.Text,
                    RedniBroj = RedniBrojZahtjeva()
                };

                pocetniZaslon.UcitajNoviZahtjev(noviZahtjev);
                Close();
            }
        }

        private int RedniBrojZahtjeva()
        {
            return pocetniZaslon.listaZahtjeva.Count + 1;
        }

        private void FrmNoviZahtjev_Load(object sender, EventArgs e)
        {
           labelZahtjev.Text += " " + (RedniBrojZahtjeva()).ToString();
        }
    }
}
