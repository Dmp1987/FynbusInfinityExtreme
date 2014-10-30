using System;
using System.Web.UI;
using Web.APIService;

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
            //var apiclient = new Service1Client();
            ////gem budinfo

            //var bid = new
            //{
            //    budNavn = budNavn.Value,
            //    budCVR = budCVR.Value,
            //    budNr = budNr.Value
            //};

            //try
            //{
            //    //gem udvidet info

            //    BidInfo createdBid = apiclient.CreateBidInfo(bid);

            //    if (createdBid != null)
            //    {
            //        var ui = new
            //        {
            //            uiGarantiVognNr = uiGarantiVognNr.Value,
            //            uiRegSerieNr = uiRegSerieNr.Value,
            //            uiSekundærOs = uiSekundærOs.Value,
            //            uiTelefon = uiTelefon.Value,
            //            uiVognType = uiVognType.Value,
            //            uiVognløbNr = uiVognløbNr.Value
            //        };


            //        apiclient.CreateExpandedBifInfo(ui, createdBid.id);

            //        //gem dok info

            //        var doc = new
            //        {
            //            docTilladelseGyldig = docTilladelseGyldig.Value,
            //            docTilladelseNr = docTilladelseNr.Value,
            //            docTilladelseType = docTilladelseType.Value,
            //            docTrafikSelskab = docTrafikSelskab.Value,
            //            docUdstende = docUdstende.Value
            //        };

            //        apiclient.CreateDocumentation(doc, createdBid.id);

            //        //gem udstyr

            //        var equipment = new
            //        {
            //            usBarnestol013kg = usBarnestol013kg.Value,
            //            usBarnestol1536kg = usBarnestol1536kg.Value,
            //            usBarnestol918kg = usBarnestol918kg.Value,
            //            usBarnestol936kg = usBarnestol936kg.Value,
            //            usBarnestolIntg = usBarnestolIntg.Value,
            //            usTrappe120kg = usTrappe120kg.Value,
            //            usTrappe160kg = usTrappe160kg.Value
            //        };

            //        apiclient.CreateEquipment(equipment, createdBid.id);

            //        //gem kontaktinfo

            //        var contact = new
            //        {
            //            kontaktBy = kontaktBy.Value,
            //            kontaktKommune = kontaktKommune.Value,
            //            kontaktPostnummer = kontaktPostnummer.Value,
            //            kontaktVejnavn = kontaktVejnavn.Value,
            //            kontaktVejnummer = kontaktVejnummer.Value
            //        };

            //        apiclient.CreateContactInfo(contact, createdBid.id);

            //        //gem prisliste

            //        var pricelist = new
            //        {
            //            plHverdagAftenNatKoersel = plHverdagAftenNatKoersel.Value,
            //            plHverdagAftenNatOpstartsGebyr = plHverdagAftenNatOpstartsGebyr.Value,
            //            plHverdagAftenNatVentetid = plHverdagAftenNatVentetid.Value,
            //            plHverdageKoersel = plHverdageKoersel.Value,
            //            plHverdageOpstartsGebyr = plHverdageOpstartsGebyr.Value,
            //            plHverdageVenteTid = plHverdageVenteTid.Value,
            //            plPrisPerLoeft_Trappemaskine = plPrisPerLoeft_Trappemaskine.Value,
            //            plWeekendHelligdagKoersel = plWeekendHelligdagKoersel.Value,
            //            plWeekendHelligdagOpstartsGebyr = plWeekendHelligdagOpstartsGebyr.Value,
            //            plWeekendHelligdagVentetid = plWeekendHelligdagVentetid.Value,
            //            plYderligInfo = plYderligInfo.Value
            //        };

            //        apiclient.CreatePriceList(pricelist, createdBid.id);
            //    }
            //}
            //catch (Exception)
            //{
            //    throw;
            //}
        }
    }
}