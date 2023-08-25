using EasyReqAssist.Entities;
using EasyReqAssist.Forms;
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

namespace EasyReqAssist
{
    public partial class FrmPocetniZaslon : Form
    {
        public List<Zahtjev> listaZahtjeva = new List<Zahtjev>();
        public FrmPocetniZaslon()
        {
            InitializeComponent();
        }

        private void btnNoviZahtjev_Click(object sender, EventArgs e)
        {
            FrmNoviZahtjev noviZahtjev = new FrmNoviZahtjev(this);
            noviZahtjev.ShowDialog();
        }

        public void UcitajNoviZahtjev(Zahtjev requirement)
        {
            listaZahtjeva.Add(requirement);
            dgvZahtjevi.DataSource = null;
            dgvZahtjevi.DataSource = listaZahtjeva;
        }

        private void btnSpremiUDatoteku_Click(object sender, EventArgs e)
        {
            if (listaZahtjeva.Count == 0)
            {
                MessageBox.Show("Nemate zahtjeva za spremiti!", "Spremanje prekinuto", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                SaveFileDialog saveDialog = new SaveFileDialog();
                saveDialog.Filter = "PDF datoteke (*.pdf)|*.pdf|All files (*.*)|*.*";

                if (saveDialog.ShowDialog() == DialogResult.OK)
                {
                    SpremiZahtjeveUDatoteku(saveDialog.FileName, listaZahtjeva);
                    MessageBox.Show("Zahtjevi su uspješno spremljeni!", "Spremanje završeno", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void SpremiZahtjeveUDatoteku(string nazivDatoteke, List<Zahtjev> listaZahtjeva)
        {
            using (StreamWriter writer = new StreamWriter(nazivDatoteke))
            {
                foreach (Zahtjev zahtjev in listaZahtjeva)
                {
                    writer.WriteLine("Identifikator: ", zahtjev.ID);
                    writer.WriteLine("Zahtjev: ", zahtjev.NazivZahtjeva);
                    writer.WriteLine("Datum kreiranja: ", zahtjev.DatumKreiranja);
                    writer.WriteLine("Vrsta zahtjeva: ", zahtjev.Vrsta);
                    writer.WriteLine("Obrazloženje: ", zahtjev.Obrazlozenje);
                    writer.WriteLine("Prioritet: ", zahtjev.Prioritet);
                    writer.WriteLine("Izvor: ", zahtjev.Izvor);
                    writer.WriteLine("Status: ", zahtjev.Status);
                    writer.WriteLine("Način provjere: ", zahtjev.NacinProvjere);
                    writer.WriteLine(); // Prazan red između svakog zahtjeva
                }
            }
        }
        private void btnDetaljiZahtjeva_Click(object sender, EventArgs e)
        {
            var odabraniZahtjev = DohvatiZahtjev();

            if(dgvZahtjevi.Rows.Count == 0)
            {
                MessageBox.Show("Nemate napravljenih zahtjeva!", "Upozorenje", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (odabraniZahtjev == null)
            {
                MessageBox.Show("Morate odabrati zahtjev da biste vidjeli njegove detalje!", "Upozorenje", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                FrmDetaljiZahtjeva detaljiZahtjeva = new FrmDetaljiZahtjeva(odabraniZahtjev);
                detaljiZahtjeva.ShowDialog();
            }
        }

        private Zahtjev DohvatiZahtjev()
        {
            if (dgvZahtjevi.CurrentRow != null)
            {
                return dgvZahtjevi.CurrentRow.DataBoundItem as Zahtjev;
            }
            return null;
        }
    }

}
