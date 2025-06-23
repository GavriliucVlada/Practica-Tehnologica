using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PracticaTehnologica
{
    public partial class FrmSortare : MaterialSkin.Controls.MaterialForm
    {
        public FrmSortare()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string connectionString = "Data Source=VLADUTA\\SQLEXPRESS;Initial Catalog=Lumea_Copiilor;Integrated Security=True";

            int pretMax = int.Parse(textBoxPretMax.Text);
            int varstaMin = int.Parse(textBoxVarstaMin.Text);
            int varstaMax = int.Parse(textBoxVarstaMax.Text);

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                using (SqlCommand cmd = new SqlCommand("GetJucariiFiltrate", conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@PretMax", pretMax);
                    cmd.Parameters.AddWithValue("@VarstaMin", varstaMin);
                    cmd.Parameters.AddWithValue("@VarstaMax", varstaMax);

                    SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);

                    dataGridViewJucarii.DataSource = dt;
                }
            }

        }

        private void btnJucarenia_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
