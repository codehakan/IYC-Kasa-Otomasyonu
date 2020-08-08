namespace IYC_Kasa_Otomasyonu
{
    partial class frmOgrenciCikisi
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmOgrenciCikisi));
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_kayitTarihi = new System.Windows.Forms.MaskedTextBox();
            this.txt_adiSoyadi = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.btn_cancel = new DevExpress.XtraEditors.SimpleButton();
            this.btn_ok = new DevExpress.XtraEditors.SimpleButton();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_odedigiUcret = new DevExpress.XtraEditors.TextEdit();
            this.txt_cikisTarihi = new System.Windows.Forms.MaskedTextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.groupControl2 = new DevExpress.XtraEditors.GroupControl();
            this.txt_aramaYap = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txt_odedigiUcret.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).BeginInit();
            this.groupControl2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupControl1
            // 
            this.groupControl1.AppearanceCaption.Font = new System.Drawing.Font("Tahoma", 12F);
            this.groupControl1.AppearanceCaption.Options.UseFont = true;
            this.groupControl1.CaptionImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("groupControl1.CaptionImageOptions.Image")));
            this.groupControl1.Controls.Add(this.label4);
            this.groupControl1.Controls.Add(this.label1);
            this.groupControl1.Controls.Add(this.txt_kayitTarihi);
            this.groupControl1.Controls.Add(this.txt_adiSoyadi);
            this.groupControl1.Controls.Add(this.label10);
            this.groupControl1.Controls.Add(this.btn_cancel);
            this.groupControl1.Controls.Add(this.btn_ok);
            this.groupControl1.Controls.Add(this.label3);
            this.groupControl1.Controls.Add(this.label2);
            this.groupControl1.Controls.Add(this.txt_odedigiUcret);
            this.groupControl1.Controls.Add(this.txt_cikisTarihi);
            this.groupControl1.Location = new System.Drawing.Point(12, 12);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(344, 261);
            this.groupControl1.TabIndex = 5;
            this.groupControl1.Text = "Öğrenci Çıkışı Yap";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label4.Font = new System.Drawing.Font("Tahoma", 7F);
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.label4.Location = new System.Drawing.Point(105, 219);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(133, 26);
            this.label4.TabIndex = 15;
            this.label4.Text = "Kayıt tarihini öğrenci\r\ndüzenlemeden yapabilirsiniz.";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(28, 124);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 20);
            this.label1.TabIndex = 14;
            this.label1.Text = "Kayıt Tarihi:";
            // 
            // txt_kayitTarihi
            // 
            this.txt_kayitTarihi.Enabled = false;
            this.txt_kayitTarihi.Font = new System.Drawing.Font("Tahoma", 12F);
            this.txt_kayitTarihi.Location = new System.Drawing.Point(123, 121);
            this.txt_kayitTarihi.Mask = "00/00/0000";
            this.txt_kayitTarihi.Name = "txt_kayitTarihi";
            this.txt_kayitTarihi.Size = new System.Drawing.Size(186, 27);
            this.txt_kayitTarihi.TabIndex = 13;
            // 
            // txt_adiSoyadi
            // 
            this.txt_adiSoyadi.Enabled = false;
            this.txt_adiSoyadi.Font = new System.Drawing.Font("Tahoma", 12F);
            this.txt_adiSoyadi.Location = new System.Drawing.Point(123, 54);
            this.txt_adiSoyadi.Name = "txt_adiSoyadi";
            this.txt_adiSoyadi.Size = new System.Drawing.Size(186, 27);
            this.txt_adiSoyadi.TabIndex = 12;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label10.Location = new System.Drawing.Point(29, 57);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(88, 20);
            this.label10.TabIndex = 11;
            this.label10.Text = "Adı Soyadı:";
            // 
            // btn_cancel
            // 
            this.btn_cancel.Appearance.Font = new System.Drawing.Font("Tahoma", 9F);
            this.btn_cancel.Appearance.Options.UseFont = true;
            this.btn_cancel.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Office2003;
            this.btn_cancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btn_cancel.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btn_cancel.ImageOptions.Image")));
            this.btn_cancel.Location = new System.Drawing.Point(5, 214);
            this.btn_cancel.Name = "btn_cancel";
            this.btn_cancel.Size = new System.Drawing.Size(94, 36);
            this.btn_cancel.TabIndex = 7;
            this.btn_cancel.Text = "IPTAL";
            // 
            // btn_ok
            // 
            this.btn_ok.Appearance.Font = new System.Drawing.Font("Tahoma", 9F);
            this.btn_ok.Appearance.Options.UseFont = true;
            this.btn_ok.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Office2003;
            this.btn_ok.Enabled = false;
            this.btn_ok.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btn_ok.ImageOptions.Image")));
            this.btn_ok.Location = new System.Drawing.Point(244, 214);
            this.btn_ok.Name = "btn_ok";
            this.btn_ok.Size = new System.Drawing.Size(95, 36);
            this.btn_ok.TabIndex = 6;
            this.btn_ok.Text = "KAYDET";
            this.btn_ok.Click += new System.EventHandler(this.btn_ok_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(29, 159);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(88, 20);
            this.label3.TabIndex = 9;
            this.label3.Text = "Çıkış Tarihi:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(20, 91);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(97, 20);
            this.label2.TabIndex = 8;
            this.label2.Text = "Ödediği Lira:";
            // 
            // txt_odedigiUcret
            // 
            this.txt_odedigiUcret.EditValue = "";
            this.txt_odedigiUcret.Location = new System.Drawing.Point(123, 87);
            this.txt_odedigiUcret.Name = "txt_odedigiUcret";
            this.txt_odedigiUcret.Properties.Appearance.BackColor = System.Drawing.Color.White;
            this.txt_odedigiUcret.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 12F);
            this.txt_odedigiUcret.Properties.Appearance.Options.UseBackColor = true;
            this.txt_odedigiUcret.Properties.Appearance.Options.UseFont = true;
            this.txt_odedigiUcret.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Style3D;
            this.txt_odedigiUcret.Properties.ContextImageOptions.Alignment = DevExpress.XtraEditors.ContextImageAlignment.Far;
            this.txt_odedigiUcret.Properties.ContextImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("txt_odedigiUcret.Properties.ContextImageOptions.Image")));
            this.txt_odedigiUcret.Size = new System.Drawing.Size(186, 28);
            this.txt_odedigiUcret.TabIndex = 6;
            // 
            // txt_cikisTarihi
            // 
            this.txt_cikisTarihi.Font = new System.Drawing.Font("Tahoma", 12F);
            this.txt_cikisTarihi.Location = new System.Drawing.Point(123, 156);
            this.txt_cikisTarihi.Mask = "00/00/0000";
            this.txt_cikisTarihi.Name = "txt_cikisTarihi";
            this.txt_cikisTarihi.Size = new System.Drawing.Size(186, 27);
            this.txt_cikisTarihi.TabIndex = 7;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToResizeColumns = false;
            this.dataGridView1.AllowUserToResizeRows = false;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(3, 48);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 9;
            this.dataGridView1.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(505, 208);
            this.dataGridView1.TabIndex = 8;
            this.dataGridView1.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellDoubleClick);
            // 
            // groupControl2
            // 
            this.groupControl2.AppearanceCaption.Font = new System.Drawing.Font("Tahoma", 12F);
            this.groupControl2.AppearanceCaption.Options.UseFont = true;
            this.groupControl2.CaptionImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("groupControl2.CaptionImageOptions.Image")));
            this.groupControl2.Controls.Add(this.txt_aramaYap);
            this.groupControl2.Controls.Add(this.dataGridView1);
            this.groupControl2.Location = new System.Drawing.Point(359, 12);
            this.groupControl2.Name = "groupControl2";
            this.groupControl2.Size = new System.Drawing.Size(513, 261);
            this.groupControl2.TabIndex = 9;
            this.groupControl2.Text = "Arama Yap:";
            // 
            // txt_aramaYap
            // 
            this.txt_aramaYap.Font = new System.Drawing.Font("Tahoma", 12F);
            this.txt_aramaYap.Location = new System.Drawing.Point(138, 6);
            this.txt_aramaYap.Name = "txt_aramaYap";
            this.txt_aramaYap.Size = new System.Drawing.Size(370, 27);
            this.txt_aramaYap.TabIndex = 9;
            // 
            // frmOgrenciCikisi
            // 
            this.AcceptButton = this.btn_ok;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btn_cancel;
            this.ClientSize = new System.Drawing.Size(884, 284);
            this.Controls.Add(this.groupControl2);
            this.Controls.Add(this.groupControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmOgrenciCikisi";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Öğrenci Çıkış Formu";
            this.Load += new System.EventHandler(this.frmOgrenciCikisi_Load);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.groupControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txt_odedigiUcret.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).EndInit();
            this.groupControl2.ResumeLayout(false);
            this.groupControl2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.GroupControl groupControl1;
        private System.Windows.Forms.TextBox txt_adiSoyadi;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private DevExpress.XtraEditors.TextEdit txt_odedigiUcret;
        private System.Windows.Forms.MaskedTextBox txt_cikisTarihi;
        private DevExpress.XtraEditors.SimpleButton btn_cancel;
        private DevExpress.XtraEditors.SimpleButton btn_ok;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MaskedTextBox txt_kayitTarihi;
        private System.Windows.Forms.Label label4;
        private DevExpress.XtraEditors.GroupControl groupControl2;
        private System.Windows.Forms.TextBox txt_aramaYap;
    }
}