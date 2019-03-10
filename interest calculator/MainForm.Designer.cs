namespace CalculeazaDobanda
{
    partial class MainForm
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
            this.btnRata = new System.Windows.Forms.Button();
            this.btnDobanda = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnRata
            // 
            this.btnRata.Location = new System.Drawing.Point(57, 61);
            this.btnRata.Name = "btnRata";
            this.btnRata.Size = new System.Drawing.Size(135, 23);
            this.btnRata.TabIndex = 0;
            this.btnRata.Text = "Calculeaza Rata";
            this.btnRata.UseVisualStyleBackColor = true;
            this.btnRata.Click += new System.EventHandler(this.btnRata_Click);
            // 
            // btnDobanda
            // 
            this.btnDobanda.Location = new System.Drawing.Point(212, 61);
            this.btnDobanda.Name = "btnDobanda";
            this.btnDobanda.Size = new System.Drawing.Size(135, 23);
            this.btnDobanda.TabIndex = 1;
            this.btnDobanda.Text = "Calculeaza Dobanda";
            this.btnDobanda.UseVisualStyleBackColor = true;
            this.btnDobanda.Click += new System.EventHandler(this.btnDobanda_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 162);
            this.Controls.Add(this.btnDobanda);
            this.Controls.Add(this.btnRata);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sandra Dumitrescu - Proiect IS";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnRata;
        private System.Windows.Forms.Button btnDobanda;
    }
}

