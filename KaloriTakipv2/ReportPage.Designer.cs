
namespace KaloriTakipv2
{
    partial class ReportPage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ReportPage));
            this.btnBack = new System.Windows.Forms.Button();
            this.btnGunSonuRapor = new System.Windows.Forms.Button();
            this.btnKiyasRapor = new System.Windows.Forms.Button();
            this.btnYemekCesidi = new System.Windows.Forms.Button();
            this.pGunSonu = new System.Windows.Forms.Panel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.pKiyas = new System.Windows.Forms.Panel();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.pYemekCesidi = new System.Windows.Forms.Panel();
            this.dataGridView3 = new System.Windows.Forms.DataGridView();
            this.pGunSonu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.pKiyas.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.pYemekCesidi.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).BeginInit();
            this.SuspendLayout();
            // 
            // btnBack
            // 
            this.btnBack.BackColor = System.Drawing.Color.Transparent;
            this.btnBack.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnBack.BackgroundImage")));
            this.btnBack.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnBack.FlatAppearance.BorderSize = 0;
            this.btnBack.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnBack.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBack.Location = new System.Drawing.Point(21, 21);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(90, 90);
            this.btnBack.TabIndex = 8;
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // btnGunSonuRapor
            // 
            this.btnGunSonuRapor.BackColor = System.Drawing.Color.White;
            this.btnGunSonuRapor.FlatAppearance.BorderSize = 2;
            this.btnGunSonuRapor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGunSonuRapor.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnGunSonuRapor.ForeColor = System.Drawing.Color.Black;
            this.btnGunSonuRapor.Location = new System.Drawing.Point(203, 40);
            this.btnGunSonuRapor.Name = "btnGunSonuRapor";
            this.btnGunSonuRapor.Size = new System.Drawing.Size(260, 47);
            this.btnGunSonuRapor.TabIndex = 9;
            this.btnGunSonuRapor.Text = "Gün Sonu Raporu";
            this.btnGunSonuRapor.UseVisualStyleBackColor = false;
            this.btnGunSonuRapor.Click += new System.EventHandler(this.btnGunSonuRapor_Click);
            // 
            // btnKiyasRapor
            // 
            this.btnKiyasRapor.BackColor = System.Drawing.Color.White;
            this.btnKiyasRapor.FlatAppearance.BorderSize = 2;
            this.btnKiyasRapor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnKiyasRapor.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnKiyasRapor.ForeColor = System.Drawing.Color.Black;
            this.btnKiyasRapor.Location = new System.Drawing.Point(510, 40);
            this.btnKiyasRapor.Name = "btnKiyasRapor";
            this.btnKiyasRapor.Size = new System.Drawing.Size(260, 47);
            this.btnKiyasRapor.TabIndex = 10;
            this.btnKiyasRapor.Text = "Kıyas Raporu";
            this.btnKiyasRapor.UseVisualStyleBackColor = false;
            this.btnKiyasRapor.Click += new System.EventHandler(this.btnKiyasRapor_Click);
            // 
            // btnYemekCesidi
            // 
            this.btnYemekCesidi.BackColor = System.Drawing.Color.White;
            this.btnYemekCesidi.FlatAppearance.BorderSize = 2;
            this.btnYemekCesidi.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnYemekCesidi.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnYemekCesidi.ForeColor = System.Drawing.Color.Black;
            this.btnYemekCesidi.Location = new System.Drawing.Point(831, 40);
            this.btnYemekCesidi.Name = "btnYemekCesidi";
            this.btnYemekCesidi.Size = new System.Drawing.Size(260, 47);
            this.btnYemekCesidi.TabIndex = 11;
            this.btnYemekCesidi.Text = "Yemek Çeşidi Raporu";
            this.btnYemekCesidi.UseVisualStyleBackColor = false;
            this.btnYemekCesidi.Click += new System.EventHandler(this.btnYemekCesidi_Click);
            // 
            // pGunSonu
            // 
            this.pGunSonu.BackColor = System.Drawing.Color.White;
            this.pGunSonu.Controls.Add(this.dataGridView1);
            this.pGunSonu.Location = new System.Drawing.Point(132, 170);
            this.pGunSonu.Name = "pGunSonu";
            this.pGunSonu.Size = new System.Drawing.Size(1039, 571);
            this.pGunSonu.TabIndex = 12;
            this.pGunSonu.Visible = false;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(19, 19);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 25;
            this.dataGridView1.Size = new System.Drawing.Size(1002, 534);
            this.dataGridView1.TabIndex = 0;
            // 
            // pKiyas
            // 
            this.pKiyas.BackColor = System.Drawing.Color.White;
            this.pKiyas.Controls.Add(this.dataGridView2);
            this.pKiyas.Location = new System.Drawing.Point(132, 170);
            this.pKiyas.Name = "pKiyas";
            this.pKiyas.Size = new System.Drawing.Size(1039, 571);
            this.pKiyas.TabIndex = 13;
            this.pKiyas.Visible = false;
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(19, 19);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowTemplate.Height = 25;
            this.dataGridView2.Size = new System.Drawing.Size(1002, 534);
            this.dataGridView2.TabIndex = 0;
            // 
            // pYemekCesidi
            // 
            this.pYemekCesidi.BackColor = System.Drawing.Color.White;
            this.pYemekCesidi.Controls.Add(this.dataGridView3);
            this.pYemekCesidi.Location = new System.Drawing.Point(132, 170);
            this.pYemekCesidi.Name = "pYemekCesidi";
            this.pYemekCesidi.Size = new System.Drawing.Size(1039, 571);
            this.pYemekCesidi.TabIndex = 13;
            this.pYemekCesidi.Visible = false;
            // 
            // dataGridView3
            // 
            this.dataGridView3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView3.Location = new System.Drawing.Point(19, 19);
            this.dataGridView3.Name = "dataGridView3";
            this.dataGridView3.RowTemplate.Height = 25;
            this.dataGridView3.Size = new System.Drawing.Size(1002, 534);
            this.dataGridView3.TabIndex = 0;
            // 
            // ReportPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1264, 815);
            this.Controls.Add(this.pYemekCesidi);
            this.Controls.Add(this.pKiyas);
            this.Controls.Add(this.pGunSonu);
            this.Controls.Add(this.btnYemekCesidi);
            this.Controls.Add(this.btnKiyasRapor);
            this.Controls.Add(this.btnGunSonuRapor);
            this.Controls.Add(this.btnBack);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ReportPage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ReportPage";
            this.pGunSonu.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.pKiyas.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.pYemekCesidi.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Button btnGunSonuRapor;
        private System.Windows.Forms.Button btnKiyasRapor;
        private System.Windows.Forms.Button btnYemekCesidi;
        private System.Windows.Forms.Panel pGunSonu;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Panel pKiyas;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.Panel pYemekCesidi;
        private System.Windows.Forms.DataGridView dataGridView3;
    }
}