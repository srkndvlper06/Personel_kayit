namespace Personel_kayit
{
    partial class Frmİstatistik
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
            this.label4 = new System.Windows.Forms.Label();
            this.lbltoplampersonel = new System.Windows.Forms.Label();
            this.lblsehir = new System.Windows.Forms.Label();
            this.lbltoplammaas = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.lblortalamamaas = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(189, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = "Toplam Personel Sayısı";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 71);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(101, 21);
            this.label4.TabIndex = 3;
            this.label4.Text = "Şehir Sayısı";
            // 
            // lbltoplampersonel
            // 
            this.lbltoplampersonel.AutoSize = true;
            this.lbltoplampersonel.Location = new System.Drawing.Point(238, 34);
            this.lbltoplampersonel.Name = "lbltoplampersonel";
            this.lbltoplampersonel.Size = new System.Drawing.Size(19, 21);
            this.lbltoplampersonel.TabIndex = 4;
            this.lbltoplampersonel.Text = "0";
            // 
            // lblsehir
            // 
            this.lblsehir.AutoSize = true;
            this.lblsehir.Location = new System.Drawing.Point(238, 71);
            this.lblsehir.Name = "lblsehir";
            this.lblsehir.Size = new System.Drawing.Size(19, 21);
            this.lblsehir.TabIndex = 7;
            this.lblsehir.Text = "0";
            // 
            // lbltoplammaas
            // 
            this.lbltoplammaas.AutoSize = true;
            this.lbltoplammaas.Location = new System.Drawing.Point(238, 104);
            this.lbltoplammaas.Name = "lbltoplammaas";
            this.lbltoplammaas.Size = new System.Drawing.Size(19, 21);
            this.lbltoplammaas.TabIndex = 9;
            this.lbltoplammaas.Text = "0";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(12, 104);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(112, 21);
            this.label10.TabIndex = 8;
            this.label10.Text = "Toplam Maaş";
            // 
            // lblortalamamaas
            // 
            this.lblortalamamaas.AutoSize = true;
            this.lblortalamamaas.Location = new System.Drawing.Point(238, 139);
            this.lblortalamamaas.Name = "lblortalamamaas";
            this.lblortalamamaas.Size = new System.Drawing.Size(19, 21);
            this.lblortalamamaas.TabIndex = 11;
            this.lblortalamamaas.Text = "0";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(12, 139);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(122, 21);
            this.label12.TabIndex = 10;
            this.label12.Text = "Ortalama Maaş";
            // 
            // Frmİstatistik
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(437, 288);
            this.Controls.Add(this.lblortalamamaas);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.lbltoplammaas);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.lblsehir);
            this.Controls.Add(this.lbltoplampersonel);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Frmİstatistik";
            this.Text = "İstatistik";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lbltoplampersonel;
        private System.Windows.Forms.Label lblsehir;
        private System.Windows.Forms.Label lbltoplammaas;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label lblortalamamaas;
        private System.Windows.Forms.Label label12;
    }
}