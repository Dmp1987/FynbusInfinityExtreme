using System;
using System.Collections.Generic;
using System.Data.Entity.Core.Objects;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;
using Model;


namespace API
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select Service1.svc or Service1.svc.cs at the Solution Explorer and start debugging.
    public class Service1 : IService1
    {

        public string GetName(int id)
        {
            var db = new fynbusprojektEntities();

            var bidinf = db.BidInfo.Find(1);

            var newBidInf = new BidInfo() {BidderName = "Kagemand"};

            db.BidInfo.Add(newBidInf);

            db.SaveChanges();
            return bidinf.BidderName;
        }

        public BidInfo GetBidinfo(int id)
        {
            var db = new fynbusprojektEntities();
            var bi = db.BidInfo.Find(id);

            return bi;

            //return new
            //{
            //    bi.BidderName,
            //    bi.CVR,
            //    ContactInfo = new
            //    {
            //        bi.ContactInfo.BidInfo,
            //        bi.ContactInfo.City,
            //        bi.ContactInfo.Kommune,
            //        bi.ContactInfo.Postnummer,
            //        bi.ContactInfo.Vejnavn,
            //        bi.ContactInfo.Vejnummer,
            //        bi.ContactInfo.id
            //    },
            //    Documentation = new
            //    {
            //        bi.Documentation.BidInfo,
            //        bi.Documentation.DatoForRegistrering,
            //        bi.Documentation.DokumentationsInfo,
            //        bi.Documentation.KlarTilDrift_id,
            //        bi.Documentation.RegistreringsNummer,
            //        bi.Documentation.Tilladelse_Gyldig,
            //        bi.Documentation.Tilladelse_Nummer,
            //        bi.Documentation.Tilladelse_Type,
            //        bi.Documentation.TrafikSelskab,
            //        bi.Documentation.UdstedendeMyndighed,
            //        bi.Documentation.id
            //    },
            //    Equipment = new
            //    {
            //        bi.Equipment.Barnestol_0_13kg,
            //        bi.Equipment.Barnestol_15_36kg,
            //        bi.Equipment.Barnestol_9_18kg,
            //        bi.Equipment.Barnestol_9_36kg,
            //        bi.Equipment.Barnestol_Integreret
            //    }
            //};
        }

        public ContactInfo GetContactInfo(int id)
        {           
           using( var db = new fynbusprojektEntities())
           {
               object contactInfo = db.ContactInfo.Find(id);

               return contactInfo as ContactInfo;
           }
        }

        public Documentation GetDocumentation(int id)
        {
            using (var db = new fynbusprojektEntities())
            {
                object documentInfo = db.Documentation.Find(id);

                return documentInfo as Documentation;
            }
        }

        public Equipment GetEquipment(int id)
        {
            using (var db = new fynbusprojektEntities())
            {
                Equipment equipment = db.Equipment.Find(id);

                return equipment;
            }
        }

        public ExpandedBidInfo GetExpandedBifInfo(int id)
        {
            using (var db = new fynbusprojektEntities())
            {
                ExpandedBidInfo ExpInfo = db.ExpandedBidInfo.Find(id);
                return ExpInfo;
            }
        }

        public PriceList GetPriceList(int id)
        {
            using (var db = new fynbusprojektEntities())
            {
                PriceList prices = db.PriceList.Find(id);
                return prices;
            }
        }

        [WebInvoke(RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json)]
        [WebGet(RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json)]
        public BidInfo CreateBidInfo(BidInfo newBidInfo)
        {
            using (var db = new fynbusprojektEntities())
            {
                var bidInfo = new BidInfo();
                var doc = new Documentation();
                var exp = new ExpandedBidInfo();
                var pList = new PriceList();
                var eq = new Equipment();
                var contactInfo = new ContactInfo();

                var newDbEntry = db.BidInfo.Add(bidInfo);

                db.SaveChanges();

                var id = db.Entry(newDbEntry).Property(p => p.id).CurrentValue;

                if (db.BidInfo.Find(id) != null)
                {
                    doc.id = id;
                    exp.id = id;
                    pList.id = id;
                    eq.id = id;
                    contactInfo.id = id;
                }
                
                //gem alle elementer
                db.Documentation.Add(doc);
                db.ExpandedBidInfo.Add(exp);
                db.PriceList.Add(pList);
                db.Equipment.Add(eq);
                db.ContactInfo.Add(contactInfo);

                db.SaveChanges();

                BidInfo newlyCreatedEntry = db.Entry(newDbEntry).Entity;
                
                if (newlyCreatedEntry == null)
                {
                    throw new Exception();
                }
                else
                {
                    return newlyCreatedEntry;
                }               

            }
        }

        public void CreateContactInfo(ContactInfo newContactInfo)
        {
               //wolla!
        }

        public void CreateDocumentation(BidInfo newBid)
        {
            throw new NotImplementedException();
        }

        public object CreateEquipment(BidInfo newBid)
        {
            throw new NotImplementedException();
        }

        public object CreateExpandedBifInfo(BidInfo newBid)
        {
            throw new NotImplementedException();
        }

        public object CreatePriceList(BidInfo newBid)
        {
            throw new NotImplementedException();
        }

        public object UpdateBidInfo(object newBid)
        {
            throw new NotImplementedException();
        }
    }
}
