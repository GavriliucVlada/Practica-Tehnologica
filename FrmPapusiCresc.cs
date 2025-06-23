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
    public partial class FrmPapusiCresc : MaterialSkin.Controls.MaterialForm
    {
        public FrmPapusiCresc()
        {
            InitializeComponent();
        }

        private void FrmPapusiCresc_Load(object sender, EventArgs e)
        {
            this.getPapusiDisponibileTableAdapter.Fill(this.getPapusiDisponibile._GetPapusiDisponibile);
            this.getPapusiDisponibileTableAdapter.Fill(this.getPapusiDisponibile._GetPapusiDisponibile);
            this.getPapusiDisponibileTableAdapter.Fill(this.getPapusiDisponibile._GetPapusiDisponibile);

            this.reportViewer1.RefreshReport();
        }

        private void btnJucarenia_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
