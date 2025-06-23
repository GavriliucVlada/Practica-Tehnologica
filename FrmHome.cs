using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace PracticaTehnologica
{
    public partial class FrmHome : MaterialSkin.Controls.MaterialForm
    {

        private List<Image> imagini = new List<Image>();
        private int index = 0;
        private Timer hideTimer;

        public string actualUser;
        public string actualPassword;

        public int actualID = 0;
        public string actualNume;
        public string actualPrenume;
        public string actualEmail;
        public byte[] actualImagineProfil;
        public int accTest = 0;


        public void SeteazaImaginePeButon(Button buton)
        {
            if (actualImagineProfil != null && actualImagineProfil.Length > 0)
            {
                using (MemoryStream ms = new MemoryStream(actualImagineProfil))
                {
                    Image imagine = Image.FromStream(ms);
                    buton.Image = imagine;
                }
            }
        }

        public static class UtilizatorCurent
        {
            public static int ID { get; set; }
        }

        public FrmHome()
        {
            InitializeComponent();

            imagini.Add(Image.FromFile("C:\\Users\\vladu\\OneDrive\\Desktop\\PracticaTehnologica\\imagini\\image1.png"));
            imagini.Add(Image.FromFile("C:\\Users\\vladu\\OneDrive\\Desktop\\PracticaTehnologica\\imagini\\image2.png"));
            imagini.Add(Image.FromFile("C:\\Users\\vladu\\OneDrive\\Desktop\\PracticaTehnologica\\imagini\\image3.png"));
            imagini.Add(Image.FromFile("C:\\Users\\vladu\\OneDrive\\Desktop\\PracticaTehnologica\\imagini\\image4.png"));
            imagini.Add(Image.FromFile("C:\\Users\\vladu\\OneDrive\\Desktop\\PracticaTehnologica\\imagini\\image5.png"));

            pictureBox1.Image = imagini[index];


            hideTimer = new Timer();
            hideTimer.Interval = 300;
            hideTimer.Tick += HideTimer_Tick;



        }











     

        private void Form1_Load(object sender, EventArgs e)
        {

        }

 

        private void btnJucarii_Click(object sender, EventArgs e)
        {
            FrmProduse jucarii = new FrmProduse();
            if (accTest == 1)
            {
                jucarii.SetCartEnabled();

            }
            else if (accTest == 2)
            {
                jucarii.SetAddEnabled();
                jucarii.SetDelEnabled();
                jucarii.SetModEnabled();
                jucarii.SetStockEnabled();
            }
            jucarii.Show();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            index = (index + 1) % imagini.Count;
            pictureBox1.Image = imagini[index];
        }

        private void btnAccount_MouseEnter(object sender, EventArgs e)
        {
            panelAccount.Visible = true;
            hideTimer.Stop();
        }

        private void panelAccount_MouseEnter(object sender, EventArgs e)
        {
            hideTimer.Stop();
        }

        private void btnAccount_MouseLeave(object sender, EventArgs e)
        {
            hideTimer.Start();
        }

        private void panelAccount_MouseLeave(object sender, EventArgs e)
        {
            hideTimer.Start();

        }

        private void HideTimer_Tick(object sender, EventArgs e)
        {
            if (!btnAccount.Bounds.Contains(PointToClient(Cursor.Position)) &&
                !panelAccount.Bounds.Contains(PointToClient(Cursor.Position)))
            {
                panelAccount.Visible = false;
                hideTimer.Stop();
            }
        }

        private void btnCreateAccount_Click(object sender, EventArgs e)
        {

            panelCreateAccount.Controls.Clear();

            Label lblTitlu = new Label();
            lblTitlu.Name = "lblTitlu";
            lblTitlu.Text = "Crează un nou cont:";
            lblTitlu.Font = new Font("Roboto Slab", 18, FontStyle.Bold);
            lblTitlu.ForeColor = Color.Black;
            lblTitlu.AutoSize = true;
            lblTitlu.Location = new Point(50, 50);

            Label lblNume = new Label();
            lblNume.Name = "lblNume";
            lblNume.Text = "Nume:";
            lblNume.Font = new Font("Roboto Slab", 14, FontStyle.Bold);
            lblNume.ForeColor = Color.Black;
            lblNume.Location = new Point(50, 130);

            TextBox txtNume = new TextBox();
            txtNume.Name = "txtNume";
            txtNume.ForeColor= Color.Black;
            txtNume.Font = new Font("Roboto Slab", 14, FontStyle.Regular);
            txtNume.Location = new Point(200, 130);
            txtNume.Width = 270;
            txtNume.BackColor = Color.FromArgb(255, 235, 226);


            Label lblPrenume = new Label();
            lblPrenume.Name = "lblPrenume";
            lblPrenume.Text = "Prenume:";
            lblPrenume.Font = new Font("Roboto Slab", 14, FontStyle.Bold);
            lblPrenume.ForeColor = Color.Black;
            lblPrenume.Location = new Point(50, 180);

            TextBox txtPrenume = new TextBox();
            txtPrenume.Name = "txtPrenume";
            txtPrenume.ForeColor = Color.Black;
            txtPrenume.Font = new Font("Roboto Slab", 14, FontStyle.Regular);
            txtPrenume.Location = new Point(200, 180);
            txtPrenume.Width = 270;
            txtPrenume.BackColor = Color.FromArgb(255, 235, 226);

            Label lblEmail = new Label();
            lblEmail.Name = "lblEmail";
            lblEmail.Text = "Email:";
            lblEmail.Font = new Font("Roboto Slab", 14, FontStyle.Bold);
            lblEmail.ForeColor = Color.Black;
            lblEmail.Location = new Point(50, 230);

            TextBox txtEmail = new TextBox();
            txtEmail.Name = "txtEmail";
            txtEmail.ForeColor = Color.Black;
            txtEmail.Font = new Font("Roboto Slab", 14, FontStyle.Regular);
            txtEmail.Location = new Point(200, 230);
            txtEmail.Width = 270;
            txtEmail.BackColor = Color.FromArgb(255, 235, 226);

            Label lblUsername = new Label();
            lblUsername.Name = "lblUsername";
            lblUsername.Text = "Username:";
            lblUsername.Font = new Font("Roboto Slab", 14, FontStyle.Bold);
            lblUsername.ForeColor = Color.Black;
            lblUsername.AutoSize = true;
            lblUsername.Location = new Point(50, 280);

            TextBox txtUsername = new TextBox();
            txtUsername.Name = "txtUsername";
            txtUsername.ForeColor = Color.Black;
            txtUsername.Font = new Font("Roboto Slab", 14, FontStyle.Regular);
            txtUsername.Location = new Point(200, 280);
            txtUsername.Width = 270;
            txtUsername.BackColor = Color.FromArgb(255, 235, 226);

            Label lblPassword = new Label();
            lblPassword.Name = "lblPassword";
            lblPassword.Text = "Password:";
            lblPassword.Font = new Font("Roboto Slab", 14, FontStyle.Bold);
            lblPassword.ForeColor = Color.Black;
            lblPassword.AutoSize = true;
            lblPassword.Location = new Point(550, 130);

            TextBox txtPassword = new TextBox();
            txtPassword.Name = "txtPassword";
            txtPassword.ForeColor = Color.Black;
            txtPassword.Font = new Font("Roboto Slab", 14, FontStyle.Regular);
            txtPassword.Location = new Point(700, 130);
            txtPassword.Width = 270;
            txtPassword.BackColor = Color.FromArgb(255, 235, 226);


            Label lblVarsta = new Label();
            lblVarsta.Name = "lblVarsta";
            lblVarsta.Text = "Varsta:";
            lblVarsta.Font = new Font("Roboto Slab", 14, FontStyle.Bold);
            lblVarsta.ForeColor = Color.Black;
            lblVarsta.AutoSize = true;
            lblVarsta.Location = new Point(730, 180);

            TextBox txtVarsta = new TextBox();
            txtVarsta.Name = "txtVarsta";
            txtVarsta.ForeColor = Color.Black;
            txtVarsta.Font = new Font("Roboto Slab", 14, FontStyle.Regular);
            txtVarsta.Location = new Point(870, 180);
            txtVarsta.Width = 100;
            txtVarsta.BackColor = Color.FromArgb(255, 235, 226);





            PictureBox pictureProfil = new PictureBox();
            pictureProfil.Name = "pictureProfil";
            pictureProfil.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureProfil.BorderStyle = BorderStyle.FixedSingle;
            pictureProfil.BackColor = Color.White;
            pictureProfil.Location = new Point(560, 180); 
            pictureProfil.Size = new Size(100, 100);

            
            Button btnSelecteazaImagine = new Button();
            btnSelecteazaImagine.Name = "btnSelecteazaImagine";
            btnSelecteazaImagine.Text = "Selectează Imaginea";
            btnSelecteazaImagine.Font = new Font("Roboto Slab", 11, FontStyle.Bold);
            btnSelecteazaImagine.BackColor = Color.FromArgb(133, 44, 3);
            btnSelecteazaImagine.ForeColor = Color.White;
            btnSelecteazaImagine.TextAlign = ContentAlignment.MiddleCenter;
            btnSelecteazaImagine.Location = new Point(550, 290);
            btnSelecteazaImagine.Size = new Size(120, 50);

            panelCreateAccount.Controls.Add(lblTitlu);
            panelCreateAccount.Controls.Add(lblNume);
            panelCreateAccount.Controls.Add(txtNume);
            panelCreateAccount.Controls.Add(lblVarsta);
            panelCreateAccount.Controls.Add(txtVarsta);
            panelCreateAccount.Controls.Add(txtPrenume);
            panelCreateAccount.Controls.Add(lblPrenume);
            panelCreateAccount.Controls.Add(lblEmail);
            panelCreateAccount.Controls.Add(txtEmail);
            panelCreateAccount.Controls.Add(lblUsername);
            panelCreateAccount.Controls.Add(txtUsername);
            panelCreateAccount.Controls.Add(lblPassword);
            panelCreateAccount.Controls.Add(txtPassword);
            panelCreateAccount.Controls.Add(pictureProfil);
            panelCreateAccount.Controls.Add(btnSelecteazaImagine);


           

            btnSelecteazaImagine.Click += (s, ev) =>
            {
                OpenFileDialog dialog = new OpenFileDialog();
                dialog.Title = "Selectează o imagine de profil";
                dialog.Filter = "Fișiere imagine|*.jpg;*.jpeg;*.png;*.bmp;*.gif";

                if (dialog.ShowDialog() == DialogResult.OK)
                {
                    pictureProfil.Image = Image.FromFile(dialog.FileName);

                }
            };

            Button btnSalveazaCont = new Button();
            btnSalveazaCont.Text = "Cont Utilizator";
            btnSalveazaCont.Location = new Point(730, 230);
            btnSalveazaCont.Size = new Size(240, 50);
            btnSalveazaCont.Font = new Font("Roboto Slab", 16, FontStyle.Bold);
            btnSalveazaCont.BackColor = Color.FromArgb(234, 101, 39);
            btnSalveazaCont.ForeColor = Color.White;
            panelCreateAccount.Controls.Add(btnSalveazaCont);

            Button btnSalveazaContAdministrator = new Button();
            btnSalveazaContAdministrator.Text = "Cont Administrator";
            btnSalveazaContAdministrator.Location = new Point(730, 290);
            btnSalveazaContAdministrator.Size = new Size(240, 50);
            btnSalveazaContAdministrator.Font = new Font("Roboto Slab", 16, FontStyle.Bold);
            btnSalveazaContAdministrator.BackColor = Color.FromArgb(234, 101, 39);
            btnSalveazaContAdministrator.ForeColor = Color.White;
            panelCreateAccount.Controls.Add(btnSalveazaContAdministrator);




            btnSalveazaCont.Click += (s, ev) =>
            {
                
                TextBox Nume = (TextBox)panelCreateAccount.Controls.Find("txtNume", true).FirstOrDefault();
                TextBox Prenume = (TextBox)panelCreateAccount.Controls.Find("txtPrenume", true).FirstOrDefault();
                TextBox Email = (TextBox)panelCreateAccount.Controls.Find("txtEmail", true).FirstOrDefault();
                TextBox Username = (TextBox)panelCreateAccount.Controls.Find("txtUsername", true).FirstOrDefault();
                TextBox Password = (TextBox)panelCreateAccount.Controls.Find("txtPassword", true).FirstOrDefault();
                PictureBox picture = (PictureBox)panelCreateAccount.Controls.Find("pictureProfil", true).FirstOrDefault();

                byte[] imagineInBytes = null;
                if (pictureProfil != null && pictureProfil.Image != null)
                {
                    using (MemoryStream ms = new MemoryStream())
                    {
                        pictureProfil.Image.Save(ms, pictureProfil.Image.RawFormat);
                        imagineInBytes = ms.ToArray();
                    }
                }

                if (txtNume.Text != "" && txtPrenume.Text != "" && txtEmail.Text != "" && txtPassword.Text != "" && txtUsername.Text != "" && txtVarsta.Text != "")
                {

                    string connectionString = "Data Source=VLADUTA\\SQLEXPRESS;Initial Catalog=Lumea_Copiilor;Integrated Security=True";
                    using (SqlConnection conn = new SqlConnection(connectionString))
                    {
                        conn.Open();
                        string query = @"INSERT INTO Utilizatori (Nume, Prenume, Email, Username, Parola, ImagineProfil)
                         VALUES (@nume, @prenume, @email, @username, @parola, @imagine)";

                        using (SqlCommand cmd = new SqlCommand(query, conn))
                        {
                            cmd.Parameters.AddWithValue("@nume", txtNume.Text);
                            cmd.Parameters.AddWithValue("@prenume", txtPrenume.Text);
                            cmd.Parameters.AddWithValue("@email", txtEmail.Text);
                            cmd.Parameters.AddWithValue("@username", txtUsername.Text);
                            cmd.Parameters.AddWithValue("@parola", txtPassword.Text);
                            cmd.Parameters.Add("@imagine", SqlDbType.VarBinary).Value = (object)imagineInBytes ?? DBNull.Value;

                            int rows = cmd.ExecuteNonQuery();
                            if (rows > 0)
                            {
                                MessageBox.Show("Contul a fost salvat cu succes!");
                                panelCreateAccount.Controls.Clear();
                            }
                            else
                                MessageBox.Show("Eroare la salvare.");
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Introduceti toate datele!");
                }
            };




            btnSalveazaContAdministrator.Click += (s, ev) =>
            {

                TextBox Nume = (TextBox)panelCreateAccount.Controls.Find("txtNume", true).FirstOrDefault();
                TextBox Prenume = (TextBox)panelCreateAccount.Controls.Find("txtPrenume", true).FirstOrDefault();
                TextBox Email = (TextBox)panelCreateAccount.Controls.Find("txtEmail", true).FirstOrDefault();
                TextBox Username = (TextBox)panelCreateAccount.Controls.Find("txtUsername", true).FirstOrDefault();
                TextBox Password = (TextBox)panelCreateAccount.Controls.Find("txtPassword", true).FirstOrDefault();
                PictureBox picture = (PictureBox)panelCreateAccount.Controls.Find("pictureProfil", true).FirstOrDefault();





                byte[] imagineInBytes = null;
                if (pictureProfil != null && pictureProfil.Image != null)
                {
                    using (MemoryStream ms = new MemoryStream())
                    {
                        pictureProfil.Image.Save(ms, pictureProfil.Image.RawFormat);
                        imagineInBytes = ms.ToArray();
                    }
                }

                if (txtNume.Text != "" && txtPrenume.Text != "" && txtEmail.Text != "" && txtPassword.Text != "" && txtUsername.Text != "" && txtVarsta.Text != "")
                {

                    FrmVerifyAdmin frmVerifyAdmin = new FrmVerifyAdmin(
                        txtNume.Text,
                        txtPrenume.Text,
                        txtEmail.Text,
                        txtUsername.Text,
                        txtPassword.Text,
                        imagineInBytes
                     );
                    panelCreateAccount.Controls.Clear();

                    frmVerifyAdmin.Show();

                   

                }
                else
                {
                    MessageBox.Show("Introduceti toate datele!");
                }

                
            };



        }

        private void panelCreateAccount_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnLogIn_Click(object sender, EventArgs e)
        {
            panelCreateAccount.Controls.Clear ();


            Label lblTitlu = new Label();
            lblTitlu.Name = "lblTitlu";
            lblTitlu.Text = "Log In:";
            lblTitlu.Font = new Font("Roboto Slab", 18, FontStyle.Bold);
            lblTitlu.ForeColor = Color.Black;
            lblTitlu.AutoSize = true;
            lblTitlu.Location = new Point(50, 50);

            Label lblUsername = new Label();
            lblUsername.Name = "lblUsername";
            lblUsername.Text = "Username:";
            lblUsername.Font = new Font("Roboto Slab", 14, FontStyle.Bold);
            lblUsername.ForeColor = Color.Black;
            lblUsername.Location = new Point(50, 150);
            lblUsername.AutoSize = true;

            TextBox txtUsername = new TextBox();
            txtUsername.Name = "txtUsername";
            txtUsername.ForeColor = Color.Black;
            txtUsername.Font = new Font("Roboto Slab", 14, FontStyle.Regular);
            txtUsername.Location = new Point(200, 150);
            txtUsername.Width = 270;
            txtUsername.BackColor = Color.FromArgb(255, 235, 226);


            Label lblPassword = new Label();
            lblPassword.Name = "lblUPassword";
            lblPassword.Text = "Password:";
            lblPassword.Font = new Font("Roboto Slab", 14, FontStyle.Bold);
            lblPassword.ForeColor = Color.Black;
            lblPassword.Location = new Point(50, 220);
            lblPassword.AutoSize = true;

            TextBox txtPassword = new TextBox();
            txtPassword.Name = "txtPassword";
            txtPassword.ForeColor = Color.Black;
            txtPassword.Font = new Font("Roboto Slab", 14, FontStyle.Regular);
            txtPassword.Location = new Point(200, 220);
            txtPassword.Width = 270;
            txtPassword.PasswordChar = '*';
            txtPassword.BackColor = Color.FromArgb(255, 235, 226);


            Button btnLogare = new Button();
            btnLogare.Text = "Log In";
            btnLogare.Location = new Point(50, 300);
            btnLogare.Size = new Size(420, 50);
            btnLogare.Font = new Font("Roboto Slab", 16, FontStyle.Bold);
            btnLogare.BackColor = Color.FromArgb(234, 101, 39);
            btnLogare.ForeColor = Color.White;


            panelCreateAccount.Controls.Add(btnLogare);
            panelCreateAccount.Controls.Add(lblTitlu);
            panelCreateAccount.Controls.Add(lblUsername);
            panelCreateAccount.Controls.Add(txtUsername);
            panelCreateAccount.Controls.Add(lblPassword);
            panelCreateAccount.Controls.Add(txtPassword);


            btnLogare.Click += (s, ev) =>
            {
                if (!string.IsNullOrWhiteSpace(txtUsername.Text) && !string.IsNullOrWhiteSpace(txtPassword.Text))
                {
                    string connectionString = "Data Source=VLADUTA\\SQLEXPRESS;Initial Catalog=Lumea_Copiilor;Integrated Security=True";

                    using (SqlConnection conn = new SqlConnection(connectionString))
                    {
                        conn.Open();

                        string query = "SELECT * FROM Utilizatori WHERE Username = @username AND Parola = @parola";

                        using (SqlCommand cmd = new SqlCommand(query, conn))
                        {
                            cmd.Parameters.AddWithValue("@username", txtUsername.Text);
                            cmd.Parameters.AddWithValue("@parola", txtPassword.Text);

                            using (SqlDataReader reader = cmd.ExecuteReader())
                            {
                                if (reader.Read())
                                {
                                    actualID = reader.GetInt32(reader.GetOrdinal("ID"));
                                    actualNume = reader.GetString(reader.GetOrdinal("Nume"));
                                    actualPrenume = reader.GetString(reader.GetOrdinal("Prenume"));
                                    actualEmail = reader.GetString(reader.GetOrdinal("Email"));
                                    actualUser = reader.GetString(reader.GetOrdinal("Username"));
                                    actualPassword = reader.GetString(reader.GetOrdinal("Parola"));
                                    actualImagineProfil = reader["ImagineProfil"] as byte[];
                                    UtilizatorCurent.ID = this.actualID;

                                    accTest = 1;

                                   
                                    MessageBox.Show($"Bine ai venit, {actualNume} {actualPrenume}!");

                                    btnCosCumparaturi.Enabled = true; 
                                    btnHistory.Enabled = false;

                                }

                            }
                        }



                        string queryAdm = "SELECT * FROM Administrator WHERE Username = @username AND Parola = @parola";

                        using (SqlCommand cmd = new SqlCommand(queryAdm, conn))
                        {
                            cmd.Parameters.AddWithValue("@username", txtUsername.Text);
                            cmd.Parameters.AddWithValue("@parola", txtPassword.Text);

                            using (SqlDataReader reader = cmd.ExecuteReader())
                            {
                                if (reader.Read())
                                {
                                    actualID = reader.GetInt32(reader.GetOrdinal("ID"));
                                    actualNume = reader.GetString(reader.GetOrdinal("Nume"));
                                    actualPrenume = reader.GetString(reader.GetOrdinal("Prenume"));
                                    actualEmail = reader.GetString(reader.GetOrdinal("Email"));
                                    actualUser = reader.GetString(reader.GetOrdinal("Username"));
                                    actualPassword = reader.GetString(reader.GetOrdinal("Parola"));
                                    actualImagineProfil = reader["ImagineProfil"] as byte[];

                                    accTest = 2;


                                    MessageBox.Show($"Bine ai venit, {actualNume} {actualPrenume}!");

                                    btnHistory.Enabled = true;
                                    btnCosCumparaturi.Enabled = false;

                                }
                                    
                            }
                        }


                        if ( accTest != 1 && accTest !=2)
                        {
                            MessageBox.Show("Ați introdus datele greșit!");
                        }



                        SeteazaImaginePeButon(btnAccount);









                    }

                    panelCreateAccount.Controls.Clear();





                }
                else
                {
                    MessageBox.Show("Introduceți toate datele!");
                }
            };



        }

        private void btnAccount_Click(object sender, EventArgs e)
        {
            panelCreateAccount.Controls.Clear();

            if (accTest == 1 || accTest == 2)
            {
                Label lblTitlu = new Label();
                lblTitlu.Name = "lblTitlu";
                lblTitlu.Text = "Date Utilizator:";
                lblTitlu.Font = new Font("Roboto Slab", 18, FontStyle.Bold);
                lblTitlu.ForeColor = Color.Black;
                lblTitlu.AutoSize = true;
                lblTitlu.Location = new Point(50, 50);

                Label lblName = new Label();
                lblName.Name = "lblName";
                lblName.Text = "Nume:";
                lblName.Font = new Font("Roboto Slab", 16, FontStyle.Regular);
                lblName.ForeColor = Color.DimGray;
                lblName.AutoSize = true;
                lblName.Location = new Point(50, 120);

                Label txtName = new Label();
                txtName.Name = "lblName";
                txtName.Text = actualNume.ToString();
                txtName.Font = new Font("Roboto Slab", 16, FontStyle.Regular);
                txtName.ForeColor = Color.DimGray;
                txtName.AutoSize = true;
                txtName.Location = new Point(170, 120);

                Label lblPrenume = new Label();
                lblPrenume.Name = "lblPrenume";
                lblPrenume.Text = "Prenume:";
                lblPrenume.Font = new Font("Roboto Slab", 16, FontStyle.Regular);
                lblPrenume.ForeColor = Color.DimGray;
                lblPrenume.AutoSize = true;
                lblPrenume.Location = new Point(50, 170);

                Label txtPrenume = new Label();
                txtPrenume.Name = "txtPrenume";
                txtPrenume.Text = actualPrenume.ToString();
                txtPrenume.Font = new Font("Roboto Slab", 16, FontStyle.Regular);
                txtPrenume.ForeColor = Color.DimGray;
                txtPrenume.AutoSize = true;
                txtPrenume.Location = new Point(170, 170);

                Label lbluser = new Label();
                lbluser.Name = "lbluser";
                lbluser.Text = "Username:";
                lbluser.Font = new Font("Roboto Slab", 16, FontStyle.Regular);
                lbluser.ForeColor = Color.DimGray;
                lbluser.AutoSize = true;
                lbluser.Location = new Point(50, 220);

                Label txtuser = new Label();
                txtuser.Name = "txtuser";
                txtuser.Text = actualUser.ToString();
                txtuser.Font = new Font("Roboto Slab", 16, FontStyle.Regular);
                txtuser.ForeColor = Color.DimGray;
                txtuser.AutoSize = true;
                txtuser.Location = new Point(170, 220);

                Label lblemail = new Label();
                lblemail.Name = "lblemail";
                lblemail.Text = "Email:";
                lblemail.Font = new Font("Roboto Slab", 16, FontStyle.Regular);
                lblemail.ForeColor = Color.DimGray;
                lblemail.AutoSize = true;
                lblemail.Location = new Point(50, 270);

                Label txtemail = new Label();
                txtemail.Name = "txtemail";
                txtemail.Text = actualEmail.ToString();
                txtemail.Font = new Font("Roboto Slab", 16, FontStyle.Regular);
                txtemail.ForeColor = Color.DimGray;
                txtemail.AutoSize = true;
                txtemail.Location = new Point(170, 270);

                panelCreateAccount.Controls.Add(lblTitlu);
                panelCreateAccount.Controls.Add(lblName);
                panelCreateAccount.Controls.Add(txtName);
                panelCreateAccount.Controls.Add(lblPrenume);
                panelCreateAccount.Controls.Add(txtPrenume);
                panelCreateAccount.Controls.Add(lbluser);
                panelCreateAccount.Controls.Add(txtuser);
                panelCreateAccount.Controls.Add(lblemail);
                panelCreateAccount.Controls.Add(txtemail);

            }

        }

        private void btnCosCumparaturi_Click(object sender, EventArgs e)
        {
            FrmCart cart = new FrmCart();
            cart.Show();
        }

        private void btnHistory_Click(object sender, EventArgs e)
        {
            FrmHistory history = new FrmHistory();
            history.Show();
        }
    }
}
