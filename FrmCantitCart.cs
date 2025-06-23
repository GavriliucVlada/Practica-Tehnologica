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
using static PracticaTehnologica.FrmHome;
using static PracticaTehnologica.FrmProduse;

namespace PracticaTehnologica
{
    public partial class FrmCantitCart : MaterialSkin.Controls.MaterialForm
    {

        Connection con = new Connection();
        decimal cantit = 0;

        public FrmCantitCart()
        {
            InitializeComponent();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnSalveazaCart_Click(object sender, EventArgs e)
        {
            

            DateTime dt = DateTime.Now;
            try
            {
                cantit = numericUpDownCantitateCart.Value;
                var connection = con.OpenConnection();

                if (cantit <= CantitProd.Cantitate)
                {

                    using (SqlCommand cmd = new SqlCommand(
                        "INSERT INTO Cart VALUES (@Produse_Id, @ZiuaAchizitionare, @Cantitatea, @Utilizator_ID)",
                    connection))
                    {

                        cmd.Parameters.AddWithValue("@Produse_Id", idCurentCart.ID);
                        cmd.Parameters.AddWithValue("@ZiuaAchizitionare", dt);
                        cmd.Parameters.AddWithValue("@Cantitatea", cantit);
                        cmd.Parameters.AddWithValue("@Utilizator_ID", UtilizatorCurent.ID);

                        int rows = cmd.ExecuteNonQuery();
                        if (rows > 0)
                            MessageBox.Show("Produs adăugat în coșul de cumpărături!");
                        else
                            MessageBox.Show("Adăugarea nu a reușit.");
                    }
                    con.CloseConnection();
                }
                else
                {
                    MessageBox.Show("Nu aven așa cantitate de produse în stoc");
                }
               
            }
            catch (Exception ex)
            {
                MessageBox.Show("Eroare: " + ex.Message);
            }

            this.Close();
        }
    }
}
