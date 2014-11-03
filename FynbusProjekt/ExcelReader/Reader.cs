using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Data.OleDb;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ExcelReader
{
    public static class Reader
    {
        private static string ConnectionString;

        static void ImportExcelController()
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "Excel Files|*.xls;*.xlsx;*.xlsm";
            ofd.ShowDialog();

            string fileName = ofd.FileName;

            ConnectionString =
                "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + fileName +
                ";Extended Properties=\"Excel 8.0;HDR=Yes;IMEX=1\";OLE DB Services = -2;";
            //or "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=c:\myFolder\myExcel2007file.xlsx; Extended Properties = "Excel 12.0 Xml;HDR=YES";";
        }

        [SuppressMessage("Microsoft.Security", "CA2100:Review SQL queries for security vulnerabilities")]
        public static void ReadFromExcel(string excelFilePath)
        {
            DataSet ds = new DataSet();

            using (OleDbConnection conn = new OleDbConnection(ConnectionString))
            {
                conn.Open();
                OleDbCommand cmd = new OleDbCommand { Connection = conn };

                DataTable excelSchema = conn.GetOleDbSchemaTable(OleDbSchemaGuid.Tables, null);
                if (excelSchema != null)
                    foreach (DataRow row in excelSchema.Rows)
                    {
                        try
                        {
                            string sheetName = row["TABLE_NAME"].ToString();
                            cmd.CommandText = "SELECT * FROM [" + sheetName + "]";
                            DataTable dt = new DataTable { TableName = sheetName };
                            OleDbDataAdapter da = new OleDbDataAdapter(cmd);
                            da.Fill(dt);
                            ds.Tables.Add(dt);

                        }
                        catch (Exception)
                        {
                         
                        }
                        
                        
                    }
                /*
                                cmd = null;
                */
                conn.Close();

                foreach (DataTable table in ds.Tables)
                {
                    foreach (DataRow row in table.Rows)
                    {
                        DateTime firstContact;
                        DateTime.TryParse(row["Første kontakt"].ToString(), out firstContact);

                        DateTime? lastContact;
                        if (row["Seneste kontakt"] != null && row["Seneste kontakt"].ToString().Length > 1)
                        {
                            lastContact = DateTime.Parse(row["Seneste kontakt"].ToString());
                        }
                        else
                        {
                            lastContact = null;
                        }

                        string phone = "";

                        if (row["Telefon"] != null && row["Telefon"].ToString().Length > 1)
                        {
                            phone = row["Telefon"].ToString();
                        }
            
                        //Company company = new Company
                        //{
                        //    Name = row["Firma"].ToString(),
                        //    Phone = phone,
                        //    FirstContact = firstContact,
                        //    LastContact = lastContact,
                        //};
                        ////Status = DefineStatus(row["Afsluttet/aftale"].ToString())

                        ////Roder med ID'en på company, DataBase bliver hys og vil ik lege
                        ////CompanyController.StaticAddCompany(company);

                        //yield return company;

                    }
                }
            }
        }
    }
}
