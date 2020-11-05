using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Newtonsoft.Json.Linq;
using Newtonsoft.Json;
using System.Collections;
using Microsoft.Office.Interop.Excel;
using System.IO;

namespace system
{
    public partial class FormOutPut : WeifenLuo.WinFormsUI.Docking.DockContent
    {
        public static DataGridView pubdgv = new DataGridView();
        public FormOutPut()
        {
            InitializeComponent();
            if (FormLogin.language == true)
                this.Text = "结果";
            switch (FormMain.resultDict["type"])
            {
                case "json":
                    List<Dictionary<string, string>> jsonResult = Readjson(FormMain.outPutPath + @"\pspicks.json");
                    foreach(var dic in jsonResult)
                    {
                        dataGridView.Rows.Add(dic["net"], "", dic["itp"], dic["prob_p"], dic["its"], dic["prob_s"]);
                    }

                    break;
                case "csv":
                    List<string> csvResult = readCsv(FormMain.outPutPath + @"\picks.csv");
                    foreach (var array in csvResult)
                    {
                        string[] row = array.Split(',');
                        if (array == csvResult[0])
                        {
                            //dataGridView.Rows.Add(row[0], row[1], row[2], row[3], row[4]);//读取表头，如果已经有固定表头就注释掉这行
                            continue;
                        }
                        else
                        {
                            dataGridView.Rows.Add(row[0], row[1], row[2], row[3], row[4], row[5]);
                            //dataGridView.Rows.Add(row[0], row[1].Substring(1, row[1].Length - 2), row[2].Substring(1, row[1].Length - 2), row[3].Substring(1, row[1].Length - 2), row[4].Substring(1, row[1].Length - 2));//substring是去掉结果的方括号,不去掉的话用上面那行

                        }

                    }
                    pubdgv = dataGridView;

                    break;
            }


        }




        private List<string> readCsv(string path)
        {
            List<string> table = new List<string>(System.IO.File.ReadLines(path));
            return table;
        }
        
        //private bool getResult(string input, string output)//input: 输入时间。output: 结果时间戳
        //{
        //    double timestamp = 0.0;
        //    string[] myInput = input.Split('.');
        //    //npz格式的计算方法
        //    if (myInput[myInput.Length - 1] == "npz")
        //    {
        //        int year = int.Parse(myInput[0]);
        //        int month = int.Parse(myInput[1]);
        //        int day = int.Parse(myInput[2]);
        //        int second = int.Parse(myInput[3]);
        //        TimeSpan ts = new TimeSpan(0, 0, second);
        //        //richTextBox2.Text = (int)ts.TotalHours + "小时" + ts.Minutes + "分钟" + ts.Seconds + "秒";
        //        DateTime dateTime = new DateTime(year, month, day, ts.Hours, ts.Minutes, ts.Seconds);
        //        int time = ToUnixTimestamp(dateTime);
        //        timestamp = (double)time;

        //    }
        //    //mseed格式的读取方法
        //    else if (myInput[myInput.Length - 1] == "mseed")
        //    {
        //        if (myInput.Length == 5)
        //        {
        //            timestamp = double.Parse(myInput[2] + "." + myInput[3]);
        //        }
        //        else
        //        {
        //            timestamp = double.Parse(myInput[2]);
        //        }

        //    }
        //    //sac格式的读取方法
        //    else
        //    {
        //        if (myInput.Length == 6)
        //        {
        //            timestamp = double.Parse(myInput[3] + "." + myInput[4]);
        //        }
        //        else
        //        {
        //            timestamp = double.Parse(myInput[3]);
        //        }
        //    }

        //    if (double.Parse(output) - timestamp < 30 && double.Parse(output) - timestamp > 0)
        //    {
        //        return true;
        //    }
        //    else
        //    {
        //        return false;
        //    }
        //}

        public List<Dictionary<string, string>> Readjson(string jsonfile)
        {
            //string jsonfile = "F:/quake/ppicks_wenchuan_first_round.json";
            using (System.IO.StreamReader file = System.IO.File.OpenText(jsonfile))
            {
                using (JsonTextReader reader = new JsonTextReader(file))
                {
                    JArray o = null;
                    o = (JArray)JToken.ReadFrom(reader);
                    List<Dictionary<string, string>> result = new List<Dictionary<string, string>>();
                    if (o != null)
                    {
                        foreach(var dic in o)
                        {
                            Dictionary < string, string> subResult= dic.ToObject<Dictionary<string, string>>();
                            result.Add(subResult);
                        }
                    }
                    return result;
                    //if (o != null)
                    //{
                    //    //string pick_time;
                    //    string whichPick = jsonfile.Substring(jsonfile.Length - 11, 1);
                    //    if (whichPick == "s")
                    //    {
                    //        foreach (var dic in o)
                    //        {
                    //            timestamps.Add((string)dic["its"]);
                    //        }
                    //    }
                    //    else
                    //    {
                    //        foreach (var dic in o)
                    //        {
                    //            timestamps.Add((string)dic["itp"]);
                    //        }
                    //    }
                    //}
                    //return timestamps;

                }
            }
        }

        public static void ExportExcel(string fileName, DataGridView myDGV)
        {
            if (myDGV.Rows.Count > 0)
            {

                string saveFileName = "";
                //bool fileSaved = false;  
                SaveFileDialog saveDialog = new SaveFileDialog();
                saveDialog.DefaultExt = "xls";
                saveDialog.Filter = "Excel文件|*.xls";
                saveDialog.FileName = fileName;
                saveDialog.ShowDialog();
                saveFileName = saveDialog.FileName;
                if (saveFileName.IndexOf(":") < 0) return; //被点了取消   
                Microsoft.Office.Interop.Excel.Application xlApp = new Microsoft.Office.Interop.Excel.Application();
                if (xlApp == null)
                {
                    MessageBox.Show("Unable to create Excel object, maybe your machine does not have Excel installed");
                    return;
                }

                Microsoft.Office.Interop.Excel.Workbooks workbooks = xlApp.Workbooks;
                Microsoft.Office.Interop.Excel.Workbook workbook = workbooks.Add(Microsoft.Office.Interop.Excel.XlWBATemplate.xlWBATWorksheet);
                Microsoft.Office.Interop.Excel.Worksheet worksheet = (Microsoft.Office.Interop.Excel.Worksheet)workbook.Worksheets[1];//取得sheet1  

                //写入标题  
                for (int i = 0; i < myDGV.ColumnCount; i++)
                {
                    worksheet.Cells[1, i + 1] = myDGV.Columns[i].HeaderText;
                }
                //写入数值  
                for (int r = 0; r < myDGV.Rows.Count; r++)
                {
                    for (int i = 0; i < myDGV.ColumnCount; i++)
                    {
                        worksheet.Cells[r + 2, i + 1] = myDGV.Rows[r].Cells[i].Value;
                    }
                    System.Windows.Forms.Application.DoEvents();
                }
                worksheet.Columns.EntireColumn.AutoFit();//列宽自适应  
                                                         //   if (Microsoft.Office.Interop.cmbxType.Text != "Notification")  
                                                         //   {  
                                                         //       Excel.Range rg = worksheet.get_Range(worksheet.Cells[2, 2], worksheet.Cells[ds.Tables[0].Rows.Count + 1, 2]);  
                                                         //      rg.NumberFormat = "00000000";  
                                                         //   }  

                if (saveFileName != "")
                {
                    try
                    {
                        workbook.Saved = true;
                        workbook.SaveCopyAs(saveFileName);
                        //fileSaved = true;  
                    }
                    catch (Exception ex)
                    {
                        //fileSaved = false;  
                        MessageBox.Show("An error occurred while exporting the file. The file may be being opened!\n" + ex.Message);
                    }

                }
                //else  
                //{  
                //    fileSaved = false;  
                //}  
                xlApp.Quit();
                GC.Collect();//强行销毁   
                             // if (fileSaved && System.IO.File.Exists(saveFileName)) System.Diagnostics.Process.Start(saveFileName); //打开EXCEL  
                MessageBox.Show("File exported successfully", "Information", MessageBoxButtons.OK);
            }
            else
            {
                MessageBox.Show("Report is empty, no tables need to be exported", "Warning", MessageBoxButtons.OK);
            }

        }
    }
}
