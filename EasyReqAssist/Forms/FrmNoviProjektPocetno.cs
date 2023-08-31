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
    public partial class FrmNoviProjektPocetno : Form
    {
        public FrmNoviProjektPocetno()
        {
            InitializeComponent();
        }

        private void btnKreiranjeZahtjeva_Click(object sender, EventArgs e)
        {
            if(txtProjekt.Text != "")
            {
                Hide();
                FrmPopisZahtjeva pocetniZaslon = new FrmPopisZahtjeva(txtProjekt.Text);
                pocetniZaslon.ShowDialog();
                Close();
            }
            else
            {
                MessageBox.Show("Morate napisati naziv projekta kako biste mogli nastaviti!", "Upozorenje", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
