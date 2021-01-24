
namespace USerInterface.KullaniciAyar
{
    partial class SifreDegistir
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
            this.txt_eski = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_yeni2 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_yeni = new System.Windows.Forms.TextBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.btn_kaydet = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_kullanici = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 66);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Eski Şifre";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.ForeColor = System.Drawing.Color.Red;
            this.label2.Location = new System.Drawing.Point(21, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 17);
            this.label2.TabIndex = 1;
            // 
            // txt_eski
            // 
            this.txt_eski.Location = new System.Drawing.Point(98, 63);
            this.txt_eski.Name = "txt_eski";
            this.txt_eski.Size = new System.Drawing.Size(176, 20);
            this.txt_eski.TabIndex = 0;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(21, 125);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Yeni Şifre";
            // 
            // txt_yeni2
            // 
            this.txt_yeni2.Location = new System.Drawing.Point(98, 122);
            this.txt_yeni2.Name = "txt_yeni2";
            this.txt_yeni2.Size = new System.Drawing.Size(176, 20);
            this.txt_yeni2.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(21, 96);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "Yeni Şifre";
            // 
            // txt_yeni
            // 
            this.txt_yeni.Location = new System.Drawing.Point(98, 93);
            this.txt_yeni.Name = "txt_yeni";
            this.txt_yeni.Size = new System.Drawing.Size(176, 20);
            this.txt_yeni.TabIndex = 1;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(193, 149);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(88, 17);
            this.checkBox1.TabIndex = 3;
            this.checkBox1.Text = "Şifreyi Göster";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // btn_kaydet
            // 
            this.btn_kaydet.Location = new System.Drawing.Point(98, 172);
            this.btn_kaydet.Name = "btn_kaydet";
            this.btn_kaydet.Size = new System.Drawing.Size(93, 23);
            this.btn_kaydet.TabIndex = 3;
            this.btn_kaydet.Text = "Kaydet";
            this.btn_kaydet.UseVisualStyleBackColor = true;
            this.btn_kaydet.Click += new System.EventHandler(this.btn_kaydet_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(22, 37);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(64, 13);
            this.label5.TabIndex = 0;
            this.label5.Text = "Kullanıcı Adı";
            // 
            // txt_kullanici
            // 
            this.txt_kullanici.Location = new System.Drawing.Point(99, 34);
            this.txt_kullanici.Name = "txt_kullanici";
            this.txt_kullanici.Size = new System.Drawing.Size(176, 20);
            this.txt_kullanici.TabIndex = 0;
            // 
            // SifreDegistir
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(319, 205);
            this.Controls.Add(this.btn_kaydet);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.txt_yeni);
            this.Controls.Add(this.txt_yeni2);
            this.Controls.Add(this.txt_kullanici);
            this.Controls.Add(this.txt_eski);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label1);
            this.Name = "SifreDegistir";
            this.ShowIcon = false;
            this.Text = "Şifre Değiştir";
            this.Load += new System.EventHandler(this.SifreDegistir_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_eski;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_yeni2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_yeni;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.Button btn_kaydet;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txt_kullanici;
    }
}