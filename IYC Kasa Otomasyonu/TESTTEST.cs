using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Excel = Microsoft.Office.Interop.Excel;


namespace IYC_Kasa_Otomasyonu
{
    public partial class TESTTEST : Form
    {
        public TESTTEST()
        {
            InitializeComponent();
        }



        private void TESTTEST_Load(object sender, EventArgs e)
        {

        }

        private void btn_excell_Click(object sender, EventArgs e)
        {
            Excel.Application xlApp = new Excel.Application();
            xlApp.Visible = true;
            xlApp.DisplayAlerts = true;

            Excel.Workbook wb = xlApp.Workbooks.Add(Excel.XlWBATemplate.xlWBATWorksheet);
            Excel.Worksheet ws = (Excel.Worksheet)wb.Sheets[1];
            string ad = "Hakan AKKAYA";
            string tc = "48406182272";
            string tarih = "18/07/1996";
            ws.Range[ws.Cells[12, 1], ws.Cells[12, 4]].Merge();
            ws.Range[ws.Cells[13, 1], ws.Cells[13, 4]].Merge();
            ws.Range[ws.Cells[22, 2], ws.Cells[22, 3]].Merge();
            ws.Range[ws.Cells[35, 7], ws.Cells[35, 8]].Merge();
            ws.Range[ws.Cells[36, 3], ws.Cells[36, 9]].Merge();
            //ws.Range[ws.Cells[40, 2], ws.Cells[40, 4]].Merge();
            ws.Cells[12, 1] = ad;
            ws.Cells[12, 1].Font.Bold = true;
            ws.Cells[12, 1].Font.Size = 14;
            ws.Cells[12, 1].HorizontalAlignment = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignCenter;
            ws.Cells[13, 1] = tc;
            ws.Cells[13, 1].Font.Bold = true;
            ws.Cells[13, 1].Font.Size = 14;
            ws.Cells[13, 1].HorizontalAlignment = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignCenter;
            ws.Cells[12, 10] = tarih;
            ws.Cells[12, 10].Font.Bold = true;
            ws.Cells[12, 10].Font.Size = 10;
            ws.Cells[12, 10].HorizontalAlignment = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignRight;
            ws.Cells[22, 5] = "YURT HİZMETİ";
            ws.Cells[22, 5].Font.Bold = true;
            ws.Cells[22, 5].Font.Size = 10;
            ws.Cells[22, 5].HorizontalAlignment = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignCenter;
            ws.Cells[22, 10] = "600,00";
            ws.Cells[22, 10].Font.Bold = true;
            ws.Cells[22, 10].Font.Size = 10;
            ws.Cells[22, 10].HorizontalAlignment = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignRight;
            ws.Cells[35, 9] = "TOPLAM";
            ws.Cells[35, 9].Font.Bold = true;
            ws.Cells[35, 9].Font.Size = 10;
            ws.Cells[35, 9].HorizontalAlignment = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignRight;
            ws.Cells[35, 10] = "600,00";
            ws.Cells[35, 10].Font.Bold = true;
            ws.Cells[35, 10].Font.Size = 10;
            ws.Cells[35, 10].HorizontalAlignment = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignRight;
            ws.Cells[37, 9] = "YEKÜN";
            ws.Cells[37, 9].Font.Bold = true;
            ws.Cells[37, 9].Font.Size = 10;
            ws.Cells[37, 9].HorizontalAlignment = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignRight;
            ws.Cells[37, 10] = "600,00";
            ws.Cells[37, 10].Font.Bold = true;
            ws.Cells[37, 10].Font.Size = 10;
            ws.Cells[37, 10].HorizontalAlignment = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignRight;
            ws.Cells[40, 4] = "altıyüztl";
            ws.Cells[40, 4].Font.Bold = true;
            ws.Cells[40, 4].Font.Size = 10;
            ws.Cells[40, 4].HorizontalAlignment = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignRight;
            ws.Cells[36, 3] = "3065 sayılı KDV Kanunun 17/2-a maddesi uyarınca istisna uygulanmıştır";
            ws.Cells[36, 3].Font.Bold = true;
            ws.Cells[36, 3].Font.Size = 10;
            












            
            this.Close();
        }

    }
}
