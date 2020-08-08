namespace IYC_Kasa_Otomasyonu
{
    partial class frmRaporlama
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
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.reportViewer2 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.kasa_otomasyonuDataSet11 = new IYC_Kasa_Otomasyonu.kasa_otomasyonuDataSet1();
            this.kasaotomasyonuDataSet11BindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.kasa_otomasyonuDataSet11)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kasaotomasyonuDataSet11BindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer2
            // 
            this.reportViewer2.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSet2";
            reportDataSource1.Value = this.kasaotomasyonuDataSet11BindingSource;
            this.reportViewer2.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer2.LocalReport.ReportEmbeddedResource = "IYC_Kasa_Otomasyonu.Report2.rdlc";
            this.reportViewer2.Location = new System.Drawing.Point(0, 0);
            this.reportViewer2.Name = "reportViewer2";
            this.reportViewer2.ServerReport.BearerToken = null;
            this.reportViewer2.Size = new System.Drawing.Size(1037, 441);
            this.reportViewer2.TabIndex = 0;
            // 
            // kasa_otomasyonuDataSet11
            // 
            ///////////this.kasa_otomasyonuDataSet11.DataSetName = "kasa_otomasyonuDataSet1";
            ///////////this.kasa_otomasyonuDataSet11.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // kasaotomasyonuDataSet11BindingSource
            // 
            this.kasaotomasyonuDataSet11BindingSource.DataSource = this.kasa_otomasyonuDataSet11;
            this.kasaotomasyonuDataSet11BindingSource.Position = 0;
            // 
            // frmRaporlama
            // 
            this.ClientSize = new System.Drawing.Size(1037, 441);
            this.Controls.Add(this.reportViewer2);
            this.Name = "frmRaporlama";
            this.Load += new System.EventHandler(this.frmRaporlama_Load_1);
            ((System.ComponentModel.ISupportInitialize)(this.kasa_otomasyonuDataSet11)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kasaotomasyonuDataSet11BindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.ComboBox cmx_isim;
        private System.Windows.Forms.BindingSource ogrenciBilgileriBindingSource;
        private kasa_otomasyonuDataSet1 kasa_otomasyonuDataSet1;
        private System.Windows.Forms.BindingSource odemeYapanlarBindingSource;
        /////////////private kasa_otomasyonuDataSet1TableAdapters.ogrenciBilgileriTableAdapter ogrenciBilgileriTableAdapter;
        private kasa_otomasyonuDataSet1TableAdapters.odemeYapanlarTableAdapter odemeYapanlarTableAdapter;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer2;
        private System.Windows.Forms.BindingSource kasaotomasyonuDataSet11BindingSource;
        private kasa_otomasyonuDataSet1 kasa_otomasyonuDataSet11;
    }
}