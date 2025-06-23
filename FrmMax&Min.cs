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
    public partial class FrmMax_Min : MaterialSkin.Controls.MaterialForm
    {
        public FrmMax_Min()
        {
            InitializeComponent();
        }

        private void FrmMax_Min_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'vedere_jucarie_MinMaxPret_Data_Set.Vedere_Jucarie_MinMaxPret' table. You can move, or remove it, as needed.
            this.vedere_Jucarie_MinMaxPretTableAdapter.Fill(this.vedere_jucarie_MinMaxPret_Data_Set.Vedere_Jucarie_MinMaxPret);

            this.reportViewer1.RefreshReport();
        }

        private void btnJucarenia_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
