namespace PracticaTehnologica
{
    partial class FrmOutOfStock
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmOutOfStock));
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.afisareOutOfStockBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.lumeaCopiilorAfisareOutOfStockBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.lumea_CopiilorAfisare_OutOfStock = new PracticaTehnologica.Lumea_CopiilorAfisare_OutOfStock();
            this.panelOutOfStock = new System.Windows.Forms.Panel();
            this.btnJucarenia = new System.Windows.Forms.Button();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.Afisare_OutOfStockBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.afisare_OutOfStockTableAdapter = new PracticaTehnologica.Lumea_CopiilorAfisare_OutOfStockTableAdapters.Afisare_OutOfStockTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.afisareOutOfStockBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lumeaCopiilorAfisareOutOfStockBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lumea_CopiilorAfisare_OutOfStock)).BeginInit();
            this.panelOutOfStock.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Afisare_OutOfStockBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // afisareOutOfStockBindingSource
            // 
            this.afisareOutOfStockBindingSource.DataMember = "Afisare_OutOfStock";
            this.afisareOutOfStockBindingSource.DataSource = this.lumeaCopiilorAfisareOutOfStockBindingSource;
            // 
            // lumeaCopiilorAfisareOutOfStockBindingSource
            // 
            this.lumeaCopiilorAfisareOutOfStockBindingSource.DataSource = this.lumea_CopiilorAfisare_OutOfStock;
            this.lumeaCopiilorAfisareOutOfStockBindingSource.Position = 0;
            // 
            // lumea_CopiilorAfisare_OutOfStock
            // 
            this.lumea_CopiilorAfisare_OutOfStock.DataSetName = "Lumea_CopiilorAfisare_OutOfStock";
            this.lumea_CopiilorAfisare_OutOfStock.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // panelOutOfStock
            // 
            this.panelOutOfStock.BackColor = System.Drawing.Color.White;
            this.panelOutOfStock.Controls.Add(this.btnJucarenia);
            this.panelOutOfStock.Controls.Add(this.reportViewer1);
            this.panelOutOfStock.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelOutOfStock.Location = new System.Drawing.Point(0, 0);
            this.panelOutOfStock.Name = "panelOutOfStock";
            this.panelOutOfStock.Size = new System.Drawing.Size(1440, 900);
            this.panelOutOfStock.TabIndex = 0;
            // 
            // btnJucarenia
            // 
            this.btnJucarenia.BackColor = System.Drawing.Color.Transparent;
            this.btnJucarenia.FlatAppearance.BorderSize = 0;
            this.btnJucarenia.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.btnJucarenia.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.btnJucarenia.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnJucarenia.Image = ((System.Drawing.Image)(resources.GetObject("btnJucarenia.Image")));
            this.btnJucarenia.Location = new System.Drawing.Point(35, 31);
            this.btnJucarenia.Margin = new System.Windows.Forms.Padding(2);
            this.btnJucarenia.Name = "btnJucarenia";
            this.btnJucarenia.Size = new System.Drawing.Size(211, 60);
            this.btnJucarenia.TabIndex = 8;
            this.btnJucarenia.UseVisualStyleBackColor = false;
            this.btnJucarenia.Click += new System.EventHandler(this.btnJucarenia_Click_1);
            // 
            // reportViewer1
            // 
            reportDataSource1.Name = "DataSetOutOfStock";
            reportDataSource1.Value = this.afisareOutOfStockBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "PracticaTehnologica.OutOfStock_REPORT.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(118, 166);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(1204, 568);
            this.reportViewer1.TabIndex = 0;
            // 
            // Afisare_OutOfStockBindingSource
            // 
            this.Afisare_OutOfStockBindingSource.DataMember = "Afisare_OutOfStock";
            this.Afisare_OutOfStockBindingSource.DataSource = this.lumea_CopiilorAfisare_OutOfStock;
            // 
            // afisare_OutOfStockTableAdapter
            // 
            this.afisare_OutOfStockTableAdapter.ClearBeforeFill = true;
            // 
            // FrmOutOfStock
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1440, 900);
            this.Controls.Add(this.panelOutOfStock);
            this.Name = "FrmOutOfStock";
            this.Text = "Out Of Stock";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FrmOutOfStock_Load_1);
            ((System.ComponentModel.ISupportInitialize)(this.afisareOutOfStockBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lumeaCopiilorAfisareOutOfStockBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lumea_CopiilorAfisare_OutOfStock)).EndInit();
            this.panelOutOfStock.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Afisare_OutOfStockBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelOutOfStock;
        private Lumea_CopiilorAfisare_OutOfStock lumea_CopiilorAfisare_OutOfStock;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource Afisare_OutOfStockBindingSource;
        private System.Windows.Forms.BindingSource lumeaCopiilorAfisareOutOfStockBindingSource;
        private System.Windows.Forms.BindingSource afisareOutOfStockBindingSource;
        private Lumea_CopiilorAfisare_OutOfStockTableAdapters.Afisare_OutOfStockTableAdapter afisare_OutOfStockTableAdapter;
        private System.Windows.Forms.Button btnJucarenia;
    }
}