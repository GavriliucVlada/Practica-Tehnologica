using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using Microsoft.ReportingServices.Diagnostics.Internal;

namespace PracticaTehnologica
{
    public partial class FrmJucariiAdd : MaterialSkin.Controls.MaterialForm
    {

        Connection con = new Connection();
        SqlDataAdapter dataAdpt;


        public FrmJucariiAdd()
        {
            InitializeComponent();
            AfisareCategorii(panelRBtnCategorii);
            AfisareBrand(panelRBtnBrand);
        }

        public void AfisareCategorii(Panel panel)
        {
            panel.Controls.Clear();

            dataAdpt = new SqlDataAdapter("select * from Categorii", con.OpenConnection());
            DataTable dt = new DataTable();
            dataAdpt.Fill(dt);

            int y = 20;
            int x = 20;

            foreach (DataRow row in dt.Rows)
                {
                int id = Convert.ToInt32(row["Categorii_Id"]);
                string nume = row["Categorii_Denumire"].ToString();

                RadioButton rBtn = new RadioButton();
                rBtn.Name = $"rBtn{id}";
                rBtn.Text = nume;
                rBtn.Tag = id; 
                rBtn.Location = new Point(x, y); 
     
                rBtn.AutoSize = true;

                panel.Controls.Add(rBtn);

                y += 30;

            }

        }
        public string GetSelectedCategorieName(Panel panel)
        {
            foreach (Control control in panel.Controls)
            {
                if (control is RadioButton rBtn && rBtn.Checked)
                {
                    return rBtn.Text;
                }
            }
            return null;
        }

        public int GetSelectedCategorieId(Panel panel)
        {
            foreach (Control control in panel.Controls)
            {
                if (control is RadioButton rBtn && rBtn.Checked)
                {
                    return (int)rBtn.Tag; 
                }
            }
            return -1; 
        }

        public int GetSelectedBrandId(Panel panel)
        {
            foreach (Control control in panel.Controls)
            {
                if (control is RadioButton rBtn && rBtn.Checked)
                {
                    return (int)rBtn.Tag;
                }
            }
            return -1;
        }

        public void AfisareBrand(Panel panel)
        {
            panel.Controls.Clear();

            dataAdpt = new SqlDataAdapter("select * from Brand_uri", con.OpenConnection());
            DataTable dt = new DataTable();
            dataAdpt.Fill(dt);

            int y = 20;
            int x = 20;

            foreach (DataRow row in dt.Rows)
            {
                int id = Convert.ToInt32(row["Brand_uri_Id"]);
                string nume = row["Brand_uri_Denumire"].ToString();

                RadioButton rBtn = new RadioButton();
                rBtn.Name = $"rBtn{id}";
                rBtn.Text = nume;
                rBtn.Tag = id;
                rBtn.Location = new Point(x, y);

                rBtn.AutoSize = true;

                panel.Controls.Add(rBtn);

                y += 30;

            }



        }

        public string GetSelectedBrandName(Panel panel)
        {
            foreach (Control control in panel.Controls)
            {
                if (control is RadioButton rBtn && rBtn.Checked)
                {
                    return rBtn.Text;
                }
            }
            return null;
        }



        private void btnJucarenia_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAdaugaJucaria_Click(object sender, EventArgs e)
        {
            string categoria = null;
            string brand = null;
            int categorii_Id;
            int brand_uri_Id;
            try
            {
                    if (panelRBtnCategorii.Enabled == true)
                    {
                        categoria = GetSelectedCategorieName(panelRBtnCategorii);
                        if (categoria == null)
                        {
                            MessageBox.Show("Selectati Categoria!");
                        }
                        categorii_Id = GetSelectedCategorieId(panelRBtnCategorii);

                    }
                    else
                    {
                        categoria = txtBoxCategoriiAltele.Text;

                        SqlCommand cmd = new SqlCommand("INSERT INTO Categorii (Categorii_Denumire) VALUES (@Categorii_Denumire)", con.OpenConnection());
                        cmd.Parameters.AddWithValue("@Categorii_Denumire", categoria);
                        cmd.ExecuteNonQuery();

                        SqlCommand getIdCmd1 = new SqlCommand("SELECT MAX(Categorii_Id) FROM Categorii", con.OpenConnection());
                        categorii_Id = Convert.ToInt32(getIdCmd1.ExecuteScalar());

                        con.CloseConnection();
                    }

                    if (panelRBtnBrand.Enabled == true)
                    {
                        brand = GetSelectedBrandName(panelRBtnBrand);
                        if (brand == null)
                        {
                            MessageBox.Show("Selectati Brand-ul!");
                        }
                        brand_uri_Id = GetSelectedBrandId(panelRBtnBrand);
                    }
                    else
                    {
                        brand = txtBoxBrandAltele.Text;

                        SqlCommand cmd = new SqlCommand("INSERT INTO Brand_uri (Brand_uri_Denumire) VALUES (@Brand_uri_Denumire)", con.OpenConnection());
                        cmd.Parameters.AddWithValue("@Brand_uri_Denumire", brand);
                        cmd.ExecuteNonQuery();

                        SqlCommand getIdCmd2 = new SqlCommand("SELECT MAX(Brand_uri_Id) FROM Brand_uri", con.OpenConnection());
                        brand_uri_Id = Convert.ToInt32(getIdCmd2.ExecuteScalar());

                        con.CloseConnection();

                        
                }


                if (categoria != null && brand != null && textBoxDenumireJucarie.Text != "" && txtBoxTaraJucarii.Text != "" && (comboBoxSexJucarii.Text == "F" || comboBoxSexJucarii.Text == "M" || comboBoxSexJucarii.Text == "F & M") && txtBoxCantitateJucarii.Text != "" && textBoxPretJucarie.Text != "")
                {


                    SqlCommand cmd = new SqlCommand("INSERT INTO Produse (Produse_Denumire, Produse_Varsta, Brand_uri_Id, Produse_Sex, Produse_Pret, Produse_Cantitate, Produse_Tara, Categorii_Id)" +
                        " VALUES (@Produse_Denumire, @Produse_Varsta, @Brand_uri_Id, @Produse_Sex, @Produse_Pret, @Produse_Cantitate, @Produse_Tara, @Categorii_Id)", con.OpenConnection());

                    cmd.Parameters.AddWithValue("@Produse_Denumire", textBoxDenumireJucarie.Text);
                    cmd.Parameters.AddWithValue("@Produse_Varsta", Convert.ToInt32(numericUpDownVarsta.Value));
                    cmd.Parameters.AddWithValue("@Brand_uri_Id", brand_uri_Id);
                    cmd.Parameters.AddWithValue("@Produse_Sex", comboBoxSexJucarii.Text);
                    cmd.Parameters.AddWithValue("@Produse_Pret", decimal.Parse(textBoxPretJucarie.Text));
                    cmd.Parameters.AddWithValue("@Produse_Cantitate", int.Parse(txtBoxCantitateJucarii.Text));
                    cmd.Parameters.AddWithValue("@Produse_Tara", txtBoxTaraJucarii.Text);
                    cmd.Parameters.AddWithValue("@Categorii_Id", categorii_Id);

                    cmd.ExecuteNonQuery();
                    con.CloseConnection();
                    MessageBox.Show("Jucăria a fost adăugată cu succes!");


                    this.Close();

                    FrmProduse frmProduse = new FrmProduse();
                    frmProduse.Show();
                    SqlDataAdapter dataAdpt = new SqlDataAdapter("SELECT * FROM Afisare_Produse", con.OpenConnection());
                    DataTable dt = new DataTable();
                    dataAdpt.Fill(dt);
                    frmProduse.dataGridViewJucarii.DataSource = dt;
                    frmProduse.btnADD.Enabled = true;
                    frmProduse.btnDelete.Enabled = true;
                    frmProduse.btnModify.Enabled = true;
                    frmProduse.btnStock.Enabled = true;
                    con.CloseConnection();


                }
                else
                {
                    MessageBox.Show("Introduceti Toate datele!");
                }

            }
            catch (Exception ex) {
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }






















        private void lblCategorii_Click(object sender, EventArgs e)
        {

        }
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnAltaCategorie_Click(object sender, EventArgs e)
        {
            txtBoxCategoriiAltele.Enabled = true;
            panelRBtnCategorii.Enabled = false;
            btnAltaCategorie.Enabled = false;
            btnCategorieExistenta.Enabled = true;
        }
        private void btnCategorieExistenta_Click(object sender, EventArgs e)
        {
            txtBoxCategoriiAltele.Enabled = false;
            panelRBtnCategorii.Enabled = true;
            btnAltaCategorie.Enabled = true;
            btnCategorieExistenta.Enabled = false;
        }
        private void btnAltBrand_Click(object sender, EventArgs e)
        {
            txtBoxBrandAltele.Enabled = true;
            panelRBtnBrand.Enabled = false;
            btnAltBrand.Enabled = false;
            btnBrandExistent.Enabled = true;
        }
        private void btnBrandExistent_Click(object sender, EventArgs e)
        {
            txtBoxBrandAltele.Enabled = false;
            panelRBtnBrand.Enabled = true;
            btnAltBrand.Enabled = true;
            btnBrandExistent.Enabled = false;

        }

       
    }
}
