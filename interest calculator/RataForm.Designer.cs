namespace CalculeazaDobanda
{
    partial class RataForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tfValCredit = new System.Windows.Forms.TextBox();
            this.tfDobanda = new System.Windows.Forms.TextBox();
            this.tfPerioadaCredit = new System.Windows.Forms.TextBox();
            this.btnCalcRata = new System.Windows.Forms.Button();
            this.tfRezultatRata = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.label1.Location = new System.Drawing.Point(12, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(160, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "Valoare credit";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.label2.Location = new System.Drawing.Point(12, 50);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(160, 23);
            this.label2.TabIndex = 1;
            this.label2.Text = "Perioada credit (ani)";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.label3.Location = new System.Drawing.Point(12, 85);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(160, 23);
            this.label3.TabIndex = 2;
            this.label3.Text = "Dobanda";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tfValCredit
            // 
            this.tfValCredit.Location = new System.Drawing.Point(184, 15);
            this.tfValCredit.Name = "tfValCredit";
            this.tfValCredit.Size = new System.Drawing.Size(100, 20);
            this.tfValCredit.TabIndex = 1;
            this.tfValCredit.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tfValCredit_KeyPress);
            // 
            // tfDobanda
            // 
            this.tfDobanda.Location = new System.Drawing.Point(184, 88);
            this.tfDobanda.Name = "tfDobanda";
            this.tfDobanda.Size = new System.Drawing.Size(100, 20);
            this.tfDobanda.TabIndex = 3;
            this.tfDobanda.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tfDobanda_KeyPress);
            // 
            // tfPerioadaCredit
            // 
            this.tfPerioadaCredit.Location = new System.Drawing.Point(184, 50);
            this.tfPerioadaCredit.Name = "tfPerioadaCredit";
            this.tfPerioadaCredit.Size = new System.Drawing.Size(100, 20);
            this.tfPerioadaCredit.TabIndex = 2;
            this.tfPerioadaCredit.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tfPerioadaCredit_KeyPress);
            // 
            // btnCalcRata
            // 
            this.btnCalcRata.Location = new System.Drawing.Point(15, 120);
            this.btnCalcRata.Name = "btnCalcRata";
            this.btnCalcRata.Size = new System.Drawing.Size(160, 23);
            this.btnCalcRata.TabIndex = 4;
            this.btnCalcRata.Text = "Calculeaza rata lunara";
            this.btnCalcRata.UseVisualStyleBackColor = true;
            this.btnCalcRata.Click += new System.EventHandler(this.btnCalcRata_Click);
            // 
            // tfRezultatRata
            // 
            this.tfRezultatRata.Location = new System.Drawing.Point(184, 120);
            this.tfRezultatRata.Name = "tfRezultatRata";
            this.tfRezultatRata.ReadOnly = true;
            this.tfRezultatRata.Size = new System.Drawing.Size(100, 20);
            this.tfRezultatRata.TabIndex = 5;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(353, 120);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(60, 23);
            this.button1.TabIndex = 7;
            this.button1.Text = "Inapoi";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(290, 120);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(60, 23);
            this.button2.TabIndex = 6;
            this.button2.Text = "Reset";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(283, 88);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(51, 23);
            this.label4.TabIndex = 12;
            this.label4.Text = "%";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // RataForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(424, 162);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.tfRezultatRata);
            this.Controls.Add(this.btnCalcRata);
            this.Controls.Add(this.tfPerioadaCredit);
            this.Controls.Add(this.tfDobanda);
            this.Controls.Add(this.tfValCredit);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "RataForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "RataForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tfValCredit;
        private System.Windows.Forms.TextBox tfDobanda;
        private System.Windows.Forms.TextBox tfPerioadaCredit;
        private System.Windows.Forms.Button btnCalcRata;
        private System.Windows.Forms.TextBox tfRezultatRata;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label4;
    }
}