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
    public partial class FrmVerifyAdmin : MaterialSkin.Controls.MaterialForm
    {

        private string nume, prenume, email, username, parola;
        private byte[] imagine;
        private string parolaAdmin = "admin777";

        public FrmVerifyAdmin(string nume, string prenume, string email, string username, string parola, byte[] imagine)
        {
            InitializeComponent();
            this.nume = nume;
            this.prenume = prenume;
            this.email = email;
            this.username = username;
            this.parola = parola;
            this.imagine = imagine;
        }

        public FrmVerifyAdmin()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (parolaAdmin == textBoxPassword.Text)
            {
                string connectionString = "Data Source=VLADUTA\\SQLEXPRESS;Initial Catalog=Lumea_Copiilor;Integrated Security=True";
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    string query = @"INSERT INTO Administrator (Nume, Prenume, Email, Username, Parola, ImagineProfil)
                     VALUES (@nume, @prenume, @email, @username, @parola, @imagine)";

                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@nume", nume);
                        cmd.Parameters.AddWithValue("@prenume", prenume);
                        cmd.Parameters.AddWithValue("@email", email);
                        cmd.Parameters.AddWithValue("@username", username);
                        cmd.Parameters.AddWithValue("@parola", parola);
                        cmd.Parameters.Add("@imagine", SqlDbType.VarBinary).Value = (object)imagine ?? DBNull.Value;

                        int rows = cmd.ExecuteNonQuery();
                        if (rows > 0)
                        {
                            MessageBox.Show("Contul a fost salvat cu succes!");
                            this.Close();
                        }
                        else
                            MessageBox.Show("Eroare la salvare.");
                    }
                }
            }
            else
            {
                MessageBox.Show("Parola administrator incorectă!");
            }
        }

    }
}
