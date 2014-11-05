using System;
using System.Web.UI;
using Model;

namespace Web
{


    public partial class Createoffer : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            submit.ServerClick += submit_ServerClick;
        }

        private void submit_ServerClick(object sender, EventArgs e)
        {
            var bid = new
            {
                budNavn = budNavn.Value,
                budCVR = budCVR.Value,
                budNr = budNr.Value
            };

            using (var apiclient = new API.Service1())
            {
                int tempVal;
                //gem udvidet info
                var newBid = new BidInfo
                {
                    BidderName = budNavn.Value,
                    CVR = int.TryParse(plHverdageKoersel.Value, out tempVal) ? tempVal : 0
                };

                BidInfo createdBid = apiclient.CreateBidInfo(newBid);

                if (createdBid != null)
                {
                    var ui = new
                    {
                        uiGarantiVognNr = uiGarantiVognNr.Value,
                        uiRegSerieNr = uiRegSerieNr.Value,
                        uiSekundærOs = uiSekundærOs.Value,
                        uiTelefon = uiTelefon.Value,
                        uiVognType = uiVognType.Value,
                        uiVognløbNr = uiVognløbNr.Value
                    };


                    var exp = new ExpandedBidInfo
                    {
                        GarantiVognNummer = int.TryParse(uiGarantiVognNr.Value, out tempVal) ? tempVal : (int?)null,
                        RegSerieNummer = int.TryParse(uiRegSerieNr.Value, out tempVal) ? tempVal : (int?)null,
                        SecondaryOS = uiSekundærOs.Value,
                        TelefonNummer = int.TryParse(uiTelefon.Value, out tempVal) ? tempVal : (int?)null,
                        VognType = int.TryParse(uiVognType.Value, out tempVal) ? tempVal : (int?)null,
                        VognloebsNummer = int.TryParse(uiVognløbNr.Value, out tempVal) ? tempVal : (int?)null
                    };


                    apiclient.UpdateExpandedBifInfo(createdBid, exp);
                    //gem dok info

                    var doc = new
                    {
                        docTilladelseGyldig = docTilladelseGyldig.Value,
                        docTilladelseNr = docTilladelseNr.Value,
                        docTilladelseType = docTilladelseType.Value,
                        docTrafikSelskab = docTrafikSelskab.Value,
                        docUdstende = docUdstende.Value
                    };

                    DateTime tempDate;
                    var docu = new Documentation
                    {
                        Tilladelse_Gyldig =
                            DateTime.TryParse(docTilladelseGyldig.Value, out tempDate) ? tempDate : (DateTime?)null,
                        Tilladelse_Type = docTilladelseType.Value,
                        TrafikSelskab = docTrafikSelskab.Value,
                        UdstedendeMyndighed = docUdstende.Value,
                        RegistreringsNummer = dokRegnr.Value
                    };

                    apiclient.UpdateDocumentation(createdBid, docu);

                    //gem udstyr

                    var equipment = new
                    {
                        usBarnestol013kg = usBarnestol013kg.Value,
                        usBarnestol1536kg = usBarnestol1536kg.Value,
                        usBarnestol918kg = usBarnestol918kg.Value,
                        usBarnestol936kg = usBarnestol936kg.Value,
                        usBarnestolIntg = usBarnestolIntg.Value,
                        usTrappe120kg = usTrappe120kg.Value,
                        usTrappe160kg = usTrappe160kg.Value
                    };

                    //var eq = new Equipment()
                    //{

                    //}

                    //apiclient.UpdateEquipment(createdBid, equipment);

                    //gem kontaktinfo

                    //var contact = new
                    //{
                    //    kontaktBy = kontaktBy.Value,
                    //    kontaktKommune = kontaktKommune.Value,
                    //    kontaktPostnummer = kontaktPostnummer.Value,
                    //    kontaktVejnavn = kontaktVejnavn.Value,
                    //    kontaktVejnummer = kontaktVejnummer.Value
                    //};

                    var con = new ContactInfo
                    {
                        City = kontaktBy.Value,
                        Kommune = kontaktKommune.Value,
                        Postnummer = int.TryParse(kontaktPostnummer.Value, out tempVal) ? tempVal : (int?)null,
                        Vejnavn = kontaktVejnavn.Value,
                        Vejnummer = int.TryParse(kontaktVejnummer.Value, out tempVal) ? tempVal : (int?)null
                    };

                    apiclient.UpdateContactInfo(createdBid, con);

                    //gem prisliste

                    //var pricelist = new
                    //{
                    //    plHverdagAftenNatKoersel = plHverdagAftenNatKoersel.Value,
                    //    plHverdagAftenNatOpstartsGebyr = plHverdagAftenNatOpstartsGebyr.Value,
                    //    plHverdagAftenNatVentetid = plHverdagAftenNatVentetid.Value,
                    //    plHverdageKoersel = plHverdageKoersel.Value,
                    //    plHverdageOpstartsGebyr = plHverdageOpstartsGebyr.Value,
                    //    plHverdageVenteTid = plHverdageVenteTid.Value,
                    //    plPrisPerLoeft_Trappemaskine = plPrisPerLoeft_Trappemaskine.Value,
                    //    plWeekendHelligdagKoersel = plWeekendHelligdagKoersel.Value,
                    //    plWeekendHelligdagOpstartsGebyr = plWeekendHelligdagOpstartsGebyr.Value,
                    //    plWeekendHelligdagVentetid = plWeekendHelligdagVentetid.Value,
                    //    plYderligInfo = plYderligInfo.Value
                    //};


                    var pList = new PriceList
                    {
                        HverdagAftenNatKoersel =
                            int.TryParse(plHverdagAftenNatKoersel.Value, out tempVal) ? tempVal : (int?)null,
                        HverdagAftenNatOpstartsGebyr =
                            int.TryParse(plHverdagAftenNatOpstartsGebyr.Value, out tempVal) ? tempVal : (int?)null,
                        HverdagAftenNatVentetid =
                            int.TryParse(plHverdagAftenNatVentetid.Value, out tempVal) ? tempVal : (int?)null,
                        HverdageKoersel = int.TryParse(plHverdageKoersel.Value, out tempVal) ? tempVal : (int?)null,
                        HverdageOpstartsGebyr =
                            int.TryParse(plHverdageOpstartsGebyr.Value, out tempVal) ? tempVal : (int?)null,
                        HverdageVenteTid =
                            int.TryParse(plHverdageVenteTid.Value, out tempVal) ? tempVal : (int?)null,
                        PrisPerLoeft_Trappemaskine =
                            int.TryParse(plPrisPerLoeft_Trappemaskine.Value, out tempVal) ? tempVal : (int?)null,
                        WeekendHelligdagKoersel =
                            int.TryParse(plWeekendHelligdagKoersel.Value, out tempVal) ? tempVal : (int?)null,
                        WeekendHelligdagOpstartsGebyr =
                            int.TryParse(plWeekendHelligdagOpstartsGebyr.Value, out tempVal) ? tempVal : (int?)null,
                        WeekendHelligdagVentetid =
                            int.TryParse(plWeekendHelligdagVentetid.Value, out tempVal) ? tempVal : (int?)null,
                        YderligInfo = plYderligInfo.Value
                    };

                    apiclient.UpdatePricelist(createdBid, pList);
                }
            }
        }
    }
}