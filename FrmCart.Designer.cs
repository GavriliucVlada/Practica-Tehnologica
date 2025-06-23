namespace PracticaTehnologica
{
    partial class FrmCart
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmCart));
            this.panelCart = new System.Windows.Forms.Panel();
            this.btnJucarenia = new System.Windows.Forms.Button();
            this.panelCart.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelCart
            // 
            this.panelCart.AutoScroll = true;
            this.panelCart.BackColor = System.Drawing.Color.White;
            this.panelCart.Controls.Add(this.btnJucarenia);
            this.panelCart.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelCart.Location = new System.Drawing.Point(0, 0);
            this.panelCart.Name = "panelCart";
            this.panelCart.Size = new System.Drawing.Size(1424, 861);
            this.panelCart.TabIndex = 0;
            // 
            // btnJucarenia
            // 
            this.btnJucarenia.BackColor = System.Drawing.Color.Transparent;
            this.btnJucarenia.FlatAppearance.BorderSize = 0;
            this.btnJucarenia.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.btnJucarenia.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.btnJucarenia.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnJucarenia.Image = ((System.Drawing.Image)(resources.GetObject("btnJucarenia.Image")));
            this.btnJucarenia.Location = new System.Drawing.Point(11, 11);
            this.btnJucarenia.Margin = new System.Windows.Forms.Padding(2);
            this.btnJucarenia.Name = "btnJucarenia";
            this.btnJucarenia.Size = new System.Drawing.Size(211, 60);
            this.btnJucarenia.TabIndex = 7;
            this.btnJucarenia.UseVisualStyleBackColor = false;
            this.btnJucarenia.Click += new System.EventHandler(this.acasa);
            // 
            // FrmCart
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1424, 861);
            this.Controls.Add(this.panelCart);
            this.Name = "FrmCart";
            this.Text = "FrmCart";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.panelCart.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelCart;
        private System.Windows.Forms.Button btnJucarenia;
    }
}