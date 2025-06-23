using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static PracticaTehnologica.FrmHome;


namespace PracticaTehnologica
{
    public partial class FrmProduse : MaterialSkin.Controls.MaterialForm
    {

        Connection con = new Connection();
        public static int Jucarie_Id;
        string connectionString = "Data Source=VLADUTA\\SQLEXPRESS;Initial Catalog=Lumea_Copiilor;Integrated Security=True";



        public int id;
        public int cantitate;
        public string denumire;
        public string tara;
        public int varsta;
        public string sex;
        public decimal pret;
        public string categorie;
        string brand;






        public void SetCartEnabled()
        {
            btnCart.Enabled = true;
        }

        public void SetDelEnabled()
        {
            btnDelete.Enabled = true;
        }

        public void SetAddEnabled()
        {
            btnADD.Enabled = true;
        }

        public void SetModEnabled()
        {
            btnModify.Enabled = true;
        }

        public void SetStockEnabled()
        {
            btnStock.Enabled = true;
        }


        public FrmProduse()
        {
            InitializeComponent();
            LoadCategoriiIntoGrid();
        }
        public void LoadCategoriiIntoGrid()
        {
            SqlConnection connection = con.OpenConnection();

            try
            {
            
                SqlCommand cmd = new SqlCommand("MutaProduseEpuizate", connection);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.ExecuteNonQuery();

                
                SqlDataAdapter dataAdpt = new SqlDataAdapter("SELECT * FROM Afisare_Produse", connection);
                DataTable dt = new DataTable();
                dataAdpt.Fill(dt);
                dataGridViewJucarii.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Eroare: " + ex.Message);
            }
            finally
            {
                con.CloseConnection();
            }
        }


        private void FrmProduse_Load(object sender, EventArgs e)
        {
            
            this.afisare_ProduseTableAdapter.Fill(this.lumea_CopiilorDataSet.Afisare_Produse);

        }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        private void home_page_click(object sender, EventArgs e)
        {
            FrmHome home = new FrmHome();
            this.Close();
        }
      
        private void btnADD_Click(object sender, EventArgs e)
        {
            FrmJucariiAdd frmJucariiAdd = new FrmJucariiAdd();
            frmJucariiAdd.Show();
            this.Close();
        }
        private void btnDelete_Click(object sender, EventArgs e)
        {

                if (dataGridViewJucarii.SelectedRows.Count == 0)
                {
                    MessageBox.Show("Selectează mai întâi un rând!");
                    return;
                }

                var row = dataGridViewJucarii.SelectedRows[0];
                int idToDelete = Convert.ToInt32(row.Cells["produseIdDataGridViewTextBoxColumn"].Value);


                var dr = MessageBox.Show( $"Sigur vrei să ştergi înregistrarea cu ID-ul = {idToDelete}?",  "Confirmare ştergere",
                       MessageBoxButtons.YesNo,
                       MessageBoxIcon.Warning);

                if (dr != DialogResult.Yes)
                    return;

                try
                {
                    var connection = con.OpenConnection(); 
                    using (SqlCommand cmd = new SqlCommand(
                        "DELETE FROM Produse WHERE Produse_Id = @Produse_Id",
                        connection))
                    {
                        cmd.Parameters.AddWithValue("@Produse_Id", idToDelete);
                        int rows = cmd.ExecuteNonQuery(); 
                        if (rows > 0)
                            MessageBox.Show("Ştergere reuşită!");
                        else
                            MessageBox.Show("Nu s‑a găsit înregistrarea.");
                    }
                    con.CloseConnection();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Eroare: " + ex.Message);
                }

            LoadCategoriiIntoGrid();
        }
        private void btnModify_Click(object sender, EventArgs e)
        {
            if (dataGridViewJucarii.SelectedRows.Count == 0)
            {
                MessageBox.Show("Selectează mai întâi un rând!");
                return;
            }

            DataGridViewRow row = dataGridViewJucarii.SelectedRows[0];

            int id = Convert.ToInt32(row.Cells["produseIdDataGridViewTextBoxColumn"].Value);
            string denumire = row.Cells["produseDenumireDataGridViewTextBoxColumn"].Value.ToString();
            string tara = row.Cells["produseTaraDataGridViewTextBoxColumn"].Value.ToString();
            int varsta = Convert.ToInt32(row.Cells["produseVarstaDataGridViewTextBoxColumn"].Value);
            string sex = row.Cells["Produse_Sex"].Value.ToString();
            int cantitate = Convert.ToInt32(row.Cells["produseCantitateDataGridViewTextBoxColumn"].Value);
            decimal pret = Convert.ToDecimal(row.Cells["produsePretDataGridViewTextBoxColumn"].Value);
            string categorie = row.Cells["categoriiDenumireDataGridViewTextBoxColumn"].Value.ToString();
            string brand = row.Cells["branduriDenumireDataGridViewTextBoxColumn"].Value.ToString();

            FrmJucariiModify frm = new FrmJucariiModify(id, denumire, tara, varsta, sex, cantitate, pret, categorie, brand);
            frm.ShowDialog();
            this.Close();

        }

        private void btnCart_Click(object sender, EventArgs e)
        {
            if (dataGridViewJucarii.SelectedRows.Count == 0)
            {
                MessageBox.Show("Selectează mai întâi un rând!");
                return;
            }

            DataGridViewRow row = dataGridViewJucarii.SelectedRows[0];

            id = Convert.ToInt32(row.Cells["produseIdDataGridViewTextBoxColumn"].Value);
            idCurentCart.ID = this.id;

            denumire = row.Cells["produseDenumireDataGridViewTextBoxColumn"].Value.ToString();
            tara = row.Cells["produseTaraDataGridViewTextBoxColumn"].Value.ToString();
            varsta = Convert.ToInt32(row.Cells["produseVarstaDataGridViewTextBoxColumn"].Value);
            sex = row.Cells["Produse_Sex"].Value.ToString();
            cantitate = Convert.ToInt32(row.Cells["produseCantitateDataGridViewTextBoxColumn"].Value);

            CantitProd.Cantitate = this.cantitate;
            pret = Convert.ToDecimal(row.Cells["produsePretDataGridViewTextBoxColumn"].Value);
            categorie = row.Cells["categoriiDenumireDataGridViewTextBoxColumn"].Value.ToString();
            brand = row.Cells["branduriDenumireDataGridViewTextBoxColumn"].Value.ToString();

            FrmCantitCart cantit = new FrmCantitCart();
            cantit.Show();

        }

        public static class idCurentCart
        {
            public static int ID { get; set; }
        }

        public static class CantitProd
        {
            public static int Cantitate { get; set; }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FrmOutOfStock frm = new FrmOutOfStock();
            frm.Show();
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            FrmMax_Min frm = new FrmMax_Min();
            frm.Show();
        }

        private void barbie_click(object sender, EventArgs e)
        {
            FrmPapusiCresc frm = new FrmPapusiCresc();
            frm.Show();
        }

        private void tari_click(object sender, EventArgs e)
        {
            FrmTaraTastatura frm = new FrmTaraTastatura();
            frm.Show();
        }

        private void md_click(object sender, EventArgs e)
        {
            FrmMoldova frm = new FrmMoldova();
            frm.Show();
        }

        private void btn4_click(object sender, EventArgs e)
        {
            FrmSortare frm = new FrmSortare();
            frm.Show();
        }

        private void btn5_click(object sender, EventArgs e)
        {
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                try
                {
                    con.Open();

                    SqlCommand cmd = new SqlCommand("RefreshProdusePopulare", con);
                    cmd.CommandType = System.Data.CommandType.StoredProcedure;

                    cmd.ExecuteNonQuery();

                }
                catch (Exception ex)
                {
                    MessageBox.Show("Eroare: " + ex.Message, "Eroare", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            FrmTopProduse frm = new FrmTopProduse();
            frm.Show();
        }
    }
}
