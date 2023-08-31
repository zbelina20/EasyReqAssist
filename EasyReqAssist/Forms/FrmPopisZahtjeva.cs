using EasyReqAssist.Entities;
using EasyReqAssist.Forms;
using iTextSharp.text.pdf;
using iTextSharp.text;
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
using System.Diagnostics;

namespace EasyReqAssist
{
    public partial class FrmPopisZahtjeva : Form
    {
        private Zahtjev odabraniZahtjev = new Zahtjev();
        public List<Projekt> ListaProjekata = new List<Projekt>();
        public Projekt OdabraniProjekt = new Projekt();

        public FrmPopisZahtjeva(string nazivProjekta)
        {
            InitializeComponent();
            Projekt Projekt = new Projekt();
            Projekt.Naziv = nazivProjekta;
            OdabraniProjekt = Projekt;
            ListaProjekata.Add(Projekt);
            OsvjeziComboBoxProjekata();
        }

        public void OsvjeziComboBoxProjekata()
        {
            cmbProjekti.DataSource = null;
            cmbProjekti.DataSource = ListaProjekata;
            cmbProjekti.DisplayMember = "Naziv";
            cmbProjekti.SelectedIndexChanged += cmbProjekti_SelectedIndexChanged;
        }

        private void btnNoviZahtjev_Click(object sender, EventArgs e)
        {
            FrmNoviZahtjev noviZahtjev = new FrmNoviZahtjev(this);
            noviZahtjev.ShowDialog();
        }

        public void UcitajNoviZahtjev(Zahtjev zahtjev)
        {
            OdabraniProjekt.ListaZahtjeva.Add(zahtjev);
            OsvjeziPopisZahtjeva();
        }

        private void OsvjeziPopisZahtjeva()
        {
            if (OdabraniProjekt.ListaZahtjeva != null)
            {
                dgvZahtjevi.DataSource = null;
                OdabraniProjekt.ListaZahtjeva = OdabraniProjekt.ListaZahtjeva.OrderBy(z => z.RedniBroj).ToList();
                dgvZahtjevi.DataSource = OdabraniProjekt.ListaZahtjeva;
                dgvZahtjevi.Refresh();
            }
        }

        public void IzmijeniPostojeciZahtjev(Zahtjev izmijenjeniZahtjev)
        {
            int index = OdabraniProjekt.ListaZahtjeva.FindIndex(z => z.RedniBroj == odabraniZahtjev.RedniBroj);
            OdabraniProjekt.ListaZahtjeva[index] = izmijenjeniZahtjev;
            OsvjeziPopisZahtjeva();
        }

        private void btnSpremiUDatoteku_Click(object sender, EventArgs e)
        {
            if (OdabraniProjekt.ListaZahtjeva.Count == 0)
            {
                MessageBox.Show("Nemate zahtjeva za spremiti!", "Spremanje prekinuto", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                RadioButton radioBtn = groupBoxSpremanje.Controls.OfType<RadioButton>().Where(x => x.Checked).FirstOrDefault();

                if(radioBtn != null)
                {
                    switch (radioBtn.Name)
                    {
                        case "rbTXTFile":
                            SpremanjeUTekstualnuDatoteku();
                            break;
                        case "rbCSVFile":
                            SpremanjeUCSVDatoteku();
                            break;
                        case "rbPDFFile":
                            SpremanjeuPDFDatoteku();
                            break;
                    }
                }
                else
                {
                    MessageBox.Show("Niste odabrali u koju vrstu datoteke želite spremiti zahtjeve!", "Spremanje prekinuto", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
        }
        private void SpremanjeUTekstualnuDatoteku()
        {
            SaveFileDialog saveDialog = new SaveFileDialog();
            saveDialog.Filter = "Tekstualne Datoteke (*.txt)|*.txt";

            if (saveDialog.ShowDialog() == DialogResult.OK)
            {
                SpremiZahtjeveUTxtDatoteku(saveDialog.FileName, OdabraniProjekt.ListaZahtjeva);
                MessageBox.Show("Zahtjevi su uspješno spremljeni u tekstualnu datoteku!", "Spremanje završeno", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void SpremiZahtjeveUTxtDatoteku(string nazivDatoteke, List<Zahtjev> listaZahtjeva)
        {
            using (StreamWriter writer = new StreamWriter(nazivDatoteke))
            {
                writer.WriteLine("Projekt: " + OdabraniProjekt.Naziv);
                writer.WriteLine();
                foreach (Zahtjev zahtjev in listaZahtjeva)
                {
                    writer.WriteLine("Identifikator: " + zahtjev.Identifikator);
                    writer.WriteLine("Zahtjev: " + zahtjev.NazivZahtjeva);
                    writer.WriteLine("Datum kreiranja: " + zahtjev.DatumKreiranja);
                    writer.WriteLine("Vrsta zahtjeva: " + zahtjev.Vrsta);
                    writer.WriteLine("Obrazloženje: " + zahtjev.Obrazlozenje);
                    writer.WriteLine("Prioritet: " + zahtjev.Prioritet);
                    writer.WriteLine("Izvor: " + zahtjev.Izvor);
                    writer.WriteLine("Status: " + zahtjev.Status);
                    writer.WriteLine("Način provjere: " + zahtjev.NacinProvjere);
                    writer.WriteLine(); // Prazan red između svakog zahtjeva
                }
            }
        }

        private void SpremanjeUCSVDatoteku()
        {
            SaveFileDialog saveDialog = new SaveFileDialog();
            saveDialog.Filter = "CSV Datoteke (*.csv)|*.csv";

            if (saveDialog.ShowDialog() == DialogResult.OK)
            {
                SpremiZahtjeveUCSVDatoteku(saveDialog.FileName);
                MessageBox.Show("Zahtjevi su uspješno spremljeni u CSV datoteku!", "Spremanje završeno", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void SpremiZahtjeveUCSVDatoteku(string nazivDatoteke)
        {
            StringBuilder csvSadrzaj = new StringBuilder();

            csvSadrzaj.AppendLine("Projekt: " + OdabraniProjekt.Naziv);
            csvSadrzaj.AppendLine();

            // Dodajte zaglavlje CSV datoteke (nazive stupaca DataGridView-a)
            for (int i = 0; i < dgvZahtjevi.Columns.Count; i++)
            {
                csvSadrzaj.Append(dgvZahtjevi.Columns[i].HeaderText);
                if (i < dgvZahtjevi.Columns.Count - 1)
                {
                    csvSadrzaj.Append(",");
                }
            }
            csvSadrzaj.AppendLine();

            // Dodavanje retka za svaki redak DataGridView-a
            foreach (DataGridViewRow redak in dgvZahtjevi.Rows)
            {
                for (int i = 0; i < dgvZahtjevi.Columns.Count; i++)
                {
                    csvSadrzaj.Append(redak.Cells[i].Value);
                    if (i < dgvZahtjevi.Columns.Count - 1)
                    {
                        csvSadrzaj.Append(",");
                    }
                }
                csvSadrzaj.AppendLine();
            }

            // Spremanje sadržaja u CSV datoteku
            File.WriteAllText(nazivDatoteke, csvSadrzaj.ToString());
        }

        private void SpremanjeuPDFDatoteku()
        {
            // Otvaranje Save File dijaloga za odabir mjesta za spremanje
            SaveFileDialog saveDialog = new SaveFileDialog();
            saveDialog.Filter = "PDF datoteke (*.pdf)|*.pdf";

            // Ako korisnik odabere mjesto za spremanje
            if (saveDialog.ShowDialog() == DialogResult.OK)
            {
                // Pozivanje metode za generiranje PDF-a i spremanje podataka
                SpremiUPDFDatoteku(saveDialog.FileName);
                MessageBox.Show("Zahtjevi su uspješno spremljeni u PDF datoteku!", "Spremanje završeno", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void SpremiUPDFDatoteku(string nazivDatoteke)
        {
            // Kreiranje instance PDF dokumenta
            Document pdfDokument = new Document();

            // Inicijalizacija PdfWriter za pisanje u datoteku
            PdfWriter.GetInstance(pdfDokument, new FileStream(nazivDatoteke, FileMode.Create));

            // Otvaranje PDF-a za pisanje
            pdfDokument.Open();

            pdfDokument.Add(new Paragraph("Projekt: " + OdabraniProjekt.Naziv));
            pdfDokument.Add(new Paragraph(" "));

            // Dodavanje zaglavlja tablice iz naziva stupaca u DataGridView
            for (int i = 0; i < dgvZahtjevi.Rows.Count; i++)
            {
                PdfPTable tablica = new PdfPTable(2); // Stvaranje nove tablice za svaki redak
                tablica.WidthPercentage = 100; // Postavljanje širine tablice

                float[] sirineStupaca = new float[] { 20f, 80f }; // Postavite željene širine
                tablica.SetWidths(sirineStupaca);

                // Dodajte podatke iz DataGridView-a u tablicu
                for (int j = 0; j < dgvZahtjevi.Columns.Count; j++)
                {
                    PdfPCell celijaKategorija = new PdfPCell(new Phrase(dgvZahtjevi.Columns[j].HeaderText));
                    PdfPCell celijaPodatak = new PdfPCell(new Phrase(dgvZahtjevi[j, i].Value.ToString()));

                    celijaKategorija.HorizontalAlignment = Element.ALIGN_LEFT;
                    celijaKategorija.VerticalAlignment = Element.ALIGN_MIDDLE;
                    celijaKategorija.BackgroundColor = BaseColor.LIGHT_GRAY;

                    celijaPodatak.HorizontalAlignment = Element.ALIGN_LEFT;
                    celijaPodatak.VerticalAlignment = Element.ALIGN_MIDDLE;

                    tablica.AddCell(celijaKategorija);
                    tablica.AddCell(celijaPodatak);
                }

                pdfDokument.Add(tablica);
                // Dodan prazni redak između tablica
                pdfDokument.Add(new Paragraph(" "));
            }
            pdfDokument.Close();
        }

        private void btnDetaljiZahtjeva_Click(object sender, EventArgs e)
        {
            odabraniZahtjev = DohvatiZahtjev();

            if(dgvZahtjevi.Rows.Count == 0)
            {
                MessageBox.Show("Nemate napravljenih zahtjeva da biste mogli pregledati njihove detalje!", "Upozorenje", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (odabraniZahtjev == null)
            {
                MessageBox.Show("Morate odabrati zahtjev da biste vidjeli njegove detalje!", "Upozorenje", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                FrmDetaljiZahtjeva detaljiZahtjeva = new FrmDetaljiZahtjeva(odabraniZahtjev, this);
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

        private void btnObrisiZahtjev_Click(object sender, EventArgs e)
        {
            odabraniZahtjev = DohvatiZahtjev();

            if (dgvZahtjevi.Rows.Count == 0)
            {
                MessageBox.Show("Nemate zahtjeva za obrisati!", "Upozorenje", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (odabraniZahtjev == null)
            {
                MessageBox.Show("Morate odabrati zahtjev da biste ga mogli obrisati!", "Upozorenje", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                OdabraniProjekt.ListaZahtjeva.Remove(odabraniZahtjev);
                OsvjeziPopisZahtjeva();
            }
        }

        private void btnNoviProjekt_Click(object sender, EventArgs e)
        {
            cmbProjekti.SelectedIndexChanged -= cmbProjekti_SelectedIndexChanged;
            FrmNoviProjekt frmNoviProjekt = new FrmNoviProjekt(this);
            frmNoviProjekt.ShowDialog();
        }
        
        private void cmbProjekti_SelectedIndexChanged(object sender, EventArgs e)
        {
            OdabraniProjekt = cmbProjekti.SelectedItem as Projekt;
            OsvjeziPopisZahtjeva();
        }
    }

}
