namespace PracticaTehnologica
{
    partial class FrmHome
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmHome));
            this.GroupBoxMeniu = new System.Windows.Forms.GroupBox();
            this.btnJucarenia = new System.Windows.Forms.Button();
            this.btnAccount = new System.Windows.Forms.Button();
            this.panelAccount = new System.Windows.Forms.Panel();
            this.btnLogIn = new System.Windows.Forms.Button();
            this.btnCreateAccount = new System.Windows.Forms.Button();
            this.btnHistory = new System.Windows.Forms.Button();
            this.btnCosCumparaturi = new System.Windows.Forms.Button();
            this.btnJucării = new System.Windows.Forms.Button();
            this.panelCreateAccount = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.GroupBoxMeniu.SuspendLayout();
            this.panelAccount.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // GroupBoxMeniu
            // 
            this.GroupBoxMeniu.BackColor = System.Drawing.Color.White;
            this.GroupBoxMeniu.Controls.Add(this.btnJucarenia);
            this.GroupBoxMeniu.Controls.Add(this.btnAccount);
            this.GroupBoxMeniu.Controls.Add(this.panelAccount);
            this.GroupBoxMeniu.Controls.Add(this.btnHistory);
            this.GroupBoxMeniu.Controls.Add(this.btnCosCumparaturi);
            this.GroupBoxMeniu.Controls.Add(this.btnJucării);
            this.GroupBoxMeniu.Location = new System.Drawing.Point(12, 80);
            this.GroupBoxMeniu.Name = "GroupBoxMeniu";
            this.GroupBoxMeniu.Size = new System.Drawing.Size(296, 808);
            this.GroupBoxMeniu.TabIndex = 1;
            this.GroupBoxMeniu.TabStop = false;
            // 
            // btnJucarenia
            // 
            this.btnJucarenia.BackColor = System.Drawing.Color.Transparent;
            this.btnJucarenia.FlatAppearance.BorderSize = 0;
            this.btnJucarenia.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.btnJucarenia.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.btnJucarenia.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnJucarenia.Image = ((System.Drawing.Image)(resources.GetObject("btnJucarenia.Image")));
            this.btnJucarenia.Location = new System.Drawing.Point(43, 45);
            this.btnJucarenia.Margin = new System.Windows.Forms.Padding(2);
            this.btnJucarenia.Name = "btnJucarenia";
            this.btnJucarenia.Size = new System.Drawing.Size(211, 60);
            this.btnJucarenia.TabIndex = 7;
            this.btnJucarenia.UseVisualStyleBackColor = false;
            // 
            // btnAccount
            // 
            this.btnAccount.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(101)))), ((int)(((byte)(39)))));
            this.btnAccount.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(206)))), ((int)(((byte)(183)))));
            this.btnAccount.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(89)))), ((int)(((byte)(30)))));
            this.btnAccount.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(119)))), ((int)(((byte)(55)))));
            this.btnAccount.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAccount.Font = new System.Drawing.Font("Roboto Slab", 21F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnAccount.ForeColor = System.Drawing.Color.White;
            this.btnAccount.Image = ((System.Drawing.Image)(resources.GetObject("btnAccount.Image")));
            this.btnAccount.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAccount.Location = new System.Drawing.Point(49, 733);
            this.btnAccount.Name = "btnAccount";
            this.btnAccount.Size = new System.Drawing.Size(190, 50);
            this.btnAccount.TabIndex = 2;
            this.btnAccount.Text = "Account";
            this.btnAccount.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAccount.UseVisualStyleBackColor = false;
            this.btnAccount.Click += new System.EventHandler(this.btnAccount_Click);
            this.btnAccount.MouseEnter += new System.EventHandler(this.btnAccount_MouseEnter);
            this.btnAccount.MouseLeave += new System.EventHandler(this.btnAccount_MouseLeave);
            // 
            // panelAccount
            // 
            this.panelAccount.Controls.Add(this.btnLogIn);
            this.panelAccount.Controls.Add(this.btnCreateAccount);
            this.panelAccount.Location = new System.Drawing.Point(49, 606);
            this.panelAccount.Name = "panelAccount";
            this.panelAccount.Size = new System.Drawing.Size(190, 125);
            this.panelAccount.TabIndex = 3;
            this.panelAccount.Visible = false;
            this.panelAccount.MouseEnter += new System.EventHandler(this.panelAccount_MouseEnter);
            this.panelAccount.MouseLeave += new System.EventHandler(this.panelAccount_MouseLeave);
            // 
            // btnLogIn
            // 
            this.btnLogIn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(101)))), ((int)(((byte)(39)))));
            this.btnLogIn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(206)))), ((int)(((byte)(183)))));
            this.btnLogIn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(89)))), ((int)(((byte)(30)))));
            this.btnLogIn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(119)))), ((int)(((byte)(55)))));
            this.btnLogIn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogIn.Font = new System.Drawing.Font("Roboto Slab", 12F);
            this.btnLogIn.ForeColor = System.Drawing.Color.White;
            this.btnLogIn.Image = ((System.Drawing.Image)(resources.GetObject("btnLogIn.Image")));
            this.btnLogIn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLogIn.Location = new System.Drawing.Point(3, 55);
            this.btnLogIn.Name = "btnLogIn";
            this.btnLogIn.Size = new System.Drawing.Size(184, 47);
            this.btnLogIn.TabIndex = 3;
            this.btnLogIn.Text = "Log In";
            this.btnLogIn.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnLogIn.UseVisualStyleBackColor = false;
            this.btnLogIn.Click += new System.EventHandler(this.btnLogIn_Click);
            // 
            // btnCreateAccount
            // 
            this.btnCreateAccount.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(101)))), ((int)(((byte)(39)))));
            this.btnCreateAccount.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(206)))), ((int)(((byte)(183)))));
            this.btnCreateAccount.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(89)))), ((int)(((byte)(30)))));
            this.btnCreateAccount.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(119)))), ((int)(((byte)(55)))));
            this.btnCreateAccount.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCreateAccount.Font = new System.Drawing.Font("Roboto Slab", 12F);
            this.btnCreateAccount.ForeColor = System.Drawing.Color.White;
            this.btnCreateAccount.Image = ((System.Drawing.Image)(resources.GetObject("btnCreateAccount.Image")));
            this.btnCreateAccount.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCreateAccount.Location = new System.Drawing.Point(3, 4);
            this.btnCreateAccount.Name = "btnCreateAccount";
            this.btnCreateAccount.Size = new System.Drawing.Size(184, 47);
            this.btnCreateAccount.TabIndex = 4;
            this.btnCreateAccount.Text = "Create Accaunt";
            this.btnCreateAccount.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCreateAccount.UseVisualStyleBackColor = false;
            this.btnCreateAccount.Click += new System.EventHandler(this.btnCreateAccount_Click);
            // 
            // btnHistory
            // 
            this.btnHistory.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(101)))), ((int)(((byte)(39)))));
            this.btnHistory.Enabled = false;
            this.btnHistory.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(206)))), ((int)(((byte)(183)))));
            this.btnHistory.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(89)))), ((int)(((byte)(30)))));
            this.btnHistory.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(119)))), ((int)(((byte)(55)))));
            this.btnHistory.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHistory.Font = new System.Drawing.Font("Roboto Slab", 21F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnHistory.ForeColor = System.Drawing.Color.White;
            this.btnHistory.Image = ((System.Drawing.Image)(resources.GetObject("btnHistory.Image")));
            this.btnHistory.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnHistory.Location = new System.Drawing.Point(49, 315);
            this.btnHistory.Name = "btnHistory";
            this.btnHistory.Size = new System.Drawing.Size(190, 50);
            this.btnHistory.TabIndex = 2;
            this.btnHistory.Text = "History";
            this.btnHistory.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnHistory.UseVisualStyleBackColor = false;
            this.btnHistory.Click += new System.EventHandler(this.btnHistory_Click);
            // 
            // btnCosCumparaturi
            // 
            this.btnCosCumparaturi.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(101)))), ((int)(((byte)(39)))));
            this.btnCosCumparaturi.Enabled = false;
            this.btnCosCumparaturi.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(206)))), ((int)(((byte)(183)))));
            this.btnCosCumparaturi.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(89)))), ((int)(((byte)(30)))));
            this.btnCosCumparaturi.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(119)))), ((int)(((byte)(55)))));
            this.btnCosCumparaturi.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCosCumparaturi.Font = new System.Drawing.Font("Roboto Slab", 21F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnCosCumparaturi.ForeColor = System.Drawing.Color.White;
            this.btnCosCumparaturi.Image = ((System.Drawing.Image)(resources.GetObject("btnCosCumparaturi.Image")));
            this.btnCosCumparaturi.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCosCumparaturi.Location = new System.Drawing.Point(49, 245);
            this.btnCosCumparaturi.Name = "btnCosCumparaturi";
            this.btnCosCumparaturi.Size = new System.Drawing.Size(190, 50);
            this.btnCosCumparaturi.TabIndex = 2;
            this.btnCosCumparaturi.Text = "Cart";
            this.btnCosCumparaturi.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCosCumparaturi.UseVisualStyleBackColor = false;
            this.btnCosCumparaturi.Click += new System.EventHandler(this.btnCosCumparaturi_Click);
            // 
            // btnJucării
            // 
            this.btnJucării.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(101)))), ((int)(((byte)(39)))));
            this.btnJucării.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(206)))), ((int)(((byte)(183)))));
            this.btnJucării.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(89)))), ((int)(((byte)(30)))));
            this.btnJucării.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(119)))), ((int)(((byte)(55)))));
            this.btnJucării.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnJucării.Font = new System.Drawing.Font("Roboto Slab", 21F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnJucării.ForeColor = System.Drawing.Color.White;
            this.btnJucării.Image = ((System.Drawing.Image)(resources.GetObject("btnJucării.Image")));
            this.btnJucării.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnJucării.Location = new System.Drawing.Point(49, 168);
            this.btnJucării.Name = "btnJucării";
            this.btnJucării.Size = new System.Drawing.Size(190, 50);
            this.btnJucării.TabIndex = 2;
            this.btnJucării.Text = "Toys";
            this.btnJucării.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnJucării.UseVisualStyleBackColor = false;
            this.btnJucării.Click += new System.EventHandler(this.btnJucarii_Click);
            // 
            // panelCreateAccount
            // 
            this.panelCreateAccount.BackColor = System.Drawing.Color.White;
            this.panelCreateAccount.Location = new System.Drawing.Point(314, 486);
            this.panelCreateAccount.Name = "panelCreateAccount";
            this.panelCreateAccount.Size = new System.Drawing.Size(1111, 402);
            this.panelCreateAccount.TabIndex = 2;
            this.panelCreateAccount.Paint += new System.Windows.Forms.PaintEventHandler(this.panelCreateAccount_Paint);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.White;
            this.groupBox1.Location = new System.Drawing.Point(314, 80);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1111, 66);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(314, 155);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1111, 325);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 3000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // FrmHome
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.ClientSize = new System.Drawing.Size(1440, 900);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.panelCreateAccount);
            this.Controls.Add(this.GroupBoxMeniu);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "FrmHome";
            this.Text = "Home";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.GroupBoxMeniu.ResumeLayout(false);
            this.panelAccount.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox GroupBoxMeniu;
        private System.Windows.Forms.Button btnJucării;
        private System.Windows.Forms.Panel panelCreateAccount;
        private System.Windows.Forms.Button btnHistory;
        private System.Windows.Forms.Button btnCosCumparaturi;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnAccount;
        private System.Windows.Forms.Panel panelAccount;
        private System.Windows.Forms.Button btnCreateAccount;
        private System.Windows.Forms.Button btnLogIn;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button btnJucarenia;
    }
}

