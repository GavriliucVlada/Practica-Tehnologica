namespace PracticaTehnologica
{
    partial class FrmHistory
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
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmHistory));
            this.afisareCumparatBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.afisareHistoryDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.afisare_History_DataSet = new PracticaTehnologica.Afisare_History_DataSet();
            this.panel1 = new System.Windows.Forms.Panel();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.btnJucarenia = new System.Windows.Forms.Button();
            this.afisare_CumparatTableAdapter = new PracticaTehnologica.Afisare_History_DataSetTableAdapters.Afisare_CumparatTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.afisareCumparatBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.afisareHistoryDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.afisare_History_DataSet)).BeginInit();
            this.panel1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // afisareCumparatBindingSource
            // 
            this.afisareCumparatBindingSource.DataMember = "Afisare_Cumparat";
            this.afisareCumparatBindingSource.DataSource = this.afisareHistoryDataSetBindingSource;
            // 
            // afisareHistoryDataSetBindingSource
            // 
            this.afisareHistoryDataSetBindingSource.DataSource = this.afisare_History_DataSet;
            this.afisareHistoryDataSetBindingSource.Position = 0;
            // 
            // afisare_History_DataSet
            // 
            this.afisare_History_DataSet.DataSetName = "Afisare_History_DataSet";
            this.afisare_History_DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.groupBox2);
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Controls.Add(this.btnJucarenia);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1440, 900);
            this.panel1.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.reportViewer1);
            this.groupBox2.Location = new System.Drawing.Point(74, 195);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(879, 511);
            this.groupBox2.TabIndex = 14;
            this.groupBox2.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Roboto Slab ExtraBold", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(101)))), ((int)(((byte)(39)))));
            this.label2.Location = new System.Drawing.Point(52, 47);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(289, 44);
            this.label2.TabIndex = 13;
            this.label2.Text = "Istoria Vânzărilor";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // reportViewer1
            // 
            reportDataSource1.Name = "DataSetHistory";
            reportDataSource1.Value = this.afisareCumparatBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "PracticaTehnologica.History_REPORT.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(54, 118);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(770, 345);
            this.reportViewer1.TabIndex = 9;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.dateTimePicker1);
            this.groupBox1.Font = new System.Drawing.Font("Roboto Slab Medium", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.groupBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(101)))), ((int)(((byte)(39)))));
            this.groupBox1.Location = new System.Drawing.Point(1005, 288);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(362, 325);
            this.groupBox1.TabIndex = 12;
            this.groupBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Roboto Slab ExtraBold", 18F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(5, 60);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(352, 64);
            this.label1.TabIndex = 12;
            this.label1.Text = "Numărul produselor vândute\r\ntimp de o zi";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Roboto Slab", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button1.Location = new System.Drawing.Point(103, 223);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(141, 42);
            this.button1.TabIndex = 11;
            this.button1.Text = "Calculează!";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.CustomFormat = "yyyy-MM-dd";
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker1.Location = new System.Drawing.Point(79, 157);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(205, 29);
            this.dateTimePicker1.TabIndex = 10;
            // 
            // btnJucarenia
            // 
            this.btnJucarenia.BackColor = System.Drawing.Color.Transparent;
            this.btnJucarenia.FlatAppearance.BorderSize = 0;
            this.btnJucarenia.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.btnJucarenia.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.btnJucarenia.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnJucarenia.Image = ((System.Drawing.Image)(resources.GetObject("btnJucarenia.Image")));
            this.btnJucarenia.Location = new System.Drawing.Point(43, 37);
            this.btnJucarenia.Margin = new System.Windows.Forms.Padding(2);
            this.btnJucarenia.Name = "btnJucarenia";
            this.btnJucarenia.Size = new System.Drawing.Size(211, 60);
            this.btnJucarenia.TabIndex = 8;
            this.btnJucarenia.UseVisualStyleBackColor = false;
            this.btnJucarenia.Click += new System.EventHandler(this.btnJucarenia_Click);
            // 
            // afisare_CumparatTableAdapter
            // 
            this.afisare_CumparatTableAdapter.ClearBeforeFill = true;
            // 
            // FrmHistory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1440, 900);
            this.Controls.Add(this.panel1);
            this.Name = "FrmHistory";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FrmHistory_Load);
            ((System.ComponentModel.ISupportInitialize)(this.afisareCumparatBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.afisareHistoryDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.afisare_History_DataSet)).EndInit();
            this.panel1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnJucarenia;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private Afisare_History_DataSet afisare_History_DataSet;
        private System.Windows.Forms.BindingSource afisareHistoryDataSetBindingSource;
        private System.Windows.Forms.BindingSource afisareCumparatBindingSource;
        private Afisare_History_DataSetTableAdapters.Afisare_CumparatTableAdapter afisare_CumparatTableAdapter;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label2;
    }
}