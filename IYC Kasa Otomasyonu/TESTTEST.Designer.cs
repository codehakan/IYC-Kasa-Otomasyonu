namespace IYC_Kasa_Otomasyonu
{
    partial class TESTTEST
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
            this.btn_excell = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_excell
            // 
            this.btn_excell.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_excell.Location = new System.Drawing.Point(112, 127);
            this.btn_excell.Name = "btn_excell";
            this.btn_excell.Size = new System.Drawing.Size(540, 126);
            this.btn_excell.TabIndex = 0;
            this.btn_excell.Text = "Excell Aktar";
            this.btn_excell.UseVisualStyleBackColor = true;
            this.btn_excell.Click += new System.EventHandler(this.btn_excell_Click);
            // 
            // TESTTEST
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_excell);
            this.Name = "TESTTEST";
            this.Text = "TESTTEST";
            this.Load += new System.EventHandler(this.TESTTEST_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_excell;
    }
}