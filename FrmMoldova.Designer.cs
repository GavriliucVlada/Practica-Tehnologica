namespace PracticaTehnologica
{
    partial class FrmMoldova
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMoldova));
            this.afisareJucariimdBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.jucariiMd = new PracticaTehnologica.JucariiMd();
            this.panel1 = new System.Windows.Forms.Panel();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.btnJucarenia = new System.Windows.Forms.Button();
            this.afisare_Jucarii_mdTableAdapter = new PracticaTehnologica.JucariiMdTableAdapters.Afisare_Jucarii_mdTableAdapter();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.afisareJucariimdBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.jucariiMd)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // afisareJucariimdBindingSource
            // 
            this.afisareJucariimdBindingSource.DataMember = "Afisare_Jucarii_md";
            this.afisareJucariimdBindingSource.DataSource = this.jucariiMd;
            // 
            // jucariiMd
            // 
            this.jucariiMd.DataSetName = "JucariiMd";
            this.jucariiMd.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
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
            // reportViewer1
            // 
            this.reportViewer1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(101)))), ((int)(((byte)(39)))));
            reportDataSource1.Name = "JucariiMd_dataSet";
            reportDataSource1.Value = this.afisareJucariimdBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "PracticaTehnologica.RepMd_REPORT.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(124, 346);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(1192, 480);
            this.reportViewer1.TabIndex = 9;
            this.reportViewer1.Load += new System.EventHandler(this.reportViewer1_Load);
            // 
            // btnJucarenia
            // 
            this.btnJucarenia.BackColor = System.Drawing.Color.Transparent;
            this.btnJucarenia.FlatAppearance.BorderSize = 0;
            this.btnJucarenia.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.btnJucarenia.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.btnJucarenia.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnJucarenia.Image = ((System.Drawing.Image)(resources.GetObject("btnJucarenia.Image")));
            this.btnJucarenia.Location = new System.Drawing.Point(24, 27);
            this.btnJucarenia.Margin = new System.Windows.Forms.Padding(2);
            this.btnJucarenia.Name = "btnJucarenia";
            this.btnJucarenia.Size = new System.Drawing.Size(211, 60);
            this.btnJucarenia.TabIndex = 8;
            this.btnJucarenia.UseVisualStyleBackColor = false;
            this.btnJucarenia.Click += new System.EventHandler(this.btnJucarenia_Click);
            // 
            // afisare_Jucarii_mdTableAdapter
            // 
            this.afisare_Jucarii_mdTableAdapter.ClearBeforeFill = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Roboto Slab", 30F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(101)))), ((int)(((byte)(39)))));
            this.label1.Location = new System.Drawing.Point(421, 163);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(599, 106);
            this.label1.TabIndex = 16;
            this.label1.Text = "Toate jucăriile ce au fost\r\nproduse în Republica Moldova\r\n";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // FrmMoldova
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1440, 900);
            this.Controls.Add(this.panel1);
            this.Name = "FrmMoldova";
            this.Text = "FrmMoldova";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FrmMoldova_Load);
            ((System.ComponentModel.ISupportInitialize)(this.afisareJucariimdBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.jucariiMd)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnJucarenia;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private JucariiMd jucariiMd;
        private System.Windows.Forms.BindingSource afisareJucariimdBindingSource;
        private JucariiMdTableAdapters.Afisare_Jucarii_mdTableAdapter afisare_Jucarii_mdTableAdapter;
        private System.Windows.Forms.Label label1;
    }
}