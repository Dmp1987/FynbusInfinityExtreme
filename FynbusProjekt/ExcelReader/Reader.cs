using System;
using System.Data;
using System.Data.OleDb;
using System.Diagnostics.CodeAnalysis;
using API;
using Model;

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
        public static bool ReadFromExcel(string excelFilePath)
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

                if (excelSchema != null)
                {
                    foreach (DataRow row in excelSchema.Rows)
                    {
                        try
                        {
                            string sheetName = row["TABLE_NAME"].ToString();
                            cmd.CommandText = "SELECT * FROM [" + sheetName + "A6:AG]";
                            var dt = new DataTable {TableName = sheetName};
                            var da = new OleDbDataAdapter(cmd);
                            da.Fill(dt);
                            ds.Tables.Add(dt);
                        }
                        catch (Exception)
                        {
                        }
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
                        int p;
                        bool b;
                        var bidinfo = new BidInfo
                        {
                            BidderName = row["Byders (firma)navn"].ToString(),
                            CVR = int.Parse(row["CVR-nr#"].ToString()),
                            LastEdit = DateTime.Now
                        };

                        var k = new Service1();
                        BidInfo savedNewBid = k.CreateBidInfo(bidinfo);

                        var docu = new Documentation
                        {
                            RegistreringsNummer = row["Registreringsnr#"].ToString(),
                        };

                        k.UpdateDocumentation(savedNewBid, docu);

                        var exp = new ExpandedBidInfo
                        {
                            GarantiVognNummer =
                                int.TryParse(row["Evt# Garanti-vogn nummer:"].ToString(), out p) ? p : (int?) null,
                            SecondaryOS = row["Evt# sekundært firma"].ToString(),
                            VognloebsNummer = int.TryParse(row["Vognløbs-nummer:"].ToString(), out p) ? p : (int?) null,
                            TelefonNummer =
                                int.TryParse(row["Kommuni-kation til Planet / Telefon-nummer"].ToString(), out p)
                                    ? p
                                    : (int?) null,
                            VognType = int.TryParse(row["Vogn-type"].ToString(), out p) ? p : (int?) null
                        };

                        k.UpdateExpandedBifInfo(savedNewBid, exp);

                        var eq = new Equipment
                        {
                            Barnestol_0_13kg =
                                bool.TryParse(row["Barne-stole / 0 - 13 kg#"].ToString(), out b) ? b : (bool?) null,
                            Barnestol_9_18kg =
                                bool.TryParse(row["Barne-stole / 9 - 18 kg#"].ToString(), out b) ? b : (bool?) null,
                            Barnestol_9_36kg =
                                bool.TryParse(row["Barne#stole / 9 - 36 kg#"].ToString(), out b) ? b : (bool?) null,
                            Barnestol_15_36kg =
                                bool.TryParse(row["Barne-stole / 15 - 36 kg#"].ToString(), out b) ? b : (bool?) null,
                            Barnestol_Integreret =
                                bool.TryParse(row["Barne-stole / Integreret i sæde"].ToString(), out b)
                                    ? b
                                    : (bool?) null,
                            TrappeMaskine_120 =
                                bool.TryParse(row["Trappe-maskine / 120 kg#"].ToString(), out b) ? b : (bool?) null,
                            TrappeMaskine_160 =
                                bool.TryParse(row["Trappe-maskine / 160 kg#"].ToString(), out b) ? b : (bool?) null
                        };

                        k.UpdateEquipment(savedNewBid, eq);

                        var contact = new ContactInfo
                        {
                            City = row["Hjemsted By"].ToString(),
                            Kommune = row["Hjem-sted Kom-mune"].ToString(),
                            Postnummer = int.TryParse(row["Hjem-sted Post-nummer"].ToString(), out p) ? p : (int?) null,
                            Vejnavn = row["Hjemsted vejnavn"].ToString(),
                            Vejnummer = int.TryParse(row["Hjem-sted vej-nummer"].ToString(), out p) ? p : (int?) null,
                        };

                        k.UpdateContactInfo(savedNewBid, contact);

                        var priceList = new PriceList
                        {
                            HverdagAftenNatKoersel =
                                int.TryParse(row["Timepris for køretid (hverdage aften/nat)"].ToString(), out p)
                                    ? p
                                    : (int?) null,
                            HverdagAftenNatOpstartsGebyr =
                                int.TryParse(row["Opstartsgebyr (hverdage aften/nat)"].ToString(), out p)
                                    ? p
                                    : (int?) null,
                            HverdagAftenNatVentetid =
                                int.TryParse(row["Timepris for ventetid (hverdage aften/nat)"].ToString(), out p)
                                    ? p
                                    : (int?) null,
                            HverdageKoersel =
                                int.TryParse(row["Opstartsgebyr (hverdage aften/nat)"].ToString(), out p)
                                    ? p
                                    : (int?) null,
                            HverdageOpstartsGebyr =
                                int.TryParse(row["Opstartsgebyr (hverdage)"].ToString(), out p) ? p : (int?) null,
                            HverdageVenteTid =
                                int.TryParse(row["Timepris ventetid (hverdage):"].ToString(), out p) ? p : (int?) null,
                            PrisPerLoeft_Trappemaskine =
                                int.TryParse(row["Pris pr# løft med trappemaskine"].ToString(), out p) ? p : (int?) null,
                            WeekendHelligdagKoersel =
                                int.TryParse(row["Timepris køretid (weekender/helligdage)"].ToString(), out p)
                                    ? p
                                    : (int?) null,
                            WeekendHelligdagOpstartsGebyr =
                                int.TryParse(row["Opstartsgebyr (weekender/helligdage)"].ToString(), out p)
                                    ? p
                                    : (int?) null,
                            WeekendHelligdagVentetid =
                                int.TryParse(row["Timepris ventetid (weekender/helligdage)"].ToString(), out p)
                                    ? p
                                    : (int?) null,
                            YderligInfo = row["Yderligere oplysninger"].ToString()
                        };

                        k.UpdatePricelist(savedNewBid, priceList);


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
            return true;
        }
    }
}