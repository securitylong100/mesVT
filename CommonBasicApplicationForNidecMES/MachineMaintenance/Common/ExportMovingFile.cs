using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Excel = Microsoft.Office.Interop.Excel;
using System.Data;
using System.ComponentModel;
using System.IO;
using System.Windows.Forms;
using Com.Nidec.Mes.Framework;

namespace Com.Nidec.Mes.Common.Basic.MachineMaintenance.Common
{
    public class ExportMovingFile
    {
        public void exportmoving(ref DataGridViewCommon dgv, string codestatus)
        {
            string datetime = DateTime.Now.ToString("yyyy_mm_dd");
            try
            {
                Excel.Application xlApp;
                Excel.Workbook xlWorkBook;
                Excel.Worksheet xlWorkSheet; //sheet 2
                object misValue = System.Reflection.Missing.Value;
                xlApp = new Excel.Application();
                xlWorkBook = xlApp.Workbooks.Open(@"D:\VT CP\ExportMoving.xlsx", 0, true, 5, "", "", true, Microsoft.Office.Interop.Excel.XlPlatform.xlWindows, "\t", false, false, 0, true, 1, 0);
                xlWorkSheet = (Excel.Worksheet)xlWorkBook.Worksheets.get_Item(1); //add data sheet1
                #region codeName
                if (codestatus == "Bàn Giao")
                {
                    xlWorkSheet.Cells[2, 3] = dgv.Rows[0].Cells["col_code_name"].Value.ToString() + "BG/CĐ";
                    xlWorkSheet.Cells[6, 6] = "X";
                }
                if (codestatus == "Mượn")
                {
                    xlWorkSheet.Cells[2, 3] = dgv.Rows[0].Cells["col_code_name"].Value.ToString() + "M/CĐ";
                    xlWorkSheet.Cells[6, 14] = "X";
                }
                if (codestatus == "Trả")
                {
                    xlWorkSheet.Cells[2, 3] = dgv.Rows[0].Cells["col_code_name"].Value.ToString() + "T/CĐ";
                    xlWorkSheet.Cells[6, 22] = "X";
                }
                if (codestatus == "Thuê")
                {
                    xlWorkSheet.Cells[2, 3] = dgv.Rows[0].Cells["col_code_name"].Value.ToString() + "TH/CĐ";
                    xlWorkSheet.Cells[6, 30] = "X";
                }
                #endregion
                #region factory and reason
                xlWorkSheet.Cells[9, 6] = dgv.Rows[0].Cells["col_reason_tranfer"].Value.ToString();
                xlWorkSheet.Cells[11, 8] = dgv.Rows[0].Cells["col_factory_tranfer_cd"].Value.ToString();
                xlWorkSheet.Cells[11, 29] = dgv.Rows[0].Cells["col_factory_received_cd"].Value.ToString();
                #endregion
                #region tableform
                //số thứ tự
                for (int i = 0; i < dgv.RowCount; i++)
                {
                    xlWorkSheet.Cells[i + 15, 1] = i + 1;
                    xlWorkSheet.Cells[i + 15, 3] = dgv.Rows[i].Cells["col_machine_name"].Value.ToString();
                    xlWorkSheet.Cells[i + 15, 17] = dgv.Rows[i].Cells["col_machine_model"].Value.ToString();
                    xlWorkSheet.Cells[i + 15, 23] = dgv.Rows[i].Cells["col_machine_serial"].Value.ToString();
                    xlWorkSheet.Cells[i + 15, 28] = dgv.Rows[i].Cells["col_machine_costvalue"].Value.ToString();
                    xlWorkSheet.Cells[i + 15, 32] = dgv.Rows[i].Cells["col_comments_machine"].Value.ToString();
                }
                #endregion
                #region confirm received and register date time format form
                xlWorkSheet.Cells[46, 7] = dgv.Rows[0].Cells["col_confirm_received"].Value.ToString();
                xlWorkSheet.Cells[49, 25] = dgv.Rows[0].Cells["col_registration_date_time"].Value.ToString().Substring(8, 2); //day
                xlWorkSheet.Cells[49, 29] = dgv.Rows[0].Cells["col_registration_date_time"].Value.ToString().Substring(5, 2); //month
                xlWorkSheet.Cells[49, 33] = dgv.Rows[0].Cells["col_registration_date_time"].Value.ToString().Substring(0, 4); //year
                #endregion

                xlWorkBook.SaveAs("D:\\VT CP\\ExportMoving_" + datetime + ".xlsx", Excel.XlFileFormat.xlWorkbookDefault, misValue, misValue, misValue,
                 misValue, Excel.XlSaveAsAccessMode.xlExclusive, misValue, misValue, misValue, misValue, misValue);
                MessageBox.Show("Excel file created, you can find in the folder D:\\VT CP", "Notice", MessageBoxButtons.OK, MessageBoxIcon.Information);
                xlWorkBook.Close(true, misValue, misValue);
                xlApp.Workbooks.Open("D:\\VT CP\\ExportMoving_" + datetime + ".xlsx");
                xlApp.Visible = true;
            }
            catch
            {
                MessageBox.Show("ERROR. Please create folder file ");
                return;

            }
        }
    }
}
