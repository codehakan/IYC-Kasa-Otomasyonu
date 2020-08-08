namespace IYC_Kasa_Otomasyonu
{
    partial class tutarBelirle
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
            this.txt_ucret = new System.Windows.Forms.TextBox();
            this.txt_ucret_yazi = new System.Windows.Forms.TextBox();
            this.btn_okay = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_tarih = new System.Windows.Forms.MaskedTextBox();
            this.SuspendLayout();
            // 
            // txt_ucret
            // 
            this.txt_ucret.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txt_ucret.Location = new System.Drawing.Point(81, 11);
            this.txt_ucret.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txt_ucret.Multiline = true;
            this.txt_ucret.Name = "txt_ucret";
            this.txt_ucret.Size = new System.Drawing.Size(332, 28);
            this.txt_ucret.TabIndex = 0;
            this.txt_ucret.TextChanged += new System.EventHandler(this.txt_ucret_TextChanged);
            this.txt_ucret.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_ucret_KeyPress);
            // 
            // txt_ucret_yazi
            // 
            this.txt_ucret_yazi.Enabled = false;
            this.txt_ucret_yazi.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txt_ucret_yazi.Location = new System.Drawing.Point(81, 42);
            this.txt_ucret_yazi.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txt_ucret_yazi.Multiline = true;
            this.txt_ucret_yazi.Name = "txt_ucret_yazi";
            this.txt_ucret_yazi.ReadOnly = true;
            this.txt_ucret_yazi.Size = new System.Drawing.Size(332, 28);
            this.txt_ucret_yazi.TabIndex = 0;
            // 
            // btn_okay
            // 
            this.btn_okay.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_okay.Location = new System.Drawing.Point(82, 106);
            this.btn_okay.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btn_okay.Name = "btn_okay";
            this.btn_okay.Size = new System.Drawing.Size(332, 36);
            this.btn_okay.TabIndex = 2;
            this.btn_okay.Text = "TAMAM";
            this.btn_okay.UseVisualStyleBackColor = true;
            this.btn_okay.Click += new System.EventHandler(this.btn_okay_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(9, 13);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 22);
            this.label1.TabIndex = 4;
            this.label1.Text = "Tutar:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(10, 76);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 22);
            this.label2.TabIndex = 5;
            this.label2.Text = "Tarih:";
            // 
            // txt_tarih
            // 
            this.txt_tarih.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txt_tarih.Location = new System.Drawing.Point(81, 74);
            this.txt_tarih.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txt_tarih.Mask = "00/00/0000";
            this.txt_tarih.Name = "txt_tarih";
            this.txt_tarih.Size = new System.Drawing.Size(332, 27);
            this.txt_tarih.TabIndex = 1;
            this.txt_tarih.ValidatingType = typeof(System.DateTime);
            // 
            // tutarBelirle
            // 
            this.AcceptButton = this.btn_okay;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(432, 151);
            this.Controls.Add(this.txt_tarih);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_okay);
            this.Controls.Add(this.txt_ucret_yazi);
            this.Controls.Add(this.txt_ucret);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "tutarBelirle";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "tutarBelirle";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_ucret;
        private System.Windows.Forms.TextBox txt_ucret_yazi;
        private System.Windows.Forms.Button btn_okay;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.MaskedTextBox txt_tarih;
    }
}