namespace IYC_Kasa_Otomasyonu
{
    partial class frmOdemesiGecenler
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmOdemesiGecenler));
            this.data_odemesiGecikenler = new System.Windows.Forms.DataGridView();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.btn_herkeseGonder = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.data_odemesiGecikenler)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // data_odemesiGecikenler
            // 
            this.data_odemesiGecikenler.AllowUserToAddRows = false;
            this.data_odemesiGecikenler.AllowUserToDeleteRows = false;
            this.data_odemesiGecikenler.BackgroundColor = System.Drawing.SystemColors.Control;
            this.data_odemesiGecikenler.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.data_odemesiGecikenler.Location = new System.Drawing.Point(298, 12);
            this.data_odemesiGecikenler.MultiSelect = false;
            this.data_odemesiGecikenler.Name = "data_odemesiGecikenler";
            this.data_odemesiGecikenler.ReadOnly = true;
            this.data_odemesiGecikenler.RowHeadersWidth = 9;
            this.data_odemesiGecikenler.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.data_odemesiGecikenler.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.data_odemesiGecikenler.Size = new System.Drawing.Size(545, 404);
            this.data_odemesiGecikenler.TabIndex = 0;
            this.data_odemesiGecikenler.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.data_odemesiGecikenler_CellClick);
            // 
            // groupControl1
            // 
            this.groupControl1.AppearanceCaption.Font = new System.Drawing.Font("Tahoma", 12F);
            this.groupControl1.AppearanceCaption.Options.UseFont = true;
            this.groupControl1.CaptionImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("groupControl1.CaptionImageOptions.Image")));
            this.groupControl1.Controls.Add(this.richTextBox1);
            this.groupControl1.Location = new System.Drawing.Point(12, 12);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(280, 352);
            this.groupControl1.TabIndex = 1;
            this.groupControl1.Text = "Gönderim Bilgileri";
            // 
            // richTextBox1
            // 
            this.richTextBox1.BackColor = System.Drawing.SystemColors.Control;
            this.richTextBox1.Font = new System.Drawing.Font("Tahoma", 14F);
            this.richTextBox1.Location = new System.Drawing.Point(5, 42);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.ReadOnly = true;
            this.richTextBox1.Size = new System.Drawing.Size(270, 305);
            this.richTextBox1.TabIndex = 0;
            this.richTextBox1.Text = "";
            // 
            // btn_herkeseGonder
            // 
            this.btn_herkeseGonder.Appearance.Font = new System.Drawing.Font("Tahoma", 12F);
            this.btn_herkeseGonder.Appearance.Options.UseFont = true;
            this.btn_herkeseGonder.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Office2003;
            this.btn_herkeseGonder.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("simpleButton1.ImageOptions.Image")));
            this.btn_herkeseGonder.Location = new System.Drawing.Point(17, 370);
            this.btn_herkeseGonder.Name = "btn_herkeseGonder";
            this.btn_herkeseGonder.Size = new System.Drawing.Size(270, 46);
            this.btn_herkeseGonder.TabIndex = 2;
            this.btn_herkeseGonder.Text = "Ödemesi Gelen Herkese Gönder";
            this.btn_herkeseGonder.Click += new System.EventHandler(this.btn_herkeseGonder_Click);
            // 
            // frmOdemesiGecenler
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(855, 428);
            this.Controls.Add(this.btn_herkeseGonder);
            this.Controls.Add(this.groupControl1);
            this.Controls.Add(this.data_odemesiGecikenler);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmOdemesiGecenler";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ödemesi Geciken Öğrenci Listesi";
            this.Load += new System.EventHandler(this.frmOdemesiGecenler_Load);
            ((System.ComponentModel.ISupportInitialize)(this.data_odemesiGecikenler)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView data_odemesiGecikenler;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private DevExpress.XtraEditors.SimpleButton btn_herkeseGonder;
    }
}