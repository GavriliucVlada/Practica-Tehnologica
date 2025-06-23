namespace PracticaTehnologica
{
    partial class FrmCantitCart
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnSalveazaCart = new System.Windows.Forms.Button();
            this.numericUpDownCantitateCart = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownCantitateCart)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.btnSalveazaCart);
            this.panel1.Controls.Add(this.numericUpDownCantitateCart);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(300, 200);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // btnSalveazaCart
            // 
            this.btnSalveazaCart.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.btnSalveazaCart.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.btnSalveazaCart.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnSalveazaCart.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSalveazaCart.Font = new System.Drawing.Font("Roboto Slab", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnSalveazaCart.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(101)))), ((int)(((byte)(39)))));
            this.btnSalveazaCart.Location = new System.Drawing.Point(90, 128);
            this.btnSalveazaCart.Name = "btnSalveazaCart";
            this.btnSalveazaCart.Size = new System.Drawing.Size(114, 38);
            this.btnSalveazaCart.TabIndex = 2;
            this.btnSalveazaCart.Text = "Salvează!";
            this.btnSalveazaCart.UseVisualStyleBackColor = true;
            this.btnSalveazaCart.Click += new System.EventHandler(this.btnSalveazaCart_Click);
            // 
            // numericUpDownCantitateCart
            // 
            this.numericUpDownCantitateCart.Font = new System.Drawing.Font("Roboto Slab", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.numericUpDownCantitateCart.Location = new System.Drawing.Point(60, 76);
            this.numericUpDownCantitateCart.Name = "numericUpDownCantitateCart";
            this.numericUpDownCantitateCart.Size = new System.Drawing.Size(182, 33);
            this.numericUpDownCantitateCart.TabIndex = 1;
            this.numericUpDownCantitateCart.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Roboto Slab SemiBold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(101)))), ((int)(((byte)(39)))));
            this.label1.Location = new System.Drawing.Point(55, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(191, 26);
            this.label1.TabIndex = 0;
            this.label1.Text = "Selectați cantitatea:";
            // 
            // FrmCantitCart
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(300, 200);
            this.Controls.Add(this.panel1);
            this.Name = "FrmCantitCart";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmCantitCart";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownCantitateCart)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.NumericUpDown numericUpDownCantitateCart;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnSalveazaCart;
    }
}