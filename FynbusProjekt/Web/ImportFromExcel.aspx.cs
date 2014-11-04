using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ExcelReader;
using Web.APIService;

namespace Web
{
    public partial class ImportFromExcel : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void OpenTextFile(object sender, EventArgs e)
        {
            if (exFileUpload.HasFile)
            {
                exFileUpload.SaveAs(Server.MapPath("/Uploads/" + exFileUpload.FileName));

                var excelFilePath = MapPath("/Uploads/" + exFileUpload.FileName);

                Reader.ReadFromExcel(excelFilePath);
            }
        }
    }
}