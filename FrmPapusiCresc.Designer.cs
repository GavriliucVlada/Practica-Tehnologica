namespace PracticaTehnologica
{
    partial class FrmPapusiCresc
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmPapusiCresc));
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource3 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnJucarenia = new System.Windows.Forms.Button();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.getPapusiDisponibile = new PracticaTehnologica.GetPapusiDisponibile();
            this.getPapusiDisponibileBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.getPapusiDisponibileBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.getPapusiDisponibileTableAdapter = new PracticaTehnologica.GetPapusiDisponibileTableAdapters.GetPapusiDisponibileTableAdapter();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.getPapusiDisponibile)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.getPapusiDisponibileBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.getPapusiDisponibileBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.reportViewer1);
            this.panel1.Controls.Add(this.btnJucarenia);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.pictureBox2);
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
            this.btnJucarenia.Location = new System.Drawing.Point(33, 43);
            this.btnJucarenia.Margin = new System.Windows.Forms.Padding(2);
            this.btnJucarenia.Name = "btnJucarenia";
            this.btnJucarenia.Size = new System.Drawing.Size(211, 60);
            this.btnJucarenia.TabIndex = 13;
            this.btnJucarenia.UseVisualStyleBackColor = false;
            this.btnJucarenia.Click += new System.EventHandler(this.btnJucarenia_Click);
            // 
            // reportViewer1
            // 
            reportDataSource3.Name = "PapusiCrescatorDisponibile_DataSet";
            reportDataSource3.Value = this.getPapusiDisponibileBindingSource1;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource3);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "PracticaTehnologica.PapusiCresc_REPORT.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(154, 307);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(1111, 423);
            this.reportViewer1.TabIndex = 14;
            // 
            // getPapusiDisponibile
            // 
            this.getPapusiDisponibile.DataSetName = "GetPapusiDisponibile";
            this.getPapusiDisponibile.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // getPapusiDisponibileBindingSource
            // 
            this.getPapusiDisponibileBindingSource.DataSource = this.getPapusiDisponibile;
            this.getPapusiDisponibileBindingSource.Position = 0;
            // 
            // getPapusiDisponibileBindingSource1
            // 
            this.getPapusiDisponibileBindingSource1.DataMember = "GetPapusiDisponibile";
            this.getPapusiDisponibileBindingSource1.DataSource = this.getPapusiDisponibileBindingSource;
            // 
            // getPapusiDisponibileTableAdapter
            // 
            this.getPapusiDisponibileTableAdapter.ClearBeforeFill = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Roboto Slab", 30F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.PaleVioletRed;
            this.label1.Location = new System.Drawing.Point(354, 142);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(741, 106);
            this.label1.TabIndex = 15;
            this.label1.Text = "Toate datele păpuşilor, \r\nordonate crescător conform preţurilor";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(1241, 664);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(168, 204);
            this.pictureBox1.TabIndex = 16;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(74, 127);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(182, 224);
            this.pictureBox2.TabIndex = 18;
            this.pictureBox2.TabStop = false;
            // 
            // FrmPapusiCresc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1440, 900);
            this.Controls.Add(this.panel1);
            this.Name = "FrmPapusiCresc";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FrmPapusiCresc_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.getPapusiDisponibile)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.getPapusiDisponibileBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.getPapusiDisponibileBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnJucarenia;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private GetPapusiDisponibile getPapusiDisponibile;
        private System.Windows.Forms.BindingSource getPapusiDisponibileBindingSource;
        private System.Windows.Forms.BindingSource getPapusiDisponibileBindingSource1;
        private GetPapusiDisponibileTableAdapters.GetPapusiDisponibileTableAdapter getPapusiDisponibileTableAdapter;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}