namespace PracticaTehnologica
{
    partial class FrmTopProduse
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmTopProduse));
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnJucarenia = new System.Windows.Forms.Button();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.produsePopulareDataSet = new PracticaTehnologica.ProdusePopulareDataSet();
            this.produsePopulareDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.produsePopulareBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.produse_PopulareTableAdapter = new PracticaTehnologica.ProdusePopulareDataSetTableAdapters.Produse_PopulareTableAdapter();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.produsePopulareDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.produsePopulareDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.produsePopulareBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.reportViewer1);
            this.panel1.Controls.Add(this.btnJucarenia);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1440, 900);
            this.panel1.TabIndex = 0;
            // 
            // btnJucarenia
            // 
            this.btnJucarenia.BackColor = System.Drawing.Color.Transparent;
            this.btnJucarenia.FlatAppearance.BorderSize = 0;
            this.btnJucarenia.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.btnJucarenia.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.btnJucarenia.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnJucarenia.Image = ((System.Drawing.Image)(resources.GetObject("btnJucarenia.Image")));
            this.btnJucarenia.Location = new System.Drawing.Point(27, 39);
            this.btnJucarenia.Margin = new System.Windows.Forms.Padding(2);
            this.btnJucarenia.Name = "btnJucarenia";
            this.btnJucarenia.Size = new System.Drawing.Size(211, 60);
            this.btnJucarenia.TabIndex = 14;
            this.btnJucarenia.UseVisualStyleBackColor = false;
            this.btnJucarenia.Click += new System.EventHandler(this.btnJucarenia_Click);
            // 
            // reportViewer1
            // 
            reportDataSource1.Name = "DataSetProdusePopulare";
            reportDataSource1.Value = this.produsePopulareBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "PracticaTehnologica.TopProduse_REPORT.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(130, 288);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(1180, 491);
            this.reportViewer1.TabIndex = 15;
            // 
            // produsePopulareDataSet
            // 
            this.produsePopulareDataSet.DataSetName = "ProdusePopulareDataSet";
            this.produsePopulareDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // produsePopulareDataSetBindingSource
            // 
            this.produsePopulareDataSetBindingSource.DataSource = this.produsePopulareDataSet;
            this.produsePopulareDataSetBindingSource.Position = 0;
            // 
            // produsePopulareBindingSource
            // 
            this.produsePopulareBindingSource.DataMember = "Produse_Populare";
            this.produsePopulareBindingSource.DataSource = this.produsePopulareDataSetBindingSource;
            // 
            // produse_PopulareTableAdapter
            // 
            this.produse_PopulareTableAdapter.ClearBeforeFill = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Roboto Slab", 30F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(101)))), ((int)(((byte)(39)))));
            this.label1.Location = new System.Drawing.Point(235, 174);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(971, 106);
            this.label1.TabIndex = 17;
            this.label1.Text = "Top cele mai populare produse ordonate crescător\r\n\r\n";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // FrmTopProduse
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1440, 900);
            this.Controls.Add(this.panel1);
            this.Name = "FrmTopProduse";
            this.Text = "FrmTopProduse";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FrmTopProduse_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.produsePopulareDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.produsePopulareDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.produsePopulareBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnJucarenia;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private ProdusePopulareDataSet produsePopulareDataSet;
        private System.Windows.Forms.BindingSource produsePopulareDataSetBindingSource;
        private System.Windows.Forms.BindingSource produsePopulareBindingSource;
        private ProdusePopulareDataSetTableAdapters.Produse_PopulareTableAdapter produse_PopulareTableAdapter;
        private System.Windows.Forms.Label label1;
    }
}