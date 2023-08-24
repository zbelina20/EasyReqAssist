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
        private List<Requirement> listaZahtjeva = new List<Requirement>();
        public FrmPocetniZaslon()
        {
            InitializeComponent();
        }

        private void btnNoviZahtjev_Click(object sender, EventArgs e)
        {
            FrmNoviZahtjev noviZahtjev = new FrmNoviZahtjev(this);
            noviZahtjev.ShowDialog();
        }

        public void UcitajNoviZahtjev(Requirement requirement)
        {
            listaZahtjeva.Add(requirement);
            dgvZahtjevi.DataSource = null;
            dgvZahtjevi.DataSource = listaZahtjeva;
        }

        private void btnSpremiUDatoteku_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveDialog = new SaveFileDialog();
            saveDialog.Filter = "Tekstualne datoteke (*.txt)|*.txt";

            if (saveDialog.ShowDialog() == DialogResult.OK)
            {
                SpremiZahtjeveUDatoteku(saveDialog.FileName, listaZahtjeva);
                MessageBox.Show("Zahtjevi su uspješno spremljeni!", "Spremanje završeno", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void SpremiZahtjeveUDatoteku(string nazivDatoteke, List<Requirement> listaZahtjeva)
        {
            using (StreamWriter writer = new StreamWriter(nazivDatoteke))
            {
                foreach (Requirement zahtjev in listaZahtjeva)
                {
                    writer.WriteLine(zahtjev.ID);
                    writer.WriteLine(zahtjev.Naziv);
                    writer.WriteLine(zahtjev.DatumKreiranja);
                    writer.WriteLine(zahtjev.Vrsta);
                    writer.WriteLine(zahtjev.Obrazlozenje);
                    writer.WriteLine(zahtjev.Prioritet);
                    writer.WriteLine(zahtjev.Izvor);
                    writer.WriteLine(zahtjev.Status);
                    writer.WriteLine(zahtjev.NacinProvjere);
                    writer.WriteLine(); // Prazan red između svakog zahtjeva
                }
            }
        }
    }
}
