
namespace KaloriTakipv2
{
    partial class MainPage
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainPage));
            this.pBaslik = new System.Windows.Forms.Panel();
            this.lblHosgeldin = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.tsMenu = new System.Windows.Forms.ToolStrip();
            this.toolStripSplitButton1 = new System.Windows.Forms.ToolStripSplitButton();
            this.tsmkullanıcıBilgileri = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmYemekBilgileri = new System.Windows.Forms.ToolStripMenuItem();
            this.çıkışYapToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.lblKullaniciAdi = new System.Windows.Forms.Label();
            this.pKullaniciBilgileri = new System.Windows.Forms.Panel();
            this.txtBirtdate = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtCinsiyet = new System.Windows.Forms.TextBox();
            this.txtFullname = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.ımageList1 = new System.Windows.Forms.ImageList(this.components);
            this.pBaslik.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.tsMenu.SuspendLayout();
            this.pKullaniciBilgileri.SuspendLayout();
            this.SuspendLayout();
            // 
            // pBaslik
            // 
            this.pBaslik.BackColor = System.Drawing.Color.White;
            this.pBaslik.Controls.Add(this.lblKullaniciAdi);
            this.pBaslik.Controls.Add(this.lblHosgeldin);
            this.pBaslik.Controls.Add(this.pictureBox1);
            this.pBaslik.Controls.Add(this.tsMenu);
            this.pBaslik.Location = new System.Drawing.Point(-4, 2);
            this.pBaslik.Name = "pBaslik";
            this.pBaslik.Size = new System.Drawing.Size(1266, 100);
            this.pBaslik.TabIndex = 1;
            // 
            // lblHosgeldin
            // 
            this.lblHosgeldin.AutoSize = true;
            this.lblHosgeldin.Font = new System.Drawing.Font("Segoe Script", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblHosgeldin.Location = new System.Drawing.Point(184, 33);
            this.lblHosgeldin.Name = "lblHosgeldin";
            this.lblHosgeldin.Size = new System.Drawing.Size(189, 51);
            this.lblHosgeldin.TabIndex = 2;
            this.lblHosgeldin.Text = "Hoşgeldin";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(97, 24);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(68, 63);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // tsMenu
            // 
            this.tsMenu.BackColor = System.Drawing.Color.Transparent;
            this.tsMenu.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tsMenu.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.tsMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripSplitButton1});
            this.tsMenu.Location = new System.Drawing.Point(0, 0);
            this.tsMenu.Name = "tsMenu";
            this.tsMenu.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.tsMenu.Size = new System.Drawing.Size(1266, 100);
            this.tsMenu.TabIndex = 3;
            this.tsMenu.Text = "toolStrip1";
            // 
            // toolStripSplitButton1
            // 
            this.toolStripSplitButton1.BackColor = System.Drawing.Color.Transparent;
            this.toolStripSplitButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripSplitButton1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmkullanıcıBilgileri,
            this.tsmYemekBilgileri,
            this.toolStripMenuItem1,
            this.çıkışYapToolStripMenuItem});
            this.toolStripSplitButton1.Font = new System.Drawing.Font("Nirmala UI Semilight", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.toolStripSplitButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripSplitButton1.Image")));
            this.toolStripSplitButton1.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.toolStripSplitButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripSplitButton1.Name = "toolStripSplitButton1";
            this.toolStripSplitButton1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.toolStripSplitButton1.Size = new System.Drawing.Size(71, 97);
            this.toolStripSplitButton1.Text = "tsbMenu";
            this.toolStripSplitButton1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.toolStripSplitButton1.TextDirection = System.Windows.Forms.ToolStripTextDirection.Horizontal;
            this.toolStripSplitButton1.ToolTipText = "tsbMenu\r\n";
            // 
            // tsmkullanıcıBilgileri
            // 
            this.tsmkullanıcıBilgileri.Name = "tsmkullanıcıBilgileri";
            this.tsmkullanıcıBilgileri.Size = new System.Drawing.Size(222, 30);
            this.tsmkullanıcıBilgileri.Text = "Kisisel Bilgiler";
            this.tsmkullanıcıBilgileri.Click += new System.EventHandler(this.kullanıcıBilgileriToolStripMenuItem_Click);
            // 
            // tsmYemekBilgileri
            // 
            this.tsmYemekBilgileri.Name = "tsmYemekBilgileri";
            this.tsmYemekBilgileri.Size = new System.Drawing.Size(222, 30);
            this.tsmYemekBilgileri.Text = "Yemek Bilgileri";
            // 
            // çıkışYapToolStripMenuItem
            // 
            this.çıkışYapToolStripMenuItem.Name = "çıkışYapToolStripMenuItem";
            this.çıkışYapToolStripMenuItem.Size = new System.Drawing.Size(222, 30);
            this.çıkışYapToolStripMenuItem.Text = "Exit";
            this.çıkışYapToolStripMenuItem.Click += new System.EventHandler(this.çıkışYapToolStripMenuItem_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(222, 30);
            this.toolStripMenuItem1.Text = "Raporlar Ekranı";
            this.toolStripMenuItem1.Click += new System.EventHandler(this.toolStripMenuItem1_Click);
            // 
            // lblKullaniciAdi
            // 
            this.lblKullaniciAdi.AutoSize = true;
            this.lblKullaniciAdi.Font = new System.Drawing.Font("Segoe Script", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblKullaniciAdi.Location = new System.Drawing.Point(358, 33);
            this.lblKullaniciAdi.Name = "lblKullaniciAdi";
            this.lblKullaniciAdi.Size = new System.Drawing.Size(186, 51);
            this.lblKullaniciAdi.TabIndex = 4;
            this.lblKullaniciAdi.Text = "Kullanıcı";
            // 
            // pKullaniciBilgileri
            // 
            this.pKullaniciBilgileri.BackColor = System.Drawing.Color.White;
            this.pKullaniciBilgileri.Controls.Add(this.btnUpdate);
            this.pKullaniciBilgileri.Controls.Add(this.txtBirtdate);
            this.pKullaniciBilgileri.Controls.Add(this.txtEmail);
            this.pKullaniciBilgileri.Controls.Add(this.txtCinsiyet);
            this.pKullaniciBilgileri.Controls.Add(this.txtFullname);
            this.pKullaniciBilgileri.Controls.Add(this.label5);
            this.pKullaniciBilgileri.Controls.Add(this.label4);
            this.pKullaniciBilgileri.Controls.Add(this.label3);
            this.pKullaniciBilgileri.Controls.Add(this.label2);
            this.pKullaniciBilgileri.Location = new System.Drawing.Point(104, 105);
            this.pKullaniciBilgileri.Name = "pKullaniciBilgileri";
            this.pKullaniciBilgileri.Size = new System.Drawing.Size(1069, 705);
            this.pKullaniciBilgileri.TabIndex = 2;
            this.pKullaniciBilgileri.Visible = false;
            // 
            // txtBirtdate
            // 
            this.txtBirtdate.BackColor = System.Drawing.Color.White;
            this.txtBirtdate.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtBirtdate.Location = new System.Drawing.Point(360, 374);
            this.txtBirtdate.Margin = new System.Windows.Forms.Padding(5);
            this.txtBirtdate.Multiline = true;
            this.txtBirtdate.Name = "txtBirtdate";
            this.txtBirtdate.Size = new System.Drawing.Size(320, 39);
            this.txtBirtdate.TabIndex = 12;
            // 
            // txtEmail
            // 
            this.txtEmail.BackColor = System.Drawing.Color.White;
            this.txtEmail.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtEmail.Location = new System.Drawing.Point(360, 284);
            this.txtEmail.Margin = new System.Windows.Forms.Padding(5);
            this.txtEmail.Multiline = true;
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(320, 39);
            this.txtEmail.TabIndex = 11;
            // 
            // txtCinsiyet
            // 
            this.txtCinsiyet.BackColor = System.Drawing.Color.White;
            this.txtCinsiyet.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtCinsiyet.Location = new System.Drawing.Point(360, 195);
            this.txtCinsiyet.Margin = new System.Windows.Forms.Padding(5);
            this.txtCinsiyet.Multiline = true;
            this.txtCinsiyet.Name = "txtCinsiyet";
            this.txtCinsiyet.Size = new System.Drawing.Size(320, 39);
            this.txtCinsiyet.TabIndex = 10;
            // 
            // txtFullname
            // 
            this.txtFullname.BackColor = System.Drawing.Color.White;
            this.txtFullname.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtFullname.Location = new System.Drawing.Point(360, 107);
            this.txtFullname.Margin = new System.Windows.Forms.Padding(5);
            this.txtFullname.Multiline = true;
            this.txtFullname.Name = "txtFullname";
            this.txtFullname.Size = new System.Drawing.Size(320, 39);
            this.txtFullname.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Nirmala UI Semilight", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(194, 383);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(128, 21);
            this.label5.TabIndex = 8;
            this.label5.Text = "Dogum Tarihi : ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Nirmala UI Semilight", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(194, 293);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(74, 21);
            this.label4.TabIndex = 7;
            this.label4.Text = "E-mail : ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Nirmala UI Semilight", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(194, 204);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(88, 21);
            this.label3.TabIndex = 6;
            this.label3.Text = "Cinsiyet : ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Nirmala UI Semilight", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(194, 116);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(130, 21);
            this.label2.TabIndex = 5;
            this.label2.Text = "Adı ve Soyadı : ";
            // 
            // btnUpdate
            // 
            this.btnUpdate.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.btnUpdate.BackColor = System.Drawing.Color.White;
            this.btnUpdate.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnUpdate.FlatAppearance.BorderSize = 0;
            this.btnUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdate.Font = new System.Drawing.Font("Nirmala UI Semilight", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnUpdate.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnUpdate.ImageIndex = 2;
            this.btnUpdate.ImageList = this.ımageList1;
            this.btnUpdate.Location = new System.Drawing.Point(431, 535);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(162, 75);
            this.btnUpdate.TabIndex = 15;
            this.btnUpdate.Text = "Güncelle";
            this.btnUpdate.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnUpdate.UseVisualStyleBackColor = false;
            // 
            // ımageList1
            // 
            this.ımageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth24Bit;
            this.ımageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("ımageList1.ImageStream")));
            this.ımageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.ımageList1.Images.SetKeyName(0, "save-icon.png");
            this.ımageList1.Images.SetKeyName(1, "delete-icon.png");
            this.ımageList1.Images.SetKeyName(2, "iconupdate.png");
            // 
            // MainPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1264, 815);
            this.Controls.Add(this.pBaslik);
            this.Controls.Add(this.pKullaniciBilgileri);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Name = "MainPage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MainPage";
            this.pBaslik.ResumeLayout(false);
            this.pBaslik.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.tsMenu.ResumeLayout(false);
            this.tsMenu.PerformLayout();
            this.pKullaniciBilgileri.ResumeLayout(false);
            this.pKullaniciBilgileri.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pBaslik;
        private System.Windows.Forms.Label lblHosgeldin;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ToolStrip tsMenu;
        private System.Windows.Forms.ToolStripSplitButton toolStripSplitButton1;
        private System.Windows.Forms.ToolStripMenuItem tsmkullanıcıBilgileri;
        private System.Windows.Forms.ToolStripMenuItem tsmYemekBilgileri;
        private System.Windows.Forms.ToolStripMenuItem çıkışYapToolStripMenuItem;
        private System.Windows.Forms.Label lblKullaniciAdi;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.Panel pKullaniciBilgileri;
        private System.Windows.Forms.TextBox txtBirtdate;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtCinsiyet;
        private System.Windows.Forms.TextBox txtFullname;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.ImageList ımageList1;
    }
}