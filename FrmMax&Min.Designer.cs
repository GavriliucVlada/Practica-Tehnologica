namespace PracticaTehnologica
{
    partial class FrmMax_Min
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
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource2 = new Microsoft.Reporting.WinForms.ReportDataSource();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMax_Min));
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnJucarenia = new System.Windows.Forms.Button();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.vedere_jucarie_MinMaxPret_Data_Set = new PracticaTehnologica.Vedere_jucarie_MinMaxPret_Data_Set();
            this.vederejucarieMinMaxPretDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.vedereJucarieMinMaxPretBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.vedere_Jucarie_MinMaxPretTableAdapter = new PracticaTehnologica.Vedere_jucarie_MinMaxPret_Data_SetTableAdapters.Vedere_Jucarie_MinMaxPretTableAdapter();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureCalut = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.vedere_jucarie_MinMaxPret_Data_Set)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vederejucarieMinMaxPretDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vedereJucarieMinMaxPretBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureCalut)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.pictureBox3);
            this.panel1.Controls.Add(this.pictureBox2);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.pictureCalut);
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
            this.btnJucarenia.Location = new System.Drawing.Point(28, 21);
            this.btnJucarenia.Margin = new System.Windows.Forms.Padding(2);
            this.btnJucarenia.Name = "btnJucarenia";
            this.btnJucarenia.Size = new System.Drawing.Size(211, 60);
            this.btnJucarenia.TabIndex = 12;
            this.btnJucarenia.UseVisualStyleBackColor = false;
            this.btnJucarenia.Click += new System.EventHandler(this.btnJucarenia_Click);
            // 
            // reportViewer1
            // 
            reportDataSource2.Name = "DataSet_MinAndMax";
            reportDataSource2.Value = this.vedereJucarieMinMaxPretBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource2);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "PracticaTehnologica.MaxAndMin_REPORT.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(142, 385);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(1157, 151);
            this.reportViewer1.TabIndex = 13;
            // 
            // vedere_jucarie_MinMaxPret_Data_Set
            // 
            this.vedere_jucarie_MinMaxPret_Data_Set.DataSetName = "Vedere_jucarie_MinMaxPret_Data_Set";
            this.vedere_jucarie_MinMaxPret_Data_Set.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // vederejucarieMinMaxPretDataSetBindingSource
            // 
            this.vederejucarieMinMaxPretDataSetBindingSource.DataSource = this.vedere_jucarie_MinMaxPret_Data_Set;
            this.vederejucarieMinMaxPretDataSetBindingSource.Position = 0;
            // 
            // vedereJucarieMinMaxPretBindingSource
            // 
            this.vedereJucarieMinMaxPretBindingSource.DataMember = "Vedere_Jucarie_MinMaxPret";
            this.vedereJucarieMinMaxPretBindingSource.DataSource = this.vederejucarieMinMaxPretDataSetBindingSource;
            // 
            // vedere_Jucarie_MinMaxPretTableAdapter
            // 
            this.vedere_Jucarie_MinMaxPretTableAdapter.ClearBeforeFill = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Roboto Slab", 30F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(416, 197);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(609, 106);
            this.label1.TabIndex = 14;
            this.label1.Text = "Atributele celei mai scumpe şi \r\na celei mai ieftine jucării\r\n";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pictureCalut
            // 
            this.pictureCalut.Image = ((System.Drawing.Image)(resources.GetObject("pictureCalut.Image")));
            this.pictureCalut.Location = new System.Drawing.Point(1124, 597);
            this.pictureCalut.Name = "pictureCalut";
            this.pictureCalut.Size = new System.Drawing.Size(200, 222);
            this.pictureCalut.TabIndex = 15;
            this.pictureCalut.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(61, 612);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(300, 267);
            this.pictureBox1.TabIndex = 16;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(1009, 84);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(184, 250);
            this.pictureBox2.TabIndex = 17;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(966, 699);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(152, 150);
            this.pictureBox3.TabIndex = 18;
            this.pictureBox3.TabStop = false;
            // 
            // FrmMax_Min
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1440, 900);
            this.Controls.Add(this.panel1);
            this.Name = "FrmMax_Min";
            this.Text = "FrmMax_Min";
            this.Load += new System.EventHandler(this.FrmMax_Min_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.vedere_jucarie_MinMaxPret_Data_Set)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vederejucarieMinMaxPretDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vedereJucarieMinMaxPretBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureCalut)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnJucarenia;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private Vedere_jucarie_MinMaxPret_Data_Set vedere_jucarie_MinMaxPret_Data_Set;
        private System.Windows.Forms.BindingSource vederejucarieMinMaxPretDataSetBindingSource;
        private System.Windows.Forms.BindingSource vedereJucarieMinMaxPretBindingSource;
        private Vedere_jucarie_MinMaxPret_Data_SetTableAdapters.Vedere_Jucarie_MinMaxPretTableAdapter vedere_Jucarie_MinMaxPretTableAdapter;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureCalut;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
    }
}