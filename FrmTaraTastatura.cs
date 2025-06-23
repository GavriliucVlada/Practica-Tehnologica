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
    public partial class FrmTaraTastatura : MaterialSkin.Controls.MaterialForm
    {
        public FrmTaraTastatura()
        {
            InitializeComponent();
        }


        private void buttonCalculeaza_Click(object sender, EventArgs e)
        {
            string tara = textBoxTara.Text.Trim();

            if (string.IsNullOrEmpty(tara))
            {
                MessageBox.Show("Introduceți o țară.");
                return;
            }

            string connectionString = "Data Source=VLADUTA\\SQLEXPRESS;Initial Catalog=Lumea_Copiilor;Integrated Security=True";

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                using (SqlCommand cmd = new SqlCommand("GetPretMediuPeTara", conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@Tara", tara);

                    try
                    {
                        conn.Open();
                        SqlDataReader reader = cmd.ExecuteReader();

                        if (reader.Read() && reader["Pret_Mediu"] != DBNull.Value)
                        {
                            double pretMediu = Convert.ToDouble(reader["Pret_Mediu"]);
                            labelRezultat.Text = $"Prețul mediu pentru {tara} este: {pretMediu:F2} lei";
                        }
                        else
                        {
                            labelRezultat.Text = $"Nu s-au găsit produse pentru {tara}.";
                        }

                        reader.Close();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Eroare: " + ex.Message);
                    }
                }
            }
        }

        private void btnJucarenia_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FrmTaraTastatura_Load(object sender, EventArgs e)
        {
            this.getTariDisponibileTableAdapter.Fill(this.tari.GetTariDisponibile);

            this.reportViewer1.RefreshReport();
        }
    }
}
