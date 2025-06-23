namespace PracticaTehnologica
{
    partial class FrmProduse
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmProduse));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.groupBoxMenu = new System.Windows.Forms.GroupBox();
            this.btnStock = new System.Windows.Forms.Button();
            this.btnCart = new System.Windows.Forms.Button();
            this.btnModify = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnADD = new System.Windows.Forms.Button();
            this.btnHome = new System.Windows.Forms.Button();
            this.dataGridViewJucarii = new System.Windows.Forms.DataGridView();
            this.produseIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.produseDenumireDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.produseVarstaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.branduriDenumireDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Produse_Sex = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.produsePretDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.produseCantitateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.produseTaraDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.categoriiDenumireDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.afisareProduseBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.lumea_CopiilorDataSet = new PracticaTehnologica.Lumea_CopiilorDataSet();
            this.afisare_ProduseTableAdapter = new PracticaTehnologica.Lumea_CopiilorDataSetTableAdapters.Afisare_ProduseTableAdapter();
            this.groupBoxSortare = new System.Windows.Forms.GroupBox();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.btn3 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.groupBoxMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewJucarii)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.afisareProduseBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lumea_CopiilorDataSet)).BeginInit();
            this.groupBoxSortare.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBoxMenu
            // 
            this.groupBoxMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.groupBoxMenu.Controls.Add(this.btnStock);
            this.groupBoxMenu.Controls.Add(this.btnCart);
            this.groupBoxMenu.Controls.Add(this.btnModify);
            this.groupBoxMenu.Controls.Add(this.btnDelete);
            this.groupBoxMenu.Controls.Add(this.btnADD);
            this.groupBoxMenu.Controls.Add(this.btnHome);
            this.groupBoxMenu.ForeColor = System.Drawing.Color.White;
            this.groupBoxMenu.Location = new System.Drawing.Point(29, 69);
            this.groupBoxMenu.Name = "groupBoxMenu";
            this.groupBoxMenu.Size = new System.Drawing.Size(1376, 54);
            this.groupBoxMenu.TabIndex = 0;
            this.groupBoxMenu.TabStop = false;
            // 
            // btnStock
            // 
            this.btnStock.BackColor = System.Drawing.Color.White;
            this.btnStock.Enabled = false;
            this.btnStock.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(62)))), ((int)(((byte)(90)))));
            this.btnStock.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gainsboro;
            this.btnStock.FlatAppearance.MouseOverBackColor = System.Drawing.Color.WhiteSmoke;
            this.btnStock.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStock.Font = new System.Drawing.Font("Roboto Slab ExtraBold", 16F, System.Drawing.FontStyle.Bold);
            this.btnStock.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(60)))), ((int)(((byte)(90)))));
            this.btnStock.Location = new System.Drawing.Point(85, 11);
            this.btnStock.Margin = new System.Windows.Forms.Padding(0);
            this.btnStock.Name = "btnStock";
            this.btnStock.Size = new System.Drawing.Size(171, 38);
            this.btnStock.TabIndex = 3;
            this.btnStock.Text = "Out Of Stock";
            this.btnStock.UseVisualStyleBackColor = false;
            this.btnStock.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnCart
            // 
            this.btnCart.BackColor = System.Drawing.Color.White;
            this.btnCart.Enabled = false;
            this.btnCart.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(62)))), ((int)(((byte)(90)))));
            this.btnCart.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gainsboro;
            this.btnCart.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.btnCart.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCart.Image = ((System.Drawing.Image)(resources.GetObject("btnCart.Image")));
            this.btnCart.Location = new System.Drawing.Point(1308, 9);
            this.btnCart.Margin = new System.Windows.Forms.Padding(0);
            this.btnCart.Name = "btnCart";
            this.btnCart.Size = new System.Drawing.Size(60, 41);
            this.btnCart.TabIndex = 2;
            this.btnCart.UseVisualStyleBackColor = false;
            this.btnCart.Click += new System.EventHandler(this.btnCart_Click);
            // 
            // btnModify
            // 
            this.btnModify.BackColor = System.Drawing.Color.White;
            this.btnModify.Enabled = false;
            this.btnModify.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(62)))), ((int)(((byte)(90)))));
            this.btnModify.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gainsboro;
            this.btnModify.FlatAppearance.MouseOverBackColor = System.Drawing.Color.WhiteSmoke;
            this.btnModify.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnModify.Font = new System.Drawing.Font("Roboto Slab ExtraBold", 16F, System.Drawing.FontStyle.Bold);
            this.btnModify.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(60)))), ((int)(((byte)(90)))));
            this.btnModify.Location = new System.Drawing.Point(1159, 11);
            this.btnModify.Margin = new System.Windows.Forms.Padding(0);
            this.btnModify.Name = "btnModify";
            this.btnModify.Size = new System.Drawing.Size(139, 38);
            this.btnModify.TabIndex = 1;
            this.btnModify.Text = "MODIFY";
            this.btnModify.UseVisualStyleBackColor = false;
            this.btnModify.Click += new System.EventHandler(this.btnModify_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.White;
            this.btnDelete.Enabled = false;
            this.btnDelete.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(62)))), ((int)(((byte)(90)))));
            this.btnDelete.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gainsboro;
            this.btnDelete.FlatAppearance.MouseOverBackColor = System.Drawing.Color.WhiteSmoke;
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDelete.Font = new System.Drawing.Font("Roboto Slab ExtraBold", 16F, System.Drawing.FontStyle.Bold);
            this.btnDelete.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(60)))), ((int)(((byte)(90)))));
            this.btnDelete.Location = new System.Drawing.Point(1009, 11);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(0);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(139, 38);
            this.btnDelete.TabIndex = 1;
            this.btnDelete.Text = "DELETE";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnADD
            // 
            this.btnADD.BackColor = System.Drawing.Color.White;
            this.btnADD.Enabled = false;
            this.btnADD.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(62)))), ((int)(((byte)(90)))));
            this.btnADD.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gainsboro;
            this.btnADD.FlatAppearance.MouseOverBackColor = System.Drawing.Color.WhiteSmoke;
            this.btnADD.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnADD.Font = new System.Drawing.Font("Roboto Slab ExtraBold", 16F, System.Drawing.FontStyle.Bold);
            this.btnADD.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(60)))), ((int)(((byte)(90)))));
            this.btnADD.Location = new System.Drawing.Point(847, 11);
            this.btnADD.Margin = new System.Windows.Forms.Padding(0);
            this.btnADD.Name = "btnADD";
            this.btnADD.Size = new System.Drawing.Size(139, 38);
            this.btnADD.TabIndex = 1;
            this.btnADD.Text = "ADD";
            this.btnADD.UseVisualStyleBackColor = false;
            this.btnADD.Click += new System.EventHandler(this.btnADD_Click);
            // 
            // btnHome
            // 
            this.btnHome.BackColor = System.Drawing.Color.White;
            this.btnHome.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(62)))), ((int)(((byte)(90)))));
            this.btnHome.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gainsboro;
            this.btnHome.FlatAppearance.MouseOverBackColor = System.Drawing.Color.WhiteSmoke;
            this.btnHome.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHome.Image = ((System.Drawing.Image)(resources.GetObject("btnHome.Image")));
            this.btnHome.Location = new System.Drawing.Point(10, 11);
            this.btnHome.Margin = new System.Windows.Forms.Padding(0);
            this.btnHome.Name = "btnHome";
            this.btnHome.Size = new System.Drawing.Size(60, 38);
            this.btnHome.TabIndex = 0;
            this.btnHome.UseVisualStyleBackColor = false;
            this.btnHome.Click += new System.EventHandler(this.home_page_click);
            // 
            // dataGridViewJucarii
            // 
            this.dataGridViewJucarii.AllowUserToAddRows = false;
            this.dataGridViewJucarii.AllowUserToDeleteRows = false;
            this.dataGridViewJucarii.AutoGenerateColumns = false;
            this.dataGridViewJucarii.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dataGridViewJucarii.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridViewJucarii.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dataGridViewJucarii.ColumnHeadersHeight = 35;
            this.dataGridViewJucarii.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.produseIdDataGridViewTextBoxColumn,
            this.produseDenumireDataGridViewTextBoxColumn,
            this.produseVarstaDataGridViewTextBoxColumn,
            this.branduriDenumireDataGridViewTextBoxColumn,
            this.Produse_Sex,
            this.produsePretDataGridViewTextBoxColumn,
            this.produseCantitateDataGridViewTextBoxColumn,
            this.produseTaraDataGridViewTextBoxColumn,
            this.categoriiDenumireDataGridViewTextBoxColumn});
            this.dataGridViewJucarii.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dataGridViewJucarii.DataSource = this.afisareProduseBindingSource;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Roboto Slab", 10F);
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.Gainsboro;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewJucarii.DefaultCellStyle = dataGridViewCellStyle5;
            this.dataGridViewJucarii.GridColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dataGridViewJucarii.Location = new System.Drawing.Point(243, 141);
            this.dataGridViewJucarii.MultiSelect = false;
            this.dataGridViewJucarii.Name = "dataGridViewJucarii";
            this.dataGridViewJucarii.ReadOnly = true;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Roboto Slab", 10F);
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.Gainsboro;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewJucarii.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.dataGridViewJucarii.RowHeadersWidth = 82;
            this.dataGridViewJucarii.Size = new System.Drawing.Size(1162, 725);
            this.dataGridViewJucarii.TabIndex = 1;
            this.dataGridViewJucarii.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // produseIdDataGridViewTextBoxColumn
            // 
            this.produseIdDataGridViewTextBoxColumn.DataPropertyName = "Produse_Id";
            this.produseIdDataGridViewTextBoxColumn.FillWeight = 40F;
            this.produseIdDataGridViewTextBoxColumn.HeaderText = "ID";
            this.produseIdDataGridViewTextBoxColumn.MinimumWidth = 10;
            this.produseIdDataGridViewTextBoxColumn.Name = "produseIdDataGridViewTextBoxColumn";
            this.produseIdDataGridViewTextBoxColumn.ReadOnly = true;
            this.produseIdDataGridViewTextBoxColumn.Width = 40;
            // 
            // produseDenumireDataGridViewTextBoxColumn
            // 
            this.produseDenumireDataGridViewTextBoxColumn.DataPropertyName = "Produse_Denumire";
            this.produseDenumireDataGridViewTextBoxColumn.FillWeight = 350F;
            this.produseDenumireDataGridViewTextBoxColumn.HeaderText = "Denumire";
            this.produseDenumireDataGridViewTextBoxColumn.MinimumWidth = 10;
            this.produseDenumireDataGridViewTextBoxColumn.Name = "produseDenumireDataGridViewTextBoxColumn";
            this.produseDenumireDataGridViewTextBoxColumn.ReadOnly = true;
            this.produseDenumireDataGridViewTextBoxColumn.Width = 350;
            // 
            // produseVarstaDataGridViewTextBoxColumn
            // 
            this.produseVarstaDataGridViewTextBoxColumn.DataPropertyName = "Produse_Varsta";
            this.produseVarstaDataGridViewTextBoxColumn.FillWeight = 40F;
            this.produseVarstaDataGridViewTextBoxColumn.HeaderText = "Varsta";
            this.produseVarstaDataGridViewTextBoxColumn.MinimumWidth = 10;
            this.produseVarstaDataGridViewTextBoxColumn.Name = "produseVarstaDataGridViewTextBoxColumn";
            this.produseVarstaDataGridViewTextBoxColumn.ReadOnly = true;
            this.produseVarstaDataGridViewTextBoxColumn.Width = 40;
            // 
            // branduriDenumireDataGridViewTextBoxColumn
            // 
            this.branduriDenumireDataGridViewTextBoxColumn.DataPropertyName = "Brand_uri_Denumire";
            this.branduriDenumireDataGridViewTextBoxColumn.FillWeight = 120F;
            this.branduriDenumireDataGridViewTextBoxColumn.HeaderText = "Brand";
            this.branduriDenumireDataGridViewTextBoxColumn.MinimumWidth = 10;
            this.branduriDenumireDataGridViewTextBoxColumn.Name = "branduriDenumireDataGridViewTextBoxColumn";
            this.branduriDenumireDataGridViewTextBoxColumn.ReadOnly = true;
            this.branduriDenumireDataGridViewTextBoxColumn.Width = 120;
            // 
            // Produse_Sex
            // 
            this.Produse_Sex.DataPropertyName = "Produse_Sex";
            this.Produse_Sex.FillWeight = 70F;
            this.Produse_Sex.HeaderText = "Sex";
            this.Produse_Sex.MinimumWidth = 10;
            this.Produse_Sex.Name = "Produse_Sex";
            this.Produse_Sex.ReadOnly = true;
            this.Produse_Sex.Width = 70;
            // 
            // produsePretDataGridViewTextBoxColumn
            // 
            this.produsePretDataGridViewTextBoxColumn.DataPropertyName = "Produse_Pret";
            this.produsePretDataGridViewTextBoxColumn.FillWeight = 70F;
            this.produsePretDataGridViewTextBoxColumn.HeaderText = "Pret";
            this.produsePretDataGridViewTextBoxColumn.MinimumWidth = 10;
            this.produsePretDataGridViewTextBoxColumn.Name = "produsePretDataGridViewTextBoxColumn";
            this.produsePretDataGridViewTextBoxColumn.ReadOnly = true;
            this.produsePretDataGridViewTextBoxColumn.Width = 70;
            // 
            // produseCantitateDataGridViewTextBoxColumn
            // 
            this.produseCantitateDataGridViewTextBoxColumn.DataPropertyName = "Produse_Cantitate";
            this.produseCantitateDataGridViewTextBoxColumn.FillWeight = 60F;
            this.produseCantitateDataGridViewTextBoxColumn.HeaderText = "Cantitate";
            this.produseCantitateDataGridViewTextBoxColumn.MinimumWidth = 10;
            this.produseCantitateDataGridViewTextBoxColumn.Name = "produseCantitateDataGridViewTextBoxColumn";
            this.produseCantitateDataGridViewTextBoxColumn.ReadOnly = true;
            this.produseCantitateDataGridViewTextBoxColumn.Width = 60;
            // 
            // produseTaraDataGridViewTextBoxColumn
            // 
            this.produseTaraDataGridViewTextBoxColumn.DataPropertyName = "Produse_Tara";
            this.produseTaraDataGridViewTextBoxColumn.FillWeight = 140F;
            this.produseTaraDataGridViewTextBoxColumn.HeaderText = "Tara";
            this.produseTaraDataGridViewTextBoxColumn.MinimumWidth = 10;
            this.produseTaraDataGridViewTextBoxColumn.Name = "produseTaraDataGridViewTextBoxColumn";
            this.produseTaraDataGridViewTextBoxColumn.ReadOnly = true;
            this.produseTaraDataGridViewTextBoxColumn.Width = 140;
            // 
            // categoriiDenumireDataGridViewTextBoxColumn
            // 
            this.categoriiDenumireDataGridViewTextBoxColumn.DataPropertyName = "Categorii_Denumire";
            this.categoriiDenumireDataGridViewTextBoxColumn.FillWeight = 160F;
            this.categoriiDenumireDataGridViewTextBoxColumn.HeaderText = "Categorii";
            this.categoriiDenumireDataGridViewTextBoxColumn.MinimumWidth = 10;
            this.categoriiDenumireDataGridViewTextBoxColumn.Name = "categoriiDenumireDataGridViewTextBoxColumn";
            this.categoriiDenumireDataGridViewTextBoxColumn.ReadOnly = true;
            this.categoriiDenumireDataGridViewTextBoxColumn.Width = 160;
            // 
            // afisareProduseBindingSource
            // 
            this.afisareProduseBindingSource.DataMember = "Afisare_Produse";
            this.afisareProduseBindingSource.DataSource = this.lumea_CopiilorDataSet;
            // 
            // lumea_CopiilorDataSet
            // 
            this.lumea_CopiilorDataSet.DataSetName = "Lumea_CopiilorDataSet";
            this.lumea_CopiilorDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // afisare_ProduseTableAdapter
            // 
            this.afisare_ProduseTableAdapter.ClearBeforeFill = true;
            // 
            // groupBoxSortare
            // 
            this.groupBoxSortare.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.groupBoxSortare.Controls.Add(this.button5);
            this.groupBoxSortare.Controls.Add(this.button4);
            this.groupBoxSortare.Controls.Add(this.button3);
            this.groupBoxSortare.Controls.Add(this.button2);
            this.groupBoxSortare.Controls.Add(this.button1);
            this.groupBoxSortare.Controls.Add(this.btn3);
            this.groupBoxSortare.Font = new System.Drawing.Font("Roboto Slab", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.groupBoxSortare.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(62)))), ((int)(((byte)(90)))));
            this.groupBoxSortare.Location = new System.Drawing.Point(29, 141);
            this.groupBoxSortare.Name = "groupBoxSortare";
            this.groupBoxSortare.Size = new System.Drawing.Size(196, 725);
            this.groupBoxSortare.TabIndex = 2;
            this.groupBoxSortare.TabStop = false;
            this.groupBoxSortare.Text = "Sortare";
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.WhiteSmoke;
            this.button4.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(62)))), ((int)(((byte)(90)))));
            this.button4.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gainsboro;
            this.button4.FlatAppearance.MouseOverBackColor = System.Drawing.Color.WhiteSmoke;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.Font = new System.Drawing.Font("Roboto Slab ExtraBold", 12F, System.Drawing.FontStyle.Bold);
            this.button4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(60)))), ((int)(((byte)(90)))));
            this.button4.Image = ((System.Drawing.Image)(resources.GetObject("button4.Image")));
            this.button4.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button4.Location = new System.Drawing.Point(20, 397);
            this.button4.Margin = new System.Windows.Forms.Padding(0);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(156, 38);
            this.button4.TabIndex = 4;
            this.button4.Text = "Sortare";
            this.button4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.btn4_click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.WhiteSmoke;
            this.button3.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(62)))), ((int)(((byte)(90)))));
            this.button3.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gainsboro;
            this.button3.FlatAppearance.MouseOverBackColor = System.Drawing.Color.WhiteSmoke;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Roboto Slab ExtraBold", 12F, System.Drawing.FontStyle.Bold);
            this.button3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(60)))), ((int)(((byte)(90)))));
            this.button3.Image = ((System.Drawing.Image)(resources.GetObject("button3.Image")));
            this.button3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button3.Location = new System.Drawing.Point(20, 329);
            this.button3.Margin = new System.Windows.Forms.Padding(0);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(156, 38);
            this.button3.TabIndex = 4;
            this.button3.Text = "Moldova";
            this.button3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.md_click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.WhiteSmoke;
            this.button2.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(62)))), ((int)(((byte)(90)))));
            this.button2.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gainsboro;
            this.button2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.WhiteSmoke;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Roboto Slab ExtraBold", 12F, System.Drawing.FontStyle.Bold);
            this.button2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(60)))), ((int)(((byte)(90)))));
            this.button2.Image = ((System.Drawing.Image)(resources.GetObject("button2.Image")));
            this.button2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button2.Location = new System.Drawing.Point(20, 261);
            this.button2.Margin = new System.Windows.Forms.Padding(0);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(156, 38);
            this.button2.TabIndex = 4;
            this.button2.Text = "Țări";
            this.button2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.tari_click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.button1.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(62)))), ((int)(((byte)(90)))));
            this.button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gainsboro;
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.WhiteSmoke;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Roboto Slab ExtraBold", 12F, System.Drawing.FontStyle.Bold);
            this.button1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(60)))), ((int)(((byte)(90)))));
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(20, 193);
            this.button1.Margin = new System.Windows.Forms.Padding(0);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(156, 38);
            this.button1.TabIndex = 4;
            this.button1.Text = "Păpuși";
            this.button1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.barbie_click);
            // 
            // btn3
            // 
            this.btn3.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btn3.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(62)))), ((int)(((byte)(90)))));
            this.btn3.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gainsboro;
            this.btn3.FlatAppearance.MouseOverBackColor = System.Drawing.Color.WhiteSmoke;
            this.btn3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn3.Font = new System.Drawing.Font("Roboto Slab ExtraBold", 12F, System.Drawing.FontStyle.Bold);
            this.btn3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(60)))), ((int)(((byte)(90)))));
            this.btn3.Image = ((System.Drawing.Image)(resources.GetObject("btn3.Image")));
            this.btn3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn3.Location = new System.Drawing.Point(20, 125);
            this.btn3.Margin = new System.Windows.Forms.Padding(0);
            this.btn3.Name = "btn3";
            this.btn3.Size = new System.Drawing.Size(156, 38);
            this.btn3.TabIndex = 4;
            this.btn3.Text = "Max & Min";
            this.btn3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn3.UseVisualStyleBackColor = false;
            this.btn3.Click += new System.EventHandler(this.btn3_Click);
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.Color.WhiteSmoke;
            this.button5.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(62)))), ((int)(((byte)(90)))));
            this.button5.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gainsboro;
            this.button5.FlatAppearance.MouseOverBackColor = System.Drawing.Color.WhiteSmoke;
            this.button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button5.Font = new System.Drawing.Font("Roboto Slab ExtraBold", 12F, System.Drawing.FontStyle.Bold);
            this.button5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(60)))), ((int)(((byte)(90)))));
            this.button5.Image = ((System.Drawing.Image)(resources.GetObject("button5.Image")));
            this.button5.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button5.Location = new System.Drawing.Point(20, 463);
            this.button5.Margin = new System.Windows.Forms.Padding(0);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(156, 38);
            this.button5.TabIndex = 4;
            this.button5.Text = "Top Produse";
            this.button5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button5.UseVisualStyleBackColor = false;
            this.button5.Click += new System.EventHandler(this.btn5_click);
            // 
            // FrmProduse
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(1440, 900);
            this.Controls.Add(this.groupBoxSortare);
            this.Controls.Add(this.dataGridViewJucarii);
            this.Controls.Add(this.groupBoxMenu);
            this.Name = "FrmProduse";
            this.Text = "Jucarii";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FrmProduse_Load);
            this.groupBoxMenu.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewJucarii)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.afisareProduseBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lumea_CopiilorDataSet)).EndInit();
            this.groupBoxSortare.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxMenu;
        private Lumea_CopiilorDataSet lumea_CopiilorDataSet;
        private System.Windows.Forms.BindingSource afisareProduseBindingSource;
        private Lumea_CopiilorDataSetTableAdapters.Afisare_ProduseTableAdapter afisare_ProduseTableAdapter;
        private System.Windows.Forms.Button btnHome;
        private System.Windows.Forms.DataGridViewTextBoxColumn produseSexDataGridViewTextBoxColumn;
        private System.Windows.Forms.GroupBox groupBoxSortare;
        private System.Windows.Forms.DataGridViewTextBoxColumn produseIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn produseDenumireDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn produseVarstaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn branduriDenumireDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn Produse_Sex;
        private System.Windows.Forms.DataGridViewTextBoxColumn produsePretDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn produseCantitateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn produseTaraDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn categoriiDenumireDataGridViewTextBoxColumn;
        public System.Windows.Forms.Button btnADD;
        public System.Windows.Forms.Button btnModify;
        public System.Windows.Forms.Button btnDelete;
        public System.Windows.Forms.Button btnCart;
        public System.Windows.Forms.DataGridView dataGridViewJucarii;
        public System.Windows.Forms.Button btnStock;
        public System.Windows.Forms.Button btn3;
        public System.Windows.Forms.Button button1;
        public System.Windows.Forms.Button button2;
        public System.Windows.Forms.Button button3;
        public System.Windows.Forms.Button button4;
        public System.Windows.Forms.Button button5;
    }
}