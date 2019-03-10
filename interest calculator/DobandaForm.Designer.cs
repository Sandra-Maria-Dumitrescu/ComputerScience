namespace CalculeazaDobanda
{
    partial class DobandaForm
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
            this.tfRezultatDobanda = new System.Windows.Forms.TextBox();
            this.btnCalcDobanda = new System.Windows.Forms.Button();
            this.tfRataDobanda = new System.Windows.Forms.TextBox();
            this.tfDurata = new System.Windows.Forms.TextBox();
            this.tfSumaDepusa = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // tfRezultatDobanda
            // 
            this.tfRezultatDobanda.Location = new System.Drawing.Point(182, 117);
            this.tfRezultatDobanda.Name = "tfRezultatDobanda";
            this.tfRezultatDobanda.ReadOnly = true;
            this.tfRezultatDobanda.Size = new System.Drawing.Size(100, 20);
            this.tfRezultatDobanda.TabIndex = 5;
            // 
            // btnCalcDobanda
            // 
            this.btnCalcDobanda.Location = new System.Drawing.Point(15, 117);
            this.btnCalcDobanda.Name = "btnCalcDobanda";
            this.btnCalcDobanda.Size = new System.Drawing.Size(160, 23);
            this.btnCalcDobanda.TabIndex = 4;
            this.btnCalcDobanda.Text = "Calculeaza dobanda lunara";
            this.btnCalcDobanda.UseVisualStyleBackColor = true;
            this.btnCalcDobanda.Click += new System.EventHandler(this.btnCalcDobanda_Click);
            // 
            // tfRataDobanda
            // 
            this.tfRataDobanda.Location = new System.Drawing.Point(182, 47);
            this.tfRataDobanda.Name = "tfRataDobanda";
            this.tfRataDobanda.Size = new System.Drawing.Size(100, 20);
            this.tfRataDobanda.TabIndex = 2;
            this.tfRataDobanda.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tfRataDobanda_KeyPress);
            // 
            // tfDurata
            // 
            this.tfDurata.Location = new System.Drawing.Point(182, 85);
            this.tfDurata.Name = "tfDurata";
            this.tfDurata.Size = new System.Drawing.Size(100, 20);
            this.tfDurata.TabIndex = 3;
            this.tfDurata.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tfDurata_KeyPress);
            // 
            // tfSumaDepusa
            // 
            this.tfSumaDepusa.Location = new System.Drawing.Point(182, 12);
            this.tfSumaDepusa.Name = "tfSumaDepusa";
            this.tfSumaDepusa.Size = new System.Drawing.Size(100, 20);
            this.tfSumaDepusa.TabIndex = 1;
            this.tfSumaDepusa.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tfSumaDepusa_KeyPress);
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.label3.Location = new System.Drawing.Point(12, 82);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(160, 23);
            this.label3.TabIndex = 10;
            this.label3.Text = "Durata depozit (luni)";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.label2.Location = new System.Drawing.Point(12, 47);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(160, 23);
            this.label2.TabIndex = 9;
            this.label2.Text = "Dobanda";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.label1.Location = new System.Drawing.Point(12, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(160, 23);
            this.label1.TabIndex = 8;
            this.label1.Text = "Suma depusa";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(357, 115);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(60, 23);
            this.button1.TabIndex = 7;
            this.button1.Text = "Inapoi";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(294, 114);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(60, 23);
            this.button2.TabIndex = 6;
            this.button2.Text = "Reset";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(286, 47);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(51, 23);
            this.label4.TabIndex = 11;
            this.label4.Text = "%";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // DobandaForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(424, 162);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.tfRezultatDobanda);
            this.Controls.Add(this.btnCalcDobanda);
            this.Controls.Add(this.tfRataDobanda);
            this.Controls.Add(this.tfDurata);
            this.Controls.Add(this.tfSumaDepusa);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "DobandaForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DobandaForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tfRezultatDobanda;
        private System.Windows.Forms.Button btnCalcDobanda;
        private System.Windows.Forms.TextBox tfRataDobanda;
        private System.Windows.Forms.TextBox tfDurata;
        private System.Windows.Forms.TextBox tfSumaDepusa;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label4;
    }
}