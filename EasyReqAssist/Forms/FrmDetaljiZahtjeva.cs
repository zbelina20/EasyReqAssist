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
        public FrmDetaljiZahtjeva(Entities.Zahtjev odabraniZahtjev)
        {
            InitializeComponent();
            OdabraniZahtjev = odabraniZahtjev;
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
            txtID.Text = OdabraniZahtjev.ID;
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
            txtID.Enabled = true;
            txtZahtjev.Enabled = true;
            dtpDatumZahjteva.Enabled = true;
            txtVrsta.Enabled = true;
            txtObrazlozenje.Enabled = true;
            txtPrioritet.Enabled = true;
            txtIzvor.Enabled = true;
            txtStatus.Enabled = true;
            txtNacinProvjere.Enabled = true;
        }
    }
}
