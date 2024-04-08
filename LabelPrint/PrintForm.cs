using MyAlarmSystem.MyClass;
using System;
using System.Data;
using System.Drawing.Printing;
using System.Windows.Forms;

namespace WinPrint
{
    public partial class PrintForm : Form
    {
        BarTender.Application btApp;
        BarTender.Format btFormat;
        private DataTable data;
        private ExcelUtil excelUtil = new ExcelUtil();

        public PrintForm()
        {
            InitializeComponent();
        }

        /// <summary>
        /// 窗体加载
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Form_Load(object sender, EventArgs e)
        {
            btApp = new BarTender.Application();

        }

        /// <summary>
        /// 窗体关闭时，执行事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Form_FormClosed(object sender, FormClosedEventArgs e)
        {
            btApp.Quit(BarTender.BtSaveOptions.btSaveChanges);
        }

        /// <summary>
        /// 导入
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnImport_Click(object sender, EventArgs e)
        {
            OpenFileDialog.Filter = "Excel文件(*.xls,*.xlsx)|*.xls;*.xlsx";
            OpenFileDialog.Title = "打开窗口";
            if (OpenFileDialog.ShowDialog() == DialogResult.Cancel)  // 取消，则退出
                return;

            string fileName = OpenFileDialog.FileName;
            fileLabel.Text = fileName;
            data = this.excelUtil.ExcelToDataTable(fileName);    // Excel文件，写入DataTable

            dgvData.DataSource = data; // 设置数据源
        }

        /// <summary>
        /// 打印
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnPrint_Click(object sender, EventArgs e)
        {
            int row = dgvData.SelectedRows.Count;  // 选中的总行数
            if (row < 1)
            {
                MyHelper.ShowMessageBoxInfo("没有选中的打印列表！");
                return;
            }

            PrintDocument printDocument = new PrintDocument();    // 获取默认打印机的方法
            int num = 1;    // 设置打印数量的变量

            string path = GetApplicationPath();  // 获取项目的根路径

            // 打印选中的行
            for (int i = 0; i < row; i++)
            {
                // 调用模板文件
                btFormat = btApp.Formats.Open(path + "/菲林房标签模板.btw", false, "");

                // 向bartender模板传递变量
                btFormat.SetNamedSubStringValue("partNum", dgvData.SelectedRows[i].Cells["本厂料号"].Value.ToString()); 
                btFormat.SetNamedSubStringValue("date", DateTime.Now.ToShortDateString());

                btFormat.SetNamedSubStringValue("xfactor", dgvData.SelectedRows[i].Cells["涨缩系数x"].Value.ToString());
                btFormat.SetNamedSubStringValue("yfactor", dgvData.SelectedRows[i].Cells["涨缩系数Y"].Value.ToString());
                btFormat.SetNamedSubStringValue("type", dgvData.SelectedRows[i].Cells["申请周期"].Value.ToString());

                btFormat.Printer = printDocument.PrinterSettings.PrinterName;
                btFormat.PrintSetup.IdenticalCopiesOfLabel = num;      // 设置同序列打印的份数
                btFormat.PrintOut(true, false);                        // 第二个参数， 设置false，打印时跳出打印属性
                btFormat.Close(BarTender.BtSaveOptions.btSaveChanges); // 退出时是否保存标签
            }
        }

        /// <summary>
        /// 全选
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnSeletAll_Click(object sender, EventArgs e)
        {
           int row = dgvData.Rows.Count;// 得到总行数
            if (row < 1)
                return;

            for (int i = 0; i < row; i++)
            {
                dgvData.Rows[i].Selected = true;
            }
        }

        /// <summary>
        /// 获取项目的根目录
        /// </summary>
        /// <returns></returns>
        private static string GetApplicationPath()
        {
            // E:\Work\4 Other\最近工作\C# 工程智能系统\工程管理系统\工程管理系统 4.7\WinPrint\WinPrint\bin\Debug
            string path = Application.StartupPath;
            string folderName = String.Empty;
            while (folderName.ToLower() != "bin")
            {
                path = path.Substring(0, path.LastIndexOf("\\"));
                folderName = path.Substring(path.LastIndexOf("\\") + 1);
            }
            return path.Substring(0, path.LastIndexOf("\\") + 1);
        }

        /// <summary>
        /// 清空
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnClear_Click(object sender, EventArgs e)
        {
            dgvData.DataSource = null;
            fileLabel.Text = "";
        }
        //================ 有方法时，请写在我的上面  ================
    }
}

/*

//int row = dgvData.Rows.Count;// 得到总行数
//openFileDialog1.Filter = "Excel文件(*.xls,*.xlsx)|*.xls;*.xlsx|文本文件(*.txt)|*.txt|所有文件(*.*)|*.*"; 
//openFileDialog.FilterIndex = 1;   // 选定筛选器的索引的值。 默认值为 1

// 打印所有的行
//for (int i = 0; i < row - 1; i++)//得到总行数并在之内循环    
//{
//    btFormat = btApp.Formats.Open(@"C:\Users\Administrator\Desktop\菲林房标签模板.btw", false, "");

//    btFormat.SetNamedSubStringValue("partNum", dgvData.Rows[i].Cells["本厂料号"].Value.ToString()); // 向bartender模板传递变量
//    btFormat.SetNamedSubStringValue("date", DateTime.Now.ToShortDateString());  

//    btFormat.SetNamedSubStringValue("xfactor", dgvData.Rows[i].Cells["涨缩系数x"].Value.ToString());
//    btFormat.SetNamedSubStringValue("yfactor", dgvData.Rows[i].Cells["涨缩系数Y"].Value.ToString());
//    btFormat.SetNamedSubStringValue("type", dgvData.Rows[i].Cells["申请周期"].Value.ToString());

//    //d.Add("LJNAME", dgvData.Rows[i].Cells[0].Value.ToString());

//    btFormat.Printer = fPrintDocument.PrinterSettings.PrinterName;
//    btFormat.PrintSetup.IdenticalCopiesOfLabel = num;      // 设置同序列打印的份数
//    btFormat.PrintOut(true, false);                        // 第二个false设置打印时是否跳出打印属性
//    btFormat.Close(BarTender.BtSaveOptions.btSaveChanges); // 退出时是否保存标签
//} 

*/
