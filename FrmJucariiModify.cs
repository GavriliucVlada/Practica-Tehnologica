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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace PracticaTehnologica
{
    public partial class FrmJucariiModify : MaterialSkin.Controls.MaterialForm
    {

        Connection con = new Connection();
        private int produsId;

        public FrmJucariiModify(int id, string denumire, string tara, int varsta, string sex, int cantitate, decimal pret, string categorie, string brand)
        {
            InitializeComponent();
            produsId = id;

            txtDenumire.Text = denumire;
            txtTara.Text = tara;
            numericVarsta.Value = varsta;
            comboSex.Text = sex;
            txtCantitate.Text = cantitate.ToString();
            txtPret.Text = pret.ToString();
            FrmJucariiAdd jucariiAdd = new FrmJucariiAdd();

            jucariiAdd.AfisareCategorii(panelCategorii);
            jucariiAdd.AfisareBrand(panelBranduri);

            SelecteazaRadioButtonDupaText(panelCategorii, categorie);
            SelecteazaRadioButtonDupaText(panelBranduri, brand);
        }
        private void SelecteazaRadioButtonDupaText(Panel panel, string valoare)
        {
            foreach (Control ctrl in panel.Controls)
            {
                if (ctrl is RadioButton rbtn && rbtn.Text == valoare)
                {
                    rbtn.Checked = true;
                    break;
                }
            }
        }
        private void btnAltaCategorie_Click(object sender, EventArgs e)
        {
            txtBoxCategoriiAltele.Enabled = true;
            panelCategorii.Enabled = false;
            btnAltaCategorie.Enabled = false;
            btnCategorieExistenta.Enabled = true;
        }
        private void btnCategorieExistenta_Click(object sender, EventArgs e)
        {
            txtBoxCategoriiAltele.Enabled = false;
            panelCategorii.Enabled = true;
            btnAltaCategorie.Enabled = true;
            btnCategorieExistenta.Enabled = false;
        }
        private void btnAltBrand_Click(object sender, EventArgs e)
        {
            txtBoxBrandAltele.Enabled = true;
            panelBranduri.Enabled = false;
            btnAltBrand.Enabled = false;
            btnBrandExistent.Enabled = true;
        }
        private void btnBrandExistent_Click(object sender, EventArgs e)
        {
            txtBoxBrandAltele.Enabled = false;
            panelBranduri.Enabled = true;
            btnAltBrand.Enabled = true;
            btnBrandExistent.Enabled = false;
        }
        private void btnJucarenia_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnModificaJucaria_Click(object sender, EventArgs e)
        {
            string categoria;
            string brand;
            int categorii_Id;
            int brand_uri_Id;
            FrmJucariiAdd frmJucariiAdd = new FrmJucariiAdd();
            try
            {
                if (panelCategorii.Enabled == true)
                {
                    categoria = frmJucariiAdd.GetSelectedCategorieName(panelCategorii);
                    if (categoria == null)
                    {
                        MessageBox.Show("Selectati Categoria!");
                    }
                    categorii_Id = frmJucariiAdd.GetSelectedCategorieId(panelCategorii);

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

                if (panelBranduri.Enabled == true)
                {
                    brand = frmJucariiAdd.GetSelectedBrandName(panelBranduri);
                    if (brand == null)
                    {
                        MessageBox.Show("Selectati Brand-ul!");
                    }
                    brand_uri_Id = frmJucariiAdd.GetSelectedBrandId(panelBranduri);
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


                if (categoria != null && brand != null && txtDenumire.Text != "" && txtTara.Text != "" && (comboSex.Text == "F" || comboSex.Text == "M" || comboSex.Text == "F & M") && txtCantitate.Text != "" && txtPret.Text != "")
                {


                    SqlCommand cmd = new SqlCommand(
                         "UPDATE Produse SET " +
                         "Produse_Denumire = @denumire, " +
                         "Produse_Varsta = @varsta, " +
                         "Brand_uri_Id = @brandId, " +
                         "Produse_Sex = @sex, " +
                         "Produse_Pret = @pret, " +
                         "Produse_Cantitate = @cantitate, " +
                         "Produse_Tara = @tara, " +
                         "Categorii_Id = @categorieId " +
                         "WHERE Produse_Id = @id",
                         con.OpenConnection()
                     );

                    cmd.Parameters.AddWithValue("@denumire", txtDenumire.Text);
                    cmd.Parameters.AddWithValue("@varsta", Convert.ToInt32(numericVarsta.Value));
                    cmd.Parameters.AddWithValue("@brandId", brand_uri_Id);
                    cmd.Parameters.AddWithValue("@sex", comboSex.Text);
                    cmd.Parameters.AddWithValue("@pret", decimal.Parse(txtPret.Text));
                    cmd.Parameters.AddWithValue("@cantitate", int.Parse(txtCantitate.Text));
                    cmd.Parameters.AddWithValue("@tara", txtTara.Text);
                    cmd.Parameters.AddWithValue("@categorieId", categorii_Id);
                    cmd.Parameters.AddWithValue("@id", produsId);

                    cmd.ExecuteNonQuery();
                    con.CloseConnection();
                    MessageBox.Show("Jucăria a fost modificată cu succes!");



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
            catch (Exception ex)
            {
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }
    }
}
