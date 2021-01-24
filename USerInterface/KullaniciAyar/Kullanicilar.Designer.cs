
namespace USerInterface.KullaniciAyar
{
    partial class Kullanicilar
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.dosyaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.güncelleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.adminYetkisiVerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.adminYetkisiniAlToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.silToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.yenileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dgv_kullanicilar = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_kullanicilar)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.dosyaToolStripMenuItem,
            this.yenileToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(545, 24);
            this.menuStrip1.TabIndex = 5;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // dosyaToolStripMenuItem
            // 
            this.dosyaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.güncelleToolStripMenuItem,
            this.silToolStripMenuItem});
            this.dosyaToolStripMenuItem.Name = "dosyaToolStripMenuItem";
            this.dosyaToolStripMenuItem.Size = new System.Drawing.Size(60, 20);
            this.dosyaToolStripMenuItem.Text = "İşlemler";
            // 
            // güncelleToolStripMenuItem
            // 
            this.güncelleToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.adminYetkisiVerToolStripMenuItem,
            this.adminYetkisiniAlToolStripMenuItem});
            this.güncelleToolStripMenuItem.Name = "güncelleToolStripMenuItem";
            this.güncelleToolStripMenuItem.Size = new System.Drawing.Size(146, 22);
            this.güncelleToolStripMenuItem.Text = "Yetki İşlemleri";
            // 
            // adminYetkisiVerToolStripMenuItem
            // 
            this.adminYetkisiVerToolStripMenuItem.Name = "adminYetkisiVerToolStripMenuItem";
            this.adminYetkisiVerToolStripMenuItem.Size = new System.Drawing.Size(170, 22);
            this.adminYetkisiVerToolStripMenuItem.Text = "Admin Yetkisi Ver";
            this.adminYetkisiVerToolStripMenuItem.Click += new System.EventHandler(this.adminYetkisiVerToolStripMenuItem_Click);
            // 
            // adminYetkisiniAlToolStripMenuItem
            // 
            this.adminYetkisiniAlToolStripMenuItem.Name = "adminYetkisiniAlToolStripMenuItem";
            this.adminYetkisiniAlToolStripMenuItem.Size = new System.Drawing.Size(170, 22);
            this.adminYetkisiniAlToolStripMenuItem.Text = "Admin Yetkisini Al";
            this.adminYetkisiniAlToolStripMenuItem.Click += new System.EventHandler(this.adminYetkisiniAlToolStripMenuItem_Click);
            // 
            // silToolStripMenuItem
            // 
            this.silToolStripMenuItem.Name = "silToolStripMenuItem";
            this.silToolStripMenuItem.Size = new System.Drawing.Size(146, 22);
            this.silToolStripMenuItem.Text = "Sil";
            this.silToolStripMenuItem.Click += new System.EventHandler(this.silToolStripMenuItem_Click);
            // 
            // yenileToolStripMenuItem
            // 
            this.yenileToolStripMenuItem.Name = "yenileToolStripMenuItem";
            this.yenileToolStripMenuItem.Size = new System.Drawing.Size(50, 20);
            this.yenileToolStripMenuItem.Text = "Yenile";
            this.yenileToolStripMenuItem.Click += new System.EventHandler(this.yenileToolStripMenuItem_Click);
            // 
            // dgv_kullanicilar
            // 
            this.dgv_kullanicilar.AllowUserToAddRows = false;
            this.dgv_kullanicilar.AllowUserToDeleteRows = false;
            this.dgv_kullanicilar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_kullanicilar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgv_kullanicilar.Location = new System.Drawing.Point(3, 16);
            this.dgv_kullanicilar.Name = "dgv_kullanicilar";
            this.dgv_kullanicilar.ReadOnly = true;
            this.dgv_kullanicilar.Size = new System.Drawing.Size(536, 247);
            this.dgv_kullanicilar.TabIndex = 1;
            this.dgv_kullanicilar.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_kullanicilar_CellClick);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dgv_kullanicilar);
            this.groupBox1.Location = new System.Drawing.Point(0, 27);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(542, 266);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            // 
            // Kullanicilar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(545, 297);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.groupBox1);
            this.Name = "Kullanicilar";
            this.ShowIcon = false;
            this.Text = "Personeller";
            this.Load += new System.EventHandler(this.Kullanicilar_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_kullanicilar)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem dosyaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem güncelleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem silToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem yenileToolStripMenuItem;
        private System.Windows.Forms.DataGridView dgv_kullanicilar;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ToolStripMenuItem adminYetkisiVerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem adminYetkisiniAlToolStripMenuItem;
    }
}