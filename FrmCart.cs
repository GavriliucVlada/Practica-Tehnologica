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

namespace PracticaTehnologica
{
    public partial class FrmCart : MaterialSkin.Controls.MaterialForm
    {
        public FrmCart()
        {
            InitializeComponent();
            CreateCart();
        }

        int SumaCalc = 0;


        public void CreateCart()
        {
            string connectionString = "Data Source=VLADUTA\\SQLEXPRESS;Initial Catalog=Lumea_Copiilor;Integrated Security=True";

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                string query = "SELECT * FROM Afisare_Cart WHERE Utilizator_ID = @userID";

                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@userID", UtilizatorCurent.ID);

                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        
                        panelCart.AutoScroll = true;

                        int startX = 120;
                        int startY = 120;
                        int spacing = 40;
                        int groupBoxWidth = 270;
                        int groupBoxHeight = 210;

                        int currentX = startX;
                        int currentY = startY;

                        while (reader.Read())
                        {

                            int produsID = Convert.ToInt32(reader["ID"]);

                            SumaCalc = SumaCalc + (Convert.ToInt32(reader["Produse_Pret"]) * Convert.ToInt32(reader["Cantitatea"]));

                            GroupBox grp = new GroupBox();
                            grp.Size = new Size(groupBoxWidth, groupBoxHeight);
                            grp.Location = new Point(currentX, currentY);
                            grp.BackColor = Color.White;
                            grp.ForeColor = Color.Coral;
                            grp.Tag = produsID;

                            Label lblDenumire = new Label
                            {
                                Font = new Font("Roboto Slab", 10, FontStyle.Regular),
                                Text = "Denumire: " + reader["Produse_Denumire"].ToString(),
                                Location = new Point(10, 25),
                                Width = groupBoxWidth - 20,
                                Height = 40,
                                MaximumSize = new Size(groupBoxWidth - 20, 0),
                                AutoSize = true,
                                TextAlign = ContentAlignment.MiddleLeft,
                                ForeColor = Color.FromArgb(66, 23, 3)
                            };

                            Label lblBrand = new Label
                            {
                                Font = new Font("Roboto Slab", 10, FontStyle.Regular),
                                Text = "Brand: " + reader["Brand_uri_Denumire"].ToString(),
                                Location = new Point(10, 70),
                                Width = groupBoxWidth - 20,
                                Height = 40,
                                AutoSize = false,
                                TextAlign = ContentAlignment.MiddleCenter,
                                ForeColor = Color.FromArgb(66, 23, 3)
                            };

                            Label lblPret = new Label
                            {
                                Font = new Font("Roboto Slab", 10, FontStyle.Regular),
                                Text = "Preț: " + reader["Produse_Pret"].ToString() + " lei",
                                Location = new Point(10, 115),
                                Width = groupBoxWidth - 20,
                                Height = 30,
                                AutoSize = false,
                                TextAlign = ContentAlignment.MiddleCenter,
                                ForeColor = Color.FromArgb(66, 23, 3)
                            };

                            Label lblCantitate = new Label
                            {
                                Font = new Font("Roboto Slab", 10, FontStyle.Regular),
                                Text = "Cantitate: " + reader["Cantitatea"].ToString(),
                                Location = new Point(10, 150),
                                Width = groupBoxWidth - 20,
                                Height = 30,
                                AutoSize = false,
                                TextAlign = ContentAlignment.MiddleCenter,
                                ForeColor = Color.FromArgb(66, 23, 3)
                            };

                            Button deleteProd = new Button
                            {
                                BackColor = Color.FromArgb(234, 101, 39),
                                ForeColor = Color.White,
                                FlatStyle = FlatStyle.Flat,
                                Text = "Șterge",
                                TextAlign= ContentAlignment.MiddleCenter,
                                Size = new Size(60, 25),
                                Location = new Point(200, 175),
                            };



                            deleteProd.Click += (s, ev) =>
                            {
                                Button btn = s as Button;
                                GroupBox parentGrp = btn.Parent as GroupBox;
                                int cartID = (int)parentGrp.Tag;

                                DialogResult confirm = MessageBox.Show("Sigur doriți să ștergeți acest produs din coș?", "Confirmare", MessageBoxButtons.YesNo);
                                if (confirm == DialogResult.Yes)
                                {
                                    string connStr = "Data Source=VLADUTA\\SQLEXPRESS;Initial Catalog=Lumea_Copiilor;Integrated Security=True";

                                    using (SqlConnection con = new SqlConnection(connStr))
                                    {
                                        con.Open(); 
                                        string deleteQuery = "DELETE FROM Cart WHERE ID = @id";

                                        using (SqlCommand cmDel = new SqlCommand(deleteQuery, con))
                                        {
                                            cmDel.Parameters.AddWithValue("@id", cartID); 
                                            cmDel.ExecuteNonQuery();
                                        }
                                    }

                                    panelCart.Controls.Remove(parentGrp);
                                    parentGrp.Dispose();
                                }
                            };


                            deleteProd.FlatAppearance.BorderColor = Color.FromArgb(255, 206, 183);
                            deleteProd.FlatAppearance.BorderSize = 1;
                            deleteProd.FlatAppearance.MouseDownBackColor = Color.FromArgb(217, 89, 30);
                            deleteProd.FlatAppearance.MouseOverBackColor = Color.FromArgb(255, 119, 55);

                           

                            grp.Controls.Add(deleteProd);
                            grp.Controls.Add(lblDenumire);
                            grp.Controls.Add(lblBrand);
                            grp.Controls.Add(lblPret);
                            grp.Controls.Add(lblCantitate);

                            panelCart.Controls.Add(grp);
                            

                            currentX += groupBoxWidth + spacing;

                            if (currentX + groupBoxWidth > panelCart.Width)
                            {
                                currentX = startX;
                                currentY += groupBoxHeight + spacing;
                            }
                        }

                        Label Suma = new Label
                        {
                            Font = new Font("Roboto Slab", 10, FontStyle.Regular),
                            Text = "Suma: " + SumaCalc,
                            Location = new Point(1100, currentY + 150),
                            AutoSize = true,
                            ForeColor = Color.Black
                        };

                        Button cumparaProd = new Button
                        {
                            BackColor = Color.FromArgb(234, 101, 39),
                            ForeColor = Color.White,
                            FlatStyle = FlatStyle.Flat,
                            Text = "Cumpără!",
                            Font = new Font("Roboto Slab", 18, FontStyle.Regular),
                            TextAlign = ContentAlignment.MiddleCenter,
                            Size = new Size(150, 50),
                            Location = new Point(1250, currentY + 130),
                            
                        };

                        cumparaProd.FlatAppearance.BorderColor = Color.FromArgb(255, 206, 183);
                        cumparaProd.FlatAppearance.BorderSize = 1;
                        cumparaProd.FlatAppearance.MouseDownBackColor = Color.FromArgb(217, 89, 30);
                        cumparaProd.FlatAppearance.MouseOverBackColor = Color.FromArgb(255, 119, 55);

                        cumparaProd.Click += (s, ev) =>
                        {
                            string connStr = "Data Source=VLADUTA\\SQLEXPRESS;Initial Catalog=Lumea_Copiilor;Integrated Security=True";

                            using (SqlConnection con = new SqlConnection(connStr))
                            {
                                con.Open();

                                using (SqlTransaction transaction = con.BeginTransaction())
                                {
                                    try
                                    {
                                        string selectCart = "SELECT Produse_Id, Cantitatea FROM Cart WHERE Utilizator_ID = @userID";
                                        using (SqlCommand cmdSelect = new SqlCommand(selectCart, con, transaction))
                                        {
                                            cmdSelect.Parameters.AddWithValue("@userID", UtilizatorCurent.ID);

                                            using (SqlDataReader reader1 = cmdSelect.ExecuteReader())
                                            {
                                                List<(int ProdusId, int Cantitate)> produseCart = new List<(int, int)>();

                                                while (reader1.Read())
                                                {
                                                    produseCart.Add((Convert.ToInt32(reader1["Produse_Id"]), Convert.ToInt32(reader1["Cantitatea"])));
                                                }

                                                reader1.Close();

                                                string insertCumparat = @"
                                                        INSERT INTO Cumparat (Produse_Id, ZiuaAchizitionare, Cantitatea, Utilizator_ID) 
                                                        VALUES (@produsId, @ziua, @cantitate, @userID)";

                                                string updateProduseCantitate = @"
                                                        UPDATE Produse
                                                        SET Produse_Cantitate = Produse_Cantitate - @cantitate
                                                        WHERE Produse_Id = @produsId";

                                                foreach (var produs in produseCart)
                                                {
                                                   
                                                    using (SqlCommand cmdInsert = new SqlCommand(insertCumparat, con, transaction))
                                                    {
                                                        cmdInsert.Parameters.AddWithValue("@produsId", produs.ProdusId);
                                                        cmdInsert.Parameters.AddWithValue("@ziua", DateTime.Now.Date);
                                                        cmdInsert.Parameters.AddWithValue("@cantitate", produs.Cantitate);
                                                        cmdInsert.Parameters.AddWithValue("@userID", UtilizatorCurent.ID);

                                                        cmdInsert.ExecuteNonQuery();
                                                    }

                                                    using (SqlCommand cmdUpdate = new SqlCommand(updateProduseCantitate, con, transaction))
                                                    {
                                                        cmdUpdate.Parameters.AddWithValue("@cantitate", produs.Cantitate);
                                                        cmdUpdate.Parameters.AddWithValue("@produsId", produs.ProdusId);

                                                        cmdUpdate.ExecuteNonQuery();
                                                    }
                                                }
                                            }
                                        }

                                        string deleteCart = "DELETE FROM Cart WHERE Utilizator_ID = @userID";
                                        using (SqlCommand cmdDelete = new SqlCommand(deleteCart, con, transaction))
                                        {
                                            cmdDelete.Parameters.AddWithValue("@userID", UtilizatorCurent.ID);
                                            cmdDelete.ExecuteNonQuery();
                                        }

                                        transaction.Commit();

                                        MessageBox.Show("Achiziția a fost înregistrată cu succes!");

                                        this.Close();
                                    }
                                    catch (Exception ex)
                                    {
                                        transaction.Rollback();
                                        MessageBox.Show("Eroare la salvarea achiziției: " + ex.Message);
                                    }
                                }
                            }
                        };



                        panelCart.Controls.Add(Suma);
                        panelCart.Controls.Add(cumparaProd);

                    }
                }
            }
        }


        private void acasa(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
