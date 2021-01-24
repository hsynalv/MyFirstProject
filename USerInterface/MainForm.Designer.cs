
namespace USerInterface
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.txt_kullanici = new System.Windows.Forms.TextBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.ürünlerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.müşterilerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ayarlarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.profilAyarlarıToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.yöneticAyarlarıiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.personelEkleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.personelGüncelleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txt_kullanici
            // 
            this.txt_kullanici.BackColor = System.Drawing.Color.Red;
            this.txt_kullanici.Enabled = false;
            this.txt_kullanici.Font = new System.Drawing.Font("Modern No. 20", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_kullanici.ForeColor = System.Drawing.Color.Black;
            this.txt_kullanici.Location = new System.Drawing.Point(625, 0);
            this.txt_kullanici.Multiline = true;
            this.txt_kullanici.Name = "txt_kullanici";
            this.txt_kullanici.Size = new System.Drawing.Size(211, 25);
            this.txt_kullanici.TabIndex = 1;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ürünlerToolStripMenuItem,
            this.müşterilerToolStripMenuItem,
            this.ayarlarToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.menuStrip1.Size = new System.Drawing.Size(835, 24);
            this.menuStrip1.TabIndex = 3;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // ürünlerToolStripMenuItem
            // 
            this.ürünlerToolStripMenuItem.Name = "ürünlerToolStripMenuItem";
            this.ürünlerToolStripMenuItem.Size = new System.Drawing.Size(58, 20);
            this.ürünlerToolStripMenuItem.Text = "Ürünler";
            this.ürünlerToolStripMenuItem.Click += new System.EventHandler(this.ürünlerToolStripMenuItem_Click);
            // 
            // müşterilerToolStripMenuItem
            // 
            this.müşterilerToolStripMenuItem.Name = "müşterilerToolStripMenuItem";
            this.müşterilerToolStripMenuItem.Size = new System.Drawing.Size(72, 20);
            this.müşterilerToolStripMenuItem.Text = "Müşteriler";
            this.müşterilerToolStripMenuItem.Click += new System.EventHandler(this.müşterilerToolStripMenuItem_Click);
            // 
            // ayarlarToolStripMenuItem
            // 
            this.ayarlarToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.profilAyarlarıToolStripMenuItem,
            this.yöneticAyarlarıiToolStripMenuItem});
            this.ayarlarToolStripMenuItem.Name = "ayarlarToolStripMenuItem";
            this.ayarlarToolStripMenuItem.Size = new System.Drawing.Size(56, 20);
            this.ayarlarToolStripMenuItem.Text = "Ayarlar";
            // 
            // profilAyarlarıToolStripMenuItem
            // 
            this.profilAyarlarıToolStripMenuItem.Name = "profilAyarlarıToolStripMenuItem";
            this.profilAyarlarıToolStripMenuItem.Size = new System.Drawing.Size(162, 22);
            this.profilAyarlarıToolStripMenuItem.Text = "Profil Ayarları";
            this.profilAyarlarıToolStripMenuItem.Click += new System.EventHandler(this.profilAyarlarıToolStripMenuItem_Click);
            // 
            // yöneticAyarlarıiToolStripMenuItem
            // 
            this.yöneticAyarlarıiToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.personelEkleToolStripMenuItem,
            this.personelGüncelleToolStripMenuItem});
            this.yöneticAyarlarıiToolStripMenuItem.Name = "yöneticAyarlarıiToolStripMenuItem";
            this.yöneticAyarlarıiToolStripMenuItem.Size = new System.Drawing.Size(162, 22);
            this.yöneticAyarlarıiToolStripMenuItem.Text = "Yönetic Ayarlarıi ";
            // 
            // personelEkleToolStripMenuItem
            // 
            this.personelEkleToolStripMenuItem.Name = "personelEkleToolStripMenuItem";
            this.personelEkleToolStripMenuItem.Size = new System.Drawing.Size(185, 22);
            this.personelEkleToolStripMenuItem.Text = "Personel Ekle";
            this.personelEkleToolStripMenuItem.Click += new System.EventHandler(this.personelEkleToolStripMenuItem_Click);
            // 
            // personelGüncelleToolStripMenuItem
            // 
            this.personelGüncelleToolStripMenuItem.Name = "personelGüncelleToolStripMenuItem";
            this.personelGüncelleToolStripMenuItem.Size = new System.Drawing.Size(185, 22);
            this.personelGüncelleToolStripMenuItem.Text = "Personel Güncelle-Sil";
            this.personelGüncelleToolStripMenuItem.Click += new System.EventHandler(this.personelGüncelleToolStripMenuItem_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(835, 666);
            this.Controls.Add(this.txt_kullanici);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Skorsky Ticaret";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txt_kullanici;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem ürünlerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem müşterilerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ayarlarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem profilAyarlarıToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem yöneticAyarlarıiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem personelEkleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem personelGüncelleToolStripMenuItem;
    }
}