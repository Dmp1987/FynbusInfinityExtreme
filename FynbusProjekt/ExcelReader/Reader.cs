using System;
using System.Data;
using System.Data.OleDb;
using System.Diagnostics.CodeAnalysis;
using System.Windows.Forms;

namespace ExcelReader
{
    public static class Reader
    {
        private static string _connectionString;

        private static void ImportExcelController()
        {

            //_connectionString =
            //    "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + fileName +
            //    ";Extended Properties=\"Excel 8.0;HDR=Yes;IMEX=1\";OLE DB Services = -2;";
            //or "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=c:\myFolder\myExcel2007file.xlsx; Extended Properties = "Excel 12.0 Xml;HDR=YES";";
        }

        [SuppressMessage("Microsoft.Security", "CA2100:Review SQL queries for security vulnerabilities")]
        public static void ReadFromExcel(string excelFilePath)
        {
            var ds = new DataSet();

            _connectionString =
                "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + excelFilePath +
                ";Extended Properties=\"Excel 8.0;HDR=Yes;IMEX=1\";OLE DB Services = -2;";

            using (var conn = new OleDbConnection(_connectionString))
            {
                conn.Open();
                var cmd = new OleDbCommand {Connection = conn};

                DataTable excelSchema = conn.GetOleDbSchemaTable(OleDbSchemaGuid.Tables, null);

                int count = 0;

                if (excelSchema != null)
                    foreach (DataRow row in excelSchema.Rows)
                    {
                        count++;
                        try
                        {
                            if (row["TABLE_NAME"].ToString().Contains("$") && count >= 8)
                            {
                                string sheetName = row["TABLE_NAME"].ToString();
                                cmd.CommandText = "SELECT * FROM [" + sheetName + "]";
                                var dt = new DataTable { TableName = sheetName };
                                var da = new OleDbDataAdapter(cmd);
                                da.Fill(dt);
                                ds.Tables.Add(dt);
                            }
                            
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

                        var test = row["Merge nr"].ToString();
                        //DateTime firstContact;
                        //DateTime.TryParse(row["Første kontakt"].ToString(), out firstContact);

                        //DateTime? lastContact;
                        //if (row["Seneste kontakt"] != null && row["Seneste kontakt"].ToString().Length > 1)
                        //{
                        //    lastContact = DateTime.Parse(row["Seneste kontakt"].ToString());
                        //}
                        //else
                        //{
                        //    lastContact = null;
                        //}

                        //string phone = "";

                        //if (row["Telefon"] != null && row["Telefon"].ToString().Length > 1)
                        //{
                        //    phone = row["Telefon"].ToString();
                        //}

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