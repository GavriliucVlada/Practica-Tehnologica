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
    public partial class FrmHistory : MaterialSkin.Controls.MaterialForm
    {
        public FrmHistory()
        {
            InitializeComponent();
        }

        private void btnJucarenia_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FrmHistory_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'afisare_History_DataSet.Afisare_Cumparat' table. You can move, or remove it, as needed.
            this.afisare_CumparatTableAdapter.Fill(this.afisare_History_DataSet.Afisare_Cumparat);

            this.reportViewer1.RefreshReport();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string dataSelectata = dateTimePicker1.Text;

            using (SqlConnection conn = new SqlConnection("Data Source=VLADUTA\\SQLEXPRESS;Initial Catalog=Lumea_Copiilor;Integrated Security=True"))
            {
                using (SqlCommand cmd = new SqlCommand("GetTotalProduseVanduteInZi", conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@Data", dataSelectata);

                    conn.Open();
                    SqlDataReader reader = cmd.ExecuteReader();

                    if (reader.Read())
                    {
                        MessageBox.Show("Total produse vândute: " + reader["Total_Produse_Vandute"].ToString());
                    }
                    else
                    {
                        MessageBox.Show("Nu s-au înregistrat vânzări în acea zi.");
                    }

                    reader.Close();
                }
            }

        }
    }
}
