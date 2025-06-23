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
    public partial class FrmTopProduse : MaterialSkin.Controls.MaterialForm
    {
        public FrmTopProduse()
        {
            InitializeComponent();
        }

        private void btnJucarenia_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FrmTopProduse_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'produsePopulareDataSet.Produse_Populare' table. You can move, or remove it, as needed.
            this.produse_PopulareTableAdapter.Fill(this.produsePopulareDataSet.Produse_Populare);

            this.reportViewer1.RefreshReport();
        }
    }
}
