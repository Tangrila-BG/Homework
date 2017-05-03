using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using OfficeOpenXml;
using OfficeOpenXml.Table;

namespace _14.ExportToExcel
{
    class Program
    {
        static void Main(string[] args)
        {
            // dependency
            //  <? xml version = "1.0" encoding = "utf-8" ?>
            //  <packages>
            //      <package id = "EPPlus" version = "4.1.0" targetFramework = "net461" />
            //  </packages>
            
            // You will also need to download place the "StudentData.txt" to your desktop
            // in order to run this code successfully

            var pathWithEnv = @"%USERPROFILE%\Desktop\";
            var filePath = Environment.ExpandEnvironmentVariables(pathWithEnv);
            StreamReader file = new StreamReader(filePath + "StudentData.txt");

            FileInfo newFile = new FileInfo(filePath + "sample.xlsx");

            ExcelPackage pck = new ExcelPackage(newFile);

            var ws = pck.Workbook.Worksheets.Add("Student Data");

            char c = 'A';
            string line;
            int row = 0;

            // Font style bold for headers
            ws.Cells["A1:K1"].Style.Font.Bold = true;

            while ((line = file.ReadLine()) != null)
            {
                // read line from the .txt file
                var input = line.Split(new char[] { '\t' }, StringSplitOptions.RemoveEmptyEntries).Select(x => x.Trim()).ToArray();

                if (row == 0)
                {
                    // headers insertion
                    for (int i = 0; i < input.Length; i++, c++)
                        ws.Cells[$"{c}1"].Value = input[i];
                    row++;
                }

                // Row data insertion
                for (int i = 1; i <= input.Length; i++)
                    ws.SetValue(row, i, input[i - 1]);

                row++;
            }
            
           
            // Put added date into table [FROM row 1,FROM col 1,TO row-1,TO col 11 ]  
            var range = ws.Cells[1, 1, row - 1, 11];

            var table = ws.Tables.Add(range, "StudentData");
            table.ShowHeader = true;
            table.ShowTotal = true;
            table.TableStyle = TableStyles.Light2;
            // autofit and save
            ws.Cells.AutoFitColumns();
            pck.Save();

        }
    }
}
