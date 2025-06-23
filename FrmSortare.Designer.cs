namespace PracticaTehnologica
{
    partial class FrmSortare
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmSortare));
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnJucarenia = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lbltextBoxPretMax = new System.Windows.Forms.Label();
            this.textBoxPretMax = new System.Windows.Forms.TextBox();
            this.textBoxVarstaMin = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxVarstaMax = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.dataGridViewJucarii = new System.Windows.Forms.DataGridView();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewJucarii)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.dataGridViewJucarii);
            this.panel1.Controls.Add(this.groupBox1);
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
            this.btnJucarenia.Location = new System.Drawing.Point(27, 28);
            this.btnJucarenia.Margin = new System.Windows.Forms.Padding(2);
            this.btnJucarenia.Name = "btnJucarenia";
            this.btnJucarenia.Size = new System.Drawing.Size(211, 60);
            this.btnJucarenia.TabIndex = 13;
            this.btnJucarenia.UseVisualStyleBackColor = false;
            this.btnJucarenia.Click += new System.EventHandler(this.btnJucarenia_Click);
            // 
            // button1
            // 
            this.button1.FlatAppearance.BorderColor = System.Drawing.Color.LightGray;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.button1.Location = new System.Drawing.Point(102, 378);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(129, 35);
            this.button1.TabIndex = 14;
            this.button1.Text = "Afișează!";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.textBoxVarstaMax);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.textBoxVarstaMin);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.textBoxPretMax);
            this.groupBox1.Controls.Add(this.lbltextBoxPretMax);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Font = new System.Drawing.Font("Roboto Slab Medium", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.groupBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(101)))), ((int)(((byte)(39)))));
            this.groupBox1.Location = new System.Drawing.Point(118, 256);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(333, 456);
            this.groupBox1.TabIndex = 15;
            this.groupBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.label1.Location = new System.Drawing.Point(105, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(122, 26);
            this.label1.TabIndex = 15;
            this.label1.Text = "Introduceți :";
            // 
            // lbltextBoxPretMax
            // 
            this.lbltextBoxPretMax.AutoSize = true;
            this.lbltextBoxPretMax.Font = new System.Drawing.Font("Roboto Slab Medium", 12F, System.Drawing.FontStyle.Bold);
            this.lbltextBoxPretMax.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(101)))), ((int)(((byte)(39)))));
            this.lbltextBoxPretMax.Location = new System.Drawing.Point(48, 101);
            this.lbltextBoxPretMax.Name = "lbltextBoxPretMax";
            this.lbltextBoxPretMax.Size = new System.Drawing.Size(185, 22);
            this.lbltextBoxPretMax.TabIndex = 16;
            this.lbltextBoxPretMax.Text = "Limita Maximă De Preț";
            // 
            // textBoxPretMax
            // 
            this.textBoxPretMax.Location = new System.Drawing.Point(52, 129);
            this.textBoxPretMax.Name = "textBoxPretMax";
            this.textBoxPretMax.Size = new System.Drawing.Size(232, 33);
            this.textBoxPretMax.TabIndex = 17;
            // 
            // textBoxVarstaMin
            // 
            this.textBoxVarstaMin.Location = new System.Drawing.Point(52, 220);
            this.textBoxVarstaMin.Name = "textBoxVarstaMin";
            this.textBoxVarstaMin.Size = new System.Drawing.Size(232, 33);
            this.textBoxVarstaMin.TabIndex = 19;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Roboto Slab Medium", 12F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(101)))), ((int)(((byte)(39)))));
            this.label2.Location = new System.Drawing.Point(48, 191);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(125, 22);
            this.label2.TabIndex = 18;
            this.label2.Text = "Vârsta Minimă";
            // 
            // textBoxVarstaMax
            // 
            this.textBoxVarstaMax.Location = new System.Drawing.Point(52, 311);
            this.textBoxVarstaMax.Name = "textBoxVarstaMax";
            this.textBoxVarstaMax.Size = new System.Drawing.Size(232, 33);
            this.textBoxVarstaMax.TabIndex = 21;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Roboto Slab Medium", 12F, System.Drawing.FontStyle.Bold);
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(101)))), ((int)(((byte)(39)))));
            this.label3.Location = new System.Drawing.Point(48, 281);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(129, 22);
            this.label3.TabIndex = 20;
            this.label3.Text = "Vârsta Maximă";
            // 
            // dataGridViewJucarii
            // 
            this.dataGridViewJucarii.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewJucarii.Location = new System.Drawing.Point(647, 199);
            this.dataGridViewJucarii.Name = "dataGridViewJucarii";
            this.dataGridViewJucarii.Size = new System.Drawing.Size(670, 545);
            this.dataGridViewJucarii.TabIndex = 16;
            // 
            // FrmSortare
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1440, 900);
            this.Controls.Add(this.panel1);
            this.Name = "FrmSortare";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.panel1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewJucarii)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnJucarenia;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lbltextBoxPretMax;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxPretMax;
        private System.Windows.Forms.TextBox textBoxVarstaMin;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxVarstaMax;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView dataGridViewJucarii;
    }
}