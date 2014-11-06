using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Model;

namespace Web
{
    public partial class Edit : System.Web.UI.Page
    {

        private DateTime _lastEdit;
        private int _id;
        private BidInfo _bi;
        protected void Page_Load(object sender, EventArgs e)
        {
            //opret delegate til saveBtn
            saveBtn.ServerClick += SaveBtnOnServerClick;

           
                //hent id ud fra url parameteren
                try
                {
                    _id = int.Parse(Request["id"]);

                    using (var db = new fynbusprojektEntities())
                    {
                        //hent bid
                        _bi = db.BidInfo.Find(_id);

                        //gem lastedit
                        _lastEdit = _bi.LastEdit;

                        var doc = _bi.Documentation;
                        var ci = _bi.ContactInfo;
                        var exp = _bi.ExpandedBidInfo;
                        var plist = _bi.PriceList;
                        var eq = _bi.Equipment;


                        //indsæt data på siden
                        biddername.InnerText = _bi.BidderName;
                        cvrnr.InnerText = _bi.CVR.ToString();

                        by.InnerText = ci.City;
                        kommune.InnerText = ci.Kommune;
                        postnr.InnerText = ci.Postnummer.ToString();
                        vejnavn.InnerText = ci.Vejnavn;
                        vejnr.InnerText = ci.Vejnummer.ToString();

                        datoforregistrering.InnerText = doc.DatoForRegistrering.ToString();
                        dokInfo.InnerText = doc.DokumentationsInfo;
                        regnr.InnerText = doc.RegistreringsNummer;
                        tilladelsegyldig.InnerText = doc.Tilladelse_Gyldig.ToString();
                    }
                }
                catch (Exception exception)
                {
                    Console.WriteLine(exception);
                }
        }

        private void SaveBtnOnServerClick(object sender, EventArgs eventArgs)
        {
            using (var db = new fynbusprojektEntities())
            {
                var getBid = db.BidInfo.Find(_bi.id);

                //indsæt ny data i getbid

                //tjek om det er blevet redigeret i mellemtiden
                if (getBid.LastEdit != _bi.LastEdit)
                {
                    //hvis ja, vis en alert
                    Page.ClientScript.RegisterClientScriptBlock(this.GetType(), "alert", "alert('Ude af stand til at gemme! Dette tilbud er blevet redigeret i mellemtiden.')");
                }
                else
                {
                    //hvis nej, kør en update
                    new API.Service1().UpdateBidInfo(getBid);
                }

            }
        }
    }
}