using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PracticaTehnologica
{
    public partial class FrmMoldova : MaterialSkin.Controls.MaterialForm
    {
        public FrmMoldova()
        {
            InitializeComponent();
        }

        private void FrmMoldova_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'jucariiMd.Afisare_Jucarii_md' table. You can move, or remove it, as needed.
            this.afisare_Jucarii_mdTableAdapter.Fill(this.jucariiMd.Afisare_Jucarii_md);

            this.reportViewer1.RefreshReport();
        }

        private void btnJucarenia_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void reportViewer1_Load(object sender, EventArgs e)
        {

        }
    }
}
