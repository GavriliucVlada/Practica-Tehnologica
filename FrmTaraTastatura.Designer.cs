namespace PracticaTehnologica
{
    partial class FrmTaraTastatura
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmTaraTastatura));
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource4 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnJucarenia = new System.Windows.Forms.Button();
            this.textBoxTara = new System.Windows.Forms.TextBox();
            this.labelRezultat = new System.Windows.Forms.Label();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.tari = new PracticaTehnologica.Tari();
            this.getTariDisponibileBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.getTariDisponibileTableAdapter = new PracticaTehnologica.TariTableAdapters.GetTariDisponibileTableAdapter();
            this.button1 = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tari)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.getTariDisponibileBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.reportViewer1);
            this.panel1.Controls.Add(this.labelRezultat);
            this.panel1.Controls.Add(this.textBoxTara);
            this.panel1.Controls.Add(this.btnJucarenia);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(600, 400);
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
            this.btnJucarenia.Location = new System.Drawing.Point(32, 28);
            this.btnJucarenia.Margin = new System.Windows.Forms.Padding(2);
            this.btnJucarenia.Name = "btnJucarenia";
            this.btnJucarenia.Size = new System.Drawing.Size(211, 60);
            this.btnJucarenia.TabIndex = 8;
            this.btnJucarenia.UseVisualStyleBackColor = false;
            this.btnJucarenia.Click += new System.EventHandler(this.btnJucarenia_Click);
            // 
            // textBoxTara
            // 
            this.textBoxTara.Font = new System.Drawing.Font("Roboto Slab Medium", 14F, System.Drawing.FontStyle.Bold);
            this.textBoxTara.Location = new System.Drawing.Point(43, 130);
            this.textBoxTara.Name = "textBoxTara";
            this.textBoxTara.Size = new System.Drawing.Size(205, 32);
            this.textBoxTara.TabIndex = 9;
            // 
            // labelRezultat
            // 
            this.labelRezultat.AutoSize = true;
            this.labelRezultat.Font = new System.Drawing.Font("Roboto Slab Medium", 14F, System.Drawing.FontStyle.Bold);
            this.labelRezultat.ForeColor = System.Drawing.Color.Tomato;
            this.labelRezultat.Location = new System.Drawing.Point(32, 334);
            this.labelRezultat.Name = "labelRezultat";
            this.labelRezultat.Size = new System.Drawing.Size(194, 26);
            this.labelRezultat.TabIndex = 10;
            this.labelRezultat.Text = "Prețul mediu pentru";
            // 
            // reportViewer1
            // 
            reportDataSource4.Name = "DataSetTari";
            reportDataSource4.Value = this.getTariDisponibileBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource4);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "PracticaTehnologica.Tari_REPORT.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(289, 78);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(239, 243);
            this.reportViewer1.TabIndex = 11;
            // 
            // tari
            // 
            this.tari.DataSetName = "Tari";
            this.tari.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // getTariDisponibileBindingSource
            // 
            this.getTariDisponibileBindingSource.DataMember = "GetTariDisponibile";
            this.getTariDisponibileBindingSource.DataSource = this.tari;
            // 
            // getTariDisponibileTableAdapter
            // 
            this.getTariDisponibileTableAdapter.ClearBeforeFill = true;
            // 
            // button1
            // 
            this.button1.FlatAppearance.BorderColor = System.Drawing.SystemColors.ControlLight;
            this.button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ButtonFace;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold);
            this.button1.ForeColor = System.Drawing.Color.Tomato;
            this.button1.Location = new System.Drawing.Point(68, 191);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(146, 36);
            this.button1.TabIndex = 12;
            this.button1.Text = "Calculează!";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.buttonCalculeaza_Click);
            // 
            // FrmTaraTastatura
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 400);
            this.Controls.Add(this.panel1);
            this.Name = "FrmTaraTastatura";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.FrmTaraTastatura_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tari)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.getTariDisponibileBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnJucarenia;
        private System.Windows.Forms.TextBox textBoxTara;
        private System.Windows.Forms.Label labelRezultat;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private Tari tari;
        private System.Windows.Forms.BindingSource getTariDisponibileBindingSource;
        private TariTableAdapters.GetTariDisponibileTableAdapter getTariDisponibileTableAdapter;
        private System.Windows.Forms.Button button1;
    }
}