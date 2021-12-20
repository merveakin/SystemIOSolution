
namespace SystemIOWindowFormApp
{
    partial class Form1
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
            this.groupBoxPersonelListe = new System.Windows.Forms.GroupBox();
            this.listBoxPersoneller = new System.Windows.Forms.ListBox();
            this.groupBoxPersonelDetay = new System.Windows.Forms.GroupBox();
            this.txtUlke = new System.Windows.Forms.TextBox();
            this.txtFirma = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtSoyisim = new System.Windows.Forms.TextBox();
            this.txtIsim = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnPersonelGetir = new System.Windows.Forms.Button();
            this.btnPersonelKaydet = new System.Windows.Forms.Button();
            this.groupBoxPersonelListe.SuspendLayout();
            this.groupBoxPersonelDetay.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBoxPersonelListe
            // 
            this.groupBoxPersonelListe.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.groupBoxPersonelListe.Controls.Add(this.listBoxPersoneller);
            this.groupBoxPersonelListe.Location = new System.Drawing.Point(22, 58);
            this.groupBoxPersonelListe.Name = "groupBoxPersonelListe";
            this.groupBoxPersonelListe.Size = new System.Drawing.Size(310, 593);
            this.groupBoxPersonelListe.TabIndex = 0;
            this.groupBoxPersonelListe.TabStop = false;
            this.groupBoxPersonelListe.Text = "Personel Listesi";
            // 
            // listBoxPersoneller
            // 
            this.listBoxPersoneller.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.listBoxPersoneller.FormattingEnabled = true;
            this.listBoxPersoneller.ItemHeight = 16;
            this.listBoxPersoneller.Location = new System.Drawing.Point(6, 43);
            this.listBoxPersoneller.Name = "listBoxPersoneller";
            this.listBoxPersoneller.Size = new System.Drawing.Size(297, 532);
            this.listBoxPersoneller.TabIndex = 0;
            // 
            // groupBoxPersonelDetay
            // 
            this.groupBoxPersonelDetay.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.groupBoxPersonelDetay.Controls.Add(this.txtUlke);
            this.groupBoxPersonelDetay.Controls.Add(this.txtFirma);
            this.groupBoxPersonelDetay.Controls.Add(this.txtEmail);
            this.groupBoxPersonelDetay.Controls.Add(this.txtSoyisim);
            this.groupBoxPersonelDetay.Controls.Add(this.txtIsim);
            this.groupBoxPersonelDetay.Controls.Add(this.label5);
            this.groupBoxPersonelDetay.Controls.Add(this.label4);
            this.groupBoxPersonelDetay.Controls.Add(this.label3);
            this.groupBoxPersonelDetay.Controls.Add(this.label2);
            this.groupBoxPersonelDetay.Controls.Add(this.label1);
            this.groupBoxPersonelDetay.Location = new System.Drawing.Point(347, 58);
            this.groupBoxPersonelDetay.Name = "groupBoxPersonelDetay";
            this.groupBoxPersonelDetay.Size = new System.Drawing.Size(316, 278);
            this.groupBoxPersonelDetay.TabIndex = 0;
            this.groupBoxPersonelDetay.TabStop = false;
            this.groupBoxPersonelDetay.Text = "Personel Detayları";
            // 
            // txtUlke
            // 
            this.txtUlke.Location = new System.Drawing.Point(71, 232);
            this.txtUlke.Name = "txtUlke";
            this.txtUlke.Size = new System.Drawing.Size(229, 22);
            this.txtUlke.TabIndex = 10;
            // 
            // txtFirma
            // 
            this.txtFirma.Location = new System.Drawing.Point(71, 180);
            this.txtFirma.Name = "txtFirma";
            this.txtFirma.Size = new System.Drawing.Size(229, 22);
            this.txtFirma.TabIndex = 9;
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(71, 131);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(229, 22);
            this.txtEmail.TabIndex = 8;
            // 
            // txtSoyisim
            // 
            this.txtSoyisim.Location = new System.Drawing.Point(71, 84);
            this.txtSoyisim.Name = "txtSoyisim";
            this.txtSoyisim.Size = new System.Drawing.Size(229, 22);
            this.txtSoyisim.TabIndex = 7;
            // 
            // txtIsim
            // 
            this.txtIsim.Location = new System.Drawing.Point(71, 43);
            this.txtIsim.Name = "txtIsim";
            this.txtIsim.Size = new System.Drawing.Size(229, 22);
            this.txtIsim.TabIndex = 6;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 237);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(44, 17);
            this.label5.TabIndex = 5;
            this.label5.Text = "Ülke :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(5, 185);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(51, 17);
            this.label4.TabIndex = 4;
            this.label4.Text = "Firma :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(5, 134);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 17);
            this.label3.TabIndex = 3;
            this.label3.Text = "Email :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 89);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Soyisim :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "İsim :";
            // 
            // btnPersonelGetir
            // 
            this.btnPersonelGetir.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnPersonelGetir.Location = new System.Drawing.Point(22, 667);
            this.btnPersonelGetir.Name = "btnPersonelGetir";
            this.btnPersonelGetir.Size = new System.Drawing.Size(310, 52);
            this.btnPersonelGetir.TabIndex = 11;
            this.btnPersonelGetir.Text = "PERSONEL GETİR";
            this.btnPersonelGetir.UseVisualStyleBackColor = false;
            // 
            // btnPersonelKaydet
            // 
            this.btnPersonelKaydet.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnPersonelKaydet.Location = new System.Drawing.Point(347, 353);
            this.btnPersonelKaydet.Name = "btnPersonelKaydet";
            this.btnPersonelKaydet.Size = new System.Drawing.Size(316, 42);
            this.btnPersonelKaydet.TabIndex = 12;
            this.btnPersonelKaydet.Text = "PERSONELİ BİLGİSAYARIMA KAYDET";
            this.btnPersonelKaydet.UseVisualStyleBackColor = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.MenuBar;
            this.ClientSize = new System.Drawing.Size(698, 772);
            this.Controls.Add(this.btnPersonelGetir);
            this.Controls.Add(this.btnPersonelKaydet);
            this.Controls.Add(this.groupBoxPersonelDetay);
            this.Controls.Add(this.groupBoxPersonelListe);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBoxPersonelListe.ResumeLayout(false);
            this.groupBoxPersonelDetay.ResumeLayout(false);
            this.groupBoxPersonelDetay.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxPersonelListe;
        private System.Windows.Forms.ListBox listBoxPersoneller;
        private System.Windows.Forms.GroupBox groupBoxPersonelDetay;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtUlke;
        private System.Windows.Forms.TextBox txtFirma;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtSoyisim;
        private System.Windows.Forms.TextBox txtIsim;
        private System.Windows.Forms.Button btnPersonelGetir;
        private System.Windows.Forms.Button btnPersonelKaydet;
    }
}

