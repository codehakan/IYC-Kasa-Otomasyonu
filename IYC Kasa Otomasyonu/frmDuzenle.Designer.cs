namespace IYC_Kasa_Otomasyonu
{
    partial class frmDuzenle
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmDuzenle));
            this.btn_iptal = new DevExpress.XtraEditors.SimpleButton();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_depozito = new DevExpress.XtraEditors.TextEdit();
            this.txt_taksit = new DevExpress.XtraEditors.TextEdit();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_ucret = new DevExpress.XtraEditors.TextEdit();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbx_donem = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_telefon = new System.Windows.Forms.MaskedTextBox();
            this.txt_kayittarihi = new System.Windows.Forms.MaskedTextBox();
            this.txt_tcno = new System.Windows.Forms.MaskedTextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.txt_adiSoyadi = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.btn_duzenle = new DevExpress.XtraEditors.SimpleButton();
            this.groupControl2 = new DevExpress.XtraEditors.GroupControl();
            ((System.ComponentModel.ISupportInitialize)(this.txt_depozito.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_taksit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_ucret.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).BeginInit();
            this.groupControl2.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_iptal
            // 
            this.btn_iptal.Appearance.Font = new System.Drawing.Font("Tahoma", 10F);
            this.btn_iptal.Appearance.Options.UseFont = true;
            this.btn_iptal.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Office2003;
            this.btn_iptal.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btn_iptal.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btn_iptal.ImageOptions.Image")));
            this.btn_iptal.Location = new System.Drawing.Point(11, 287);
            this.btn_iptal.Name = "btn_iptal";
            this.btn_iptal.Size = new System.Drawing.Size(93, 43);
            this.btn_iptal.TabIndex = 9;
            this.btn_iptal.Text = "İptal";
            this.btn_iptal.Click += new System.EventHandler(this.btn_iptal_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(37, 237);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(68, 17);
            this.label4.TabIndex = 12;
            this.label4.Text = "Depozito:";
            // 
            // txt_depozito
            // 
            this.txt_depozito.EditValue = "300";
            this.txt_depozito.Location = new System.Drawing.Point(111, 233);
            this.txt_depozito.Name = "txt_depozito";
            this.txt_depozito.Properties.Appearance.BackColor = System.Drawing.Color.White;
            this.txt_depozito.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 10F);
            this.txt_depozito.Properties.Appearance.Options.UseBackColor = true;
            this.txt_depozito.Properties.Appearance.Options.UseFont = true;
            this.txt_depozito.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Style3D;
            this.txt_depozito.Properties.ContextImageOptions.Alignment = DevExpress.XtraEditors.ContextImageAlignment.Far;
            this.txt_depozito.Properties.ContextImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("txt_depozito.Properties.ContextImageOptions.Image")));
            this.txt_depozito.Properties.MaxLength = 5;
            this.txt_depozito.Size = new System.Drawing.Size(174, 24);
            this.txt_depozito.TabIndex = 11;
            // 
            // txt_taksit
            // 
            this.txt_taksit.EditValue = "10";
            this.txt_taksit.Location = new System.Drawing.Point(110, 203);
            this.txt_taksit.Name = "txt_taksit";
            this.txt_taksit.Properties.Appearance.BackColor = System.Drawing.Color.White;
            this.txt_taksit.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 10F);
            this.txt_taksit.Properties.Appearance.Options.UseBackColor = true;
            this.txt_taksit.Properties.Appearance.Options.UseFont = true;
            this.txt_taksit.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Style3D;
            this.txt_taksit.Properties.ContextImageOptions.Alignment = DevExpress.XtraEditors.ContextImageAlignment.Far;
            this.txt_taksit.Properties.ContextImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("txt_taksit.Properties.ContextImageOptions.Image")));
            this.txt_taksit.Properties.MaxLength = 3;
            this.txt_taksit.Size = new System.Drawing.Size(174, 24);
            this.txt_taksit.TabIndex = 10;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(54, 207);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 17);
            this.label3.TabIndex = 9;
            this.label3.Text = "Taksit:";
            // 
            // txt_ucret
            // 
            this.txt_ucret.EditValue = "5750";
            this.txt_ucret.Location = new System.Drawing.Point(111, 173);
            this.txt_ucret.Name = "txt_ucret";
            this.txt_ucret.Properties.Appearance.BackColor = System.Drawing.Color.White;
            this.txt_ucret.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 10F);
            this.txt_ucret.Properties.Appearance.Options.UseBackColor = true;
            this.txt_ucret.Properties.Appearance.Options.UseFont = true;
            this.txt_ucret.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Style3D;
            this.txt_ucret.Properties.ContextImageOptions.Alignment = DevExpress.XtraEditors.ContextImageAlignment.Far;
            this.txt_ucret.Properties.ContextImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("txt_ucret.Properties.ContextImageOptions.Image")));
            this.txt_ucret.Properties.MaxLength = 5;
            this.txt_ucret.Size = new System.Drawing.Size(174, 24);
            this.txt_ucret.TabIndex = 8;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(25, 177);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 17);
            this.label2.TabIndex = 7;
            this.label2.Text = "Kayıt Fiyatı:";
            // 
            // cmbx_donem
            // 
            this.cmbx_donem.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbx_donem.Font = new System.Drawing.Font("Tahoma", 10F);
            this.cmbx_donem.FormattingEnabled = true;
            this.cmbx_donem.Location = new System.Drawing.Point(110, 143);
            this.cmbx_donem.Name = "cmbx_donem";
            this.cmbx_donem.Size = new System.Drawing.Size(175, 24);
            this.cmbx_donem.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(44, 146);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 17);
            this.label1.TabIndex = 5;
            this.label1.Text = "Dönemi:";
            // 
            // txt_telefon
            // 
            this.txt_telefon.Font = new System.Drawing.Font("Tahoma", 10F);
            this.txt_telefon.Location = new System.Drawing.Point(110, 113);
            this.txt_telefon.Mask = "(999) 000-0000";
            this.txt_telefon.Name = "txt_telefon";
            this.txt_telefon.Size = new System.Drawing.Size(175, 24);
            this.txt_telefon.TabIndex = 4;
            // 
            // txt_kayittarihi
            // 
            this.txt_kayittarihi.Font = new System.Drawing.Font("Tahoma", 10F);
            this.txt_kayittarihi.Location = new System.Drawing.Point(110, 83);
            this.txt_kayittarihi.Mask = "00/00/0000";
            this.txt_kayittarihi.Name = "txt_kayittarihi";
            this.txt_kayittarihi.Size = new System.Drawing.Size(175, 24);
            this.txt_kayittarihi.TabIndex = 3;
            // 
            // txt_tcno
            // 
            this.txt_tcno.Font = new System.Drawing.Font("Tahoma", 10F);
            this.txt_tcno.Location = new System.Drawing.Point(110, 53);
            this.txt_tcno.Mask = "00000000000";
            this.txt_tcno.Name = "txt_tcno";
            this.txt_tcno.Size = new System.Drawing.Size(175, 24);
            this.txt_tcno.TabIndex = 2;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label13.Location = new System.Drawing.Point(44, 116);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(60, 17);
            this.label13.TabIndex = 3;
            this.label13.Text = "Telefon:";
            // 
            // txt_adiSoyadi
            // 
            this.txt_adiSoyadi.Font = new System.Drawing.Font("Tahoma", 10F);
            this.txt_adiSoyadi.Location = new System.Drawing.Point(110, 23);
            this.txt_adiSoyadi.MaxLength = 50;
            this.txt_adiSoyadi.Name = "txt_adiSoyadi";
            this.txt_adiSoyadi.Size = new System.Drawing.Size(175, 24);
            this.txt_adiSoyadi.TabIndex = 1;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label12.Location = new System.Drawing.Point(21, 86);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(83, 17);
            this.label12.TabIndex = 3;
            this.label12.Text = "Kayıt Tarihi:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label11.Location = new System.Drawing.Point(30, 56);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(74, 17);
            this.label11.TabIndex = 2;
            this.label11.Text = "T.C Kimlik:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label10.Location = new System.Drawing.Point(25, 26);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(79, 17);
            this.label10.TabIndex = 1;
            this.label10.Text = "Adı Soyadı:";
            // 
            // btn_duzenle
            // 
            this.btn_duzenle.Appearance.Font = new System.Drawing.Font("Tahoma", 10F);
            this.btn_duzenle.Appearance.Options.UseFont = true;
            this.btn_duzenle.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Office2003;
            this.btn_duzenle.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btn_duzenle.ImageOptions.Image")));
            this.btn_duzenle.Location = new System.Drawing.Point(225, 287);
            this.btn_duzenle.Name = "btn_duzenle";
            this.btn_duzenle.Size = new System.Drawing.Size(93, 43);
            this.btn_duzenle.TabIndex = 8;
            this.btn_duzenle.Text = "Düzenle";
            this.btn_duzenle.Click += new System.EventHandler(this.btn_duzenle_Click);
            // 
            // groupControl2
            // 
            this.groupControl2.Controls.Add(this.label4);
            this.groupControl2.Controls.Add(this.txt_depozito);
            this.groupControl2.Controls.Add(this.txt_taksit);
            this.groupControl2.Controls.Add(this.label3);
            this.groupControl2.Controls.Add(this.txt_ucret);
            this.groupControl2.Controls.Add(this.label2);
            this.groupControl2.Controls.Add(this.cmbx_donem);
            this.groupControl2.Controls.Add(this.label1);
            this.groupControl2.Controls.Add(this.txt_telefon);
            this.groupControl2.Controls.Add(this.txt_kayittarihi);
            this.groupControl2.Controls.Add(this.txt_tcno);
            this.groupControl2.Controls.Add(this.label13);
            this.groupControl2.Controls.Add(this.txt_adiSoyadi);
            this.groupControl2.Controls.Add(this.label12);
            this.groupControl2.Controls.Add(this.label11);
            this.groupControl2.Controls.Add(this.label10);
            this.groupControl2.Location = new System.Drawing.Point(11, 11);
            this.groupControl2.Name = "groupControl2";
            this.groupControl2.Size = new System.Drawing.Size(307, 270);
            this.groupControl2.TabIndex = 7;
            this.groupControl2.Text = "Öğrenci Bilgileri";
            // 
            // frmDuzenle
            // 
            this.AcceptButton = this.btn_duzenle;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btn_iptal;
            this.ClientSize = new System.Drawing.Size(329, 340);
            this.Controls.Add(this.btn_iptal);
            this.Controls.Add(this.btn_duzenle);
            this.Controls.Add(this.groupControl2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmDuzenle";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Öğrenci Düzenle";
            ((System.ComponentModel.ISupportInitialize)(this.txt_depozito.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_taksit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_ucret.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).EndInit();
            this.groupControl2.ResumeLayout(false);
            this.groupControl2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.SimpleButton btn_iptal;
        private System.Windows.Forms.Label label4;
        private DevExpress.XtraEditors.TextEdit txt_depozito;
        private DevExpress.XtraEditors.TextEdit txt_taksit;
        private System.Windows.Forms.Label label3;
        private DevExpress.XtraEditors.TextEdit txt_ucret;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmbx_donem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MaskedTextBox txt_telefon;
        private System.Windows.Forms.MaskedTextBox txt_kayittarihi;
        private System.Windows.Forms.MaskedTextBox txt_tcno;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txt_adiSoyadi;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private DevExpress.XtraEditors.SimpleButton btn_duzenle;
        private DevExpress.XtraEditors.GroupControl groupControl2;
    }
}