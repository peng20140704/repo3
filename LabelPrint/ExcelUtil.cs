using NPOI.HSSF.UserModel;
using NPOI.SS.UserModel;
using NPOI.XSSF.UserModel;
using System.Collections;
using System.Data;
using System.IO;

namespace WinPrint
{
    public class ExcelUtil
    {
        private IWorkbook workbook;  // 工作薄
        private ISheet sheet;        // 工作表

        /// <summary>
        /// Excel文件，转DataTable
        /// </summary>
        /// <param name="file"></param>
        /// <returns></returns>
        public DataTable ExcelToDataTable(string file)
        {
            DataTable dt = new DataTable();
            string fileExt = Path.GetExtension(file).ToLower();
            //using (FileStream fs = new FileStream(file, FileMode.Open, FileAccess.Read))
            using (FileStream fs = new FileStream(file, FileMode.Open, FileAccess.Read, FileShare.ReadWrite))
            {
                //XSSFWorkbook 适用XLSX格式，HSSFWorkbook 适用XLS格式
                if (fileExt == ".xlsx")
                    workbook = new XSSFWorkbook(fs);
                else if (fileExt == ".xls")
                    workbook = new HSSFWorkbook(fs);
                else
                    return null;

                sheet = workbook.GetSheetAt(0);
                //============================================
                // 表头  
                IRow header = sheet.GetRow(sheet.FirstRowNum);
                ArrayList columns = new ArrayList();

                for (int i = 0; i < header.LastCellNum; i++)
                {
                    //dt.Columns.Add(new DataColumn("Columns" + i.ToString()));
                    dt.Columns.Add(new DataColumn(header.GetCell(i).ToString()));
                    columns.Add(i);
                }
                //============================================
                // 明细数据  
                for (int i = 1; i <= sheet.LastRowNum; i++)
                {
                    DataRow dr = dt.NewRow();
                    bool hasValue = false;
                    foreach (int j in columns)
                    {
                        dr[j] = this.GetValueType(sheet.GetRow(i).GetCell(j));
                        if (dr[j] != null && dr[j].ToString() != string.Empty)
                        {
                            hasValue = true;
                        }
                    }
                    if (hasValue)
                    {
                        dt.Rows.Add(dr);
                    }
                }
            }
            return dt;
        }

        /// <summary>
        /// 获取单元格类型
        /// </summary>
        /// <param name="cell"></param>
        /// <returns></returns>
        private object GetValueType(ICell cell)
        {
            if (cell == null)
                return null;
            switch (cell.CellType)
            {
                case CellType.Blank:   // BLANK
                    return null;
                case CellType.Boolean: // BOOLEAN  
                    return cell.BooleanCellValue;
                case CellType.Numeric: // NUMERIC 
                    return cell.NumericCellValue;
                case CellType.String:  // STRING 
                    return cell.StringCellValue;
                case CellType.Error:   // ERROR  
                    return cell.ErrorCellValue;
                case CellType.Formula: // FORMULA 
                default:
                    return "=" + cell.CellFormula;
            }
        }
    }
}
