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
    public partial class FrmOutOfStock : MaterialSkin.Controls.MaterialForm
    {
        public FrmOutOfStock()
        {
            InitializeComponent();
        }

        private void FrmOutOfStock_Load(object sender, EventArgs e)
        {

            this.reportViewer1.RefreshReport();
        }

        private void btnJucarenia_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FrmOutOfStock_Load_1(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'lumea_CopiilorAfisare_OutOfStock.Afisare_OutOfStock' table. You can move, or remove it, as needed.
            this.afisare_OutOfStockTableAdapter.Fill(this.lumea_CopiilorAfisare_OutOfStock.Afisare_OutOfStock);

            this.reportViewer1.RefreshReport();
        }

        private void btnJucarenia_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
