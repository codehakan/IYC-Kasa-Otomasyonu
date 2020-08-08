namespace IYC_Kasa_Otomasyonu
{
    partial class frmTahsilEt
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmTahsilEt));
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.label5 = new System.Windows.Forms.Label();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.txt_taksit = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_adiSoyadi = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_ucret = new DevExpress.XtraEditors.TextEdit();
            this.txt_odemeTarihi = new System.Windows.Forms.MaskedTextBox();
            this.cmbx_odemeTurleri = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_cancel = new DevExpress.XtraEditors.SimpleButton();
            this.btn_ok = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txt_ucret.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // groupControl1
            // 
            this.groupControl1.AppearanceCaption.Font = new System.Drawing.Font("Tahoma", 12F);
            this.groupControl1.AppearanceCaption.Options.UseFont = true;
            this.groupControl1.CaptionImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("groupControl1.CaptionImageOptions.Image")));
            this.groupControl1.Controls.Add(this.label5);
            this.groupControl1.Controls.Add(this.richTextBox1);
            this.groupControl1.Controls.Add(this.txt_taksit);
            this.groupControl1.Controls.Add(this.label4);
            this.groupControl1.Controls.Add(this.txt_adiSoyadi);
            this.groupControl1.Controls.Add(this.label10);
            this.groupControl1.Controls.Add(this.panel1);
            this.groupControl1.Controls.Add(this.label3);
            this.groupControl1.Controls.Add(this.label2);
            this.groupControl1.Controls.Add(this.txt_ucret);
            this.groupControl1.Controls.Add(this.txt_odemeTarihi);
            this.groupControl1.Controls.Add(this.cmbx_odemeTurleri);
            this.groupControl1.Controls.Add(this.label1);
            this.groupControl1.Location = new System.Drawing.Point(12, 12);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(341, 356);
            this.groupControl1.TabIndex = 0;
            this.groupControl1.Text = "Ödeme Bilgileri";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(95, 247);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(178, 20);
            this.label5.TabIndex = 16;
            this.label5.Text = "Ödeme ile ilgili açıklama:";
            // 
            // richTextBox1
            // 
            this.richTextBox1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.richTextBox1.Font = new System.Drawing.Font("Tahoma", 11F);
            this.richTextBox1.Location = new System.Drawing.Point(5, 269);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(331, 76);
            this.richTextBox1.TabIndex = 15;
            this.richTextBox1.Text = "";
            // 
            // txt_taksit
            // 
            this.txt_taksit.Font = new System.Drawing.Font("Tahoma", 12F);
            this.txt_taksit.Location = new System.Drawing.Point(132, 108);
            this.txt_taksit.Name = "txt_taksit";
            this.txt_taksit.ReadOnly = true;
            this.txt_taksit.Size = new System.Drawing.Size(181, 27);
            this.txt_taksit.TabIndex = 14;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(26, 111);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(100, 20);
            this.label4.TabIndex = 13;
            this.label4.Text = "Taksit Sayısı:";
            // 
            // txt_adiSoyadi
            // 
            this.txt_adiSoyadi.Font = new System.Drawing.Font("Tahoma", 12F);
            this.txt_adiSoyadi.Location = new System.Drawing.Point(132, 42);
            this.txt_adiSoyadi.Name = "txt_adiSoyadi";
            this.txt_adiSoyadi.ReadOnly = true;
            this.txt_adiSoyadi.Size = new System.Drawing.Size(181, 27);
            this.txt_adiSoyadi.TabIndex = 12;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label10.Location = new System.Drawing.Point(38, 45);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(88, 20);
            this.label10.TabIndex = 11;
            this.label10.Text = "Adı Soyadı:";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Cornsilk;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Location = new System.Drawing.Point(23, 208);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(290, 24);
            this.panel1.TabIndex = 10;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.Location = new System.Drawing.Point(179, 1);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(53, 20);
            this.label6.TabIndex = 8;
            this.label6.Text = "0,00 ₺";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.Location = new System.Drawing.Point(-2, 1);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(110, 20);
            this.label7.TabIndex = 7;
            this.label7.Text = "Kalacak Tutar:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(19, 178);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(107, 20);
            this.label3.TabIndex = 9;
            this.label3.Text = "Ödeme Tarihi:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(76, 149);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 20);
            this.label2.TabIndex = 8;
            this.label2.Text = "Tutar:";
            // 
            // txt_ucret
            // 
            this.txt_ucret.EditValue = "";
            this.txt_ucret.Location = new System.Drawing.Point(132, 141);
            this.txt_ucret.Name = "txt_ucret";
            this.txt_ucret.Properties.Appearance.BackColor = System.Drawing.Color.White;
            this.txt_ucret.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 12F);
            this.txt_ucret.Properties.Appearance.Options.UseBackColor = true;
            this.txt_ucret.Properties.Appearance.Options.UseFont = true;
            this.txt_ucret.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Style3D;
            this.txt_ucret.Properties.ContextImageOptions.Alignment = DevExpress.XtraEditors.ContextImageAlignment.Far;
            this.txt_ucret.Properties.ContextImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("txt_ucret.Properties.ContextImageOptions.Image")));
            this.txt_ucret.Size = new System.Drawing.Size(181, 28);
            this.txt_ucret.TabIndex = 6;
            this.txt_ucret.EditValueChanged += new System.EventHandler(this.txt_ucret_EditValueChanged);
            this.txt_ucret.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_ucret_KeyPress);
            // 
            // txt_odemeTarihi
            // 
            this.txt_odemeTarihi.Font = new System.Drawing.Font("Tahoma", 12F);
            this.txt_odemeTarihi.Location = new System.Drawing.Point(132, 175);
            this.txt_odemeTarihi.Mask = "00/00/0000";
            this.txt_odemeTarihi.Name = "txt_odemeTarihi";
            this.txt_odemeTarihi.Size = new System.Drawing.Size(181, 27);
            this.txt_odemeTarihi.TabIndex = 7;
            // 
            // cmbx_odemeTurleri
            // 
            this.cmbx_odemeTurleri.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbx_odemeTurleri.Font = new System.Drawing.Font("Tahoma", 12F);
            this.cmbx_odemeTurleri.FormattingEnabled = true;
            this.cmbx_odemeTurleri.Location = new System.Drawing.Point(132, 75);
            this.cmbx_odemeTurleri.Name = "cmbx_odemeTurleri";
            this.cmbx_odemeTurleri.Size = new System.Drawing.Size(181, 27);
            this.cmbx_odemeTurleri.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(25, 78);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "Ödeme Türü:";
            // 
            // btn_cancel
            // 
            this.btn_cancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btn_cancel.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btn_cancel.ImageOptions.Image")));
            this.btn_cancel.Location = new System.Drawing.Point(12, 374);
            this.btn_cancel.Name = "btn_cancel";
            this.btn_cancel.Size = new System.Drawing.Size(42, 39);
            this.btn_cancel.TabIndex = 4;
            this.btn_cancel.Click += new System.EventHandler(this.btn_cancel_Click);
            // 
            // btn_ok
            // 
            this.btn_ok.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btn_ok.ImageOptions.Image")));
            this.btn_ok.Location = new System.Drawing.Point(311, 374);
            this.btn_ok.Name = "btn_ok";
            this.btn_ok.Size = new System.Drawing.Size(42, 39);
            this.btn_ok.TabIndex = 3;
            this.btn_ok.Click += new System.EventHandler(this.btn_ok_Click);
            // 
            // frmTahsilEt
            // 
            this.AcceptButton = this.btn_ok;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btn_cancel;
            this.ClientSize = new System.Drawing.Size(365, 425);
            this.Controls.Add(this.btn_cancel);
            this.Controls.Add(this.btn_ok);
            this.Controls.Add(this.groupControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmTahsilEt";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ödeme Tahsil Et";
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.groupControl1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txt_ucret.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.GroupControl groupControl1;
        private System.Windows.Forms.ComboBox cmbx_odemeTurleri;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private DevExpress.XtraEditors.TextEdit txt_ucret;
        private System.Windows.Forms.MaskedTextBox txt_odemeTarihi;
        private DevExpress.XtraEditors.SimpleButton btn_cancel;
        private DevExpress.XtraEditors.SimpleButton btn_ok;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txt_adiSoyadi;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txt_taksit;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.RichTextBox richTextBox1;
    }
}