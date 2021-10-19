using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Office.Interop.Excel;

namespace QLSV.BUS
{
    class XuatExcel
    {
        public XuatExcel()
        {

        }

        public void XuatFileExcelBangDiem(DataGridView dg, string fileName, string tieuDe)
        {
            Microsoft.Office.Interop.Excel.Application excel;
            Microsoft.Office.Interop.Excel.Workbook workbook;
            Microsoft.Office.Interop.Excel.Worksheet worksheet;



            try
            {
                excel = new Microsoft.Office.Interop.Excel.Application();
                excel.Visible = false;
                excel.DisplayAlerts = false;

                workbook = excel.Workbooks.Add(Type.Missing);

                worksheet = (Microsoft.Office.Interop.Excel.Worksheet)workbook.Sheets["Sheet1"];
                worksheet.Name = "Bảng Điểm";
                Range range;

                // export tiêu đề

                worksheet.Cells[1, 1] = tieuDe;
                worksheet.Range["A1:E1"].Merge();

                // export header
                for (int i = 0; i < dg.ColumnCount; i++)
                {
                    worksheet.Columns[i+1].AutoFit();
                    worksheet.Cells[2, i + 1] = dg.Columns[i].HeaderText;
                    range = worksheet.Cells[2, i + 1];
                    Borders borders = range.Borders;

                    //Set the hair lines style
                    borders.LineStyle = XlLineStyle.xlContinuous;
                    borders.Weight = 3d;

                }

                // export content
                for (int i = 0; i < dg.RowCount; i++)
                {
                    for (int j = 0; j < dg.ColumnCount; j++)
                    {

                        worksheet.Cells[i + 3, j + 1] = dg.Rows[i].Cells[j].Value.ToString();
                        range = worksheet.Cells[i + 3, j + 1];
                        Borders borders = range.Borders;

                        //Set the hair lines style
                        borders.LineStyle = XlLineStyle.xlContinuous;
                        borders.Weight = 2d;
                    }
                }

                for (int i = 0; i < dg.ColumnCount; i++)
                {
                    worksheet.Columns[i + 1].AutoFit();
                }

                

                // save workbook
                workbook.SaveAs(fileName);
                workbook.Close();
                excel.Quit();
                MessageBox.Show("Xuất file Excel thành công");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                workbook = null;
                worksheet = null;
            }
        }

        public void XuatFileExcelDanhSach(DataGridView dg, string fileName, string tieuDe)
        {
            Microsoft.Office.Interop.Excel.Application excel;
            Microsoft.Office.Interop.Excel.Workbook workbook;
            Microsoft.Office.Interop.Excel.Worksheet worksheet;



            try
            {
                excel = new Microsoft.Office.Interop.Excel.Application();
                excel.Visible = false;
                excel.DisplayAlerts = false;

                workbook = excel.Workbooks.Add(Type.Missing);

                worksheet = (Microsoft.Office.Interop.Excel.Worksheet)workbook.Sheets["Sheet1"];
                worksheet.Name = "Danh Sách";
                Range range;

                // export tiêu đề

                worksheet.Cells[1, 1] = tieuDe;
                worksheet.Range["A1:E1"].Merge();

                // export header
                for (int i = 0; i < dg.ColumnCount; i++)
                {
                    worksheet.Columns[i + 1].AutoFit();
                    worksheet.Cells[2, i + 1] = dg.Columns[i].HeaderText;
                    range = worksheet.Cells[2, i + 1];
                    Borders borders = range.Borders;

                    //Set the hair lines style
                    borders.LineStyle = XlLineStyle.xlContinuous;
                    borders.Weight = 3d;

                }

                // export content
                for (int i = 0; i < dg.RowCount; i++)
                {
                    for (int j = 0; j < dg.ColumnCount; j++)
                    {

                        worksheet.Cells[i + 3, j + 1] = dg.Rows[i].Cells[j].Value.ToString();
                        range = worksheet.Cells[i + 3, j + 1];
                        Borders borders = range.Borders;

                        //Set the hair lines style
                        borders.LineStyle = XlLineStyle.xlContinuous;
                        borders.Weight = 2d;
                    }
                }

                for (int i = 0; i < dg.ColumnCount; i++)
                {
                    worksheet.Columns[i + 1].AutoFit();
                }



                // save workbook
                workbook.SaveAs(fileName);
                workbook.Close();
                excel.Quit();
                MessageBox.Show("Xuất file Excel thành công");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                workbook = null;
                worksheet = null;
            }
        }

    }
}
