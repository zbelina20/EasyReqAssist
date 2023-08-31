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
    public partial class FrmNoviProjekt : Form
    {
        private FrmPopisZahtjeva PopisZahtjeva;
        public FrmNoviProjekt(FrmPopisZahtjeva frmPopisZahtjeva)
        {
            InitializeComponent();
            PopisZahtjeva = frmPopisZahtjeva;
        }

        private void btnKreiranjeZahtjeva_Click(object sender, EventArgs e)
        {
            if(txtProjekt.Text != "")
            {
                Projekt noviProjekt = new Projekt();
                noviProjekt.Naziv = txtProjekt.Text;
                PopisZahtjeva.ListaProjekata.Add(noviProjekt);
                PopisZahtjeva.OsvjeziComboBoxProjekata();
                Close();
            }
            else
            {
                MessageBox.Show("Morate napisati naziv projekta kako biste mogli nastaviti!", "Upozorenje", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnOdustani_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
