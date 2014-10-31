<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="createoffer.aspx.cs" Inherits="Web.Createoffer" %>
<asp:Content ID="Content1" ContentPlaceHolderID="HeadContent" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">
    <div class=" col-lg-5">
        <legend>Budinfo</legend>
        <div class="form-horizontal">
            <div class="form-group">
                <label>Navn</label>
                <input type="text" class="form-control" id="budNavn" runat="server"/>
            </div>
            <div class="form-group">
                <label>CVR.nr.</label>
                <input type="text" class="form-control" id="budCVR" runat="server"/>
            </div>
            <div class="form-group">
                <label>Tilbudsnummer</label>
                <input type="text" class="form-control" id="budNr" runat="server"/>
            </div>
        </div>
        
        <legend>Kontaktinformationer</legend>
        <div class="form-horizontal">
            <div class="form-group">
                <label>By</label>
                <input type="text" class="form-control" id="kontaktBy" runat="server"/>
            </div>
            <div class="form-group">
                <label>Kommune</label>
                <input type="text" class="form-control" id="kontaktKommune" runat="server"/>
            </div>
            <div class="form-group">
                <label>Postnummer</label>
                <input type="text" class="form-control" id="kontaktPostnummer" runat="server"/>
            </div>
            <div class="form-group">
                <label>Vejnavn</label>
                <input type="text" class="form-control" id="kontaktVejnavn" runat="server"/>
            </div>
            <div class="form-group">
                <label>Vejnummer</label>
                <input type="text" class="form-control" id="kontaktVejnummer" runat="server"/>
            </div>
        </div>
        <legend>Udstyr</legend>
        <div class="form-horizontal">
            <div class="form-group">
                <label>Barnestol 0-13kg</label>
                <input type="text" class="form-control" id="usBarnestol013kg" runat="server"/>
            </div>
            <div class="form-group">
                <label>Barnestol 15-36kg</label>
                <input type="text" class="form-control" id="usBarnestol1536kg" runat="server"/>
            </div>
            <div class="form-group">
                <label>Barnestol 9-18kg</label>
                <input type="text" class="form-control" id="usBarnestol918kg" runat="server"/>
            </div>
            <div class="form-group">
                <label>Barnestol 9-36kg</label>
                <input type="text" class="form-control" id="usBarnestol936kg" runat="server"/>
            </div>
            <div class="form-group">
                <label>Barnestol integreret</label>
                <input type="text" class="form-control" id="usBarnestolIntg" runat="server"/>
            </div>
            <div class="form-group">
                <label>Trappemaskine 120kg</label>
                <input type="text" class="form-control" id="usTrappe120kg" runat="server"/>
            </div>
            <div class="form-group">
                <label>Trappemaskine 160kg</label>
                <input type="text" class="form-control" id="usTrappe160kg" runat="server"/>
            </div>
        </div>
        <legend>Prisliste</legend>
        <div class="form-horizontal">
            <div class="form-group">
                <label>HverdagAftenNatKoersel</label>
                <input type="text" class="form-control" id="plHverdagAftenNatKoersel" runat="server"/>
            </div>
            <div class="form-group">
                <label>HverdagAftenNatOpstartsGebyr</label>
                <input type="text" class="form-control" id="plHverdagAftenNatOpstartsGebyr" runat="server"/>
            </div>
            <div class="form-group">
                <label>HverdagAftenNatVentetid</label>
                <input type="text" class="form-control" id="plHverdagAftenNatVentetid" runat="server"/>
            </div>
            <div class="form-group">
                <label>HverdageKoersel</label>
                <input type="text" class="form-control" id="plHverdageKoersel" runat="server"/>
            </div>
            <div class="form-group">
                <label>HverdageOpstartsGebyr</label>
                <input type="text" class="form-control" id="plHverdageOpstartsGebyr" runat="server"/>
            </div>
            <div class="form-group">
                <label>HverdageVenteTid</label>
                <input type="text" class="form-control" id="plHverdageVenteTid" runat="server"/>
            </div>
            <div class="form-group">
                <label>PrisPerLoeft_Trappemaskine</label>
                <input type="text" class="form-control" id="plPrisPerLoeft_Trappemaskine" runat="server"/>
            </div>
            <div class="form-group">
                <label>WeekendHelligdagKoersel</label>
                <input type="text" class="form-control" id="plWeekendHelligdagKoersel" runat="server"/>
            </div>
            <div class="form-group">
                <label>WeekendHelligdagOpstartsGebyr</label>
                <input type="text" class="form-control" id="plWeekendHelligdagOpstartsGebyr" runat="server"/>
            </div>
            <div class="form-group">
                <label>WeekendHelligdagVentetid</label>
                <input type="text" class="form-control" id="plWeekendHelligdagVentetid" runat="server"/>
            </div>
            <div class="form-group">
                <label>YderligInfo</label>
                <input type="text" class="form-control" id="plYderligInfo" runat="server"/>
            </div>
        </div>
    </div>
    <div class=" col-lg-offset-1 col-lg-5">
        <legend>Dokumentation</legend>
        <div class="form-horizontal">
            <div class="form-group">
                <label>Registreringsdato</label>
                <input type="text" class="form-control" id="dokRegdato" runat="server"/>
            </div>
            <div class="form-group">
                <label>Dokumentations info</label>
                <input type="text" class="form-control" id="dokInfo" runat="server"/>
            </div>
            <div class="form-group">
                <label>Registrations nummer</label>
                <input type="text" class="form-control" id="dokRegnr" runat="server"/>
            </div>
            <div class="form-group">
                <label>Tilladelse gyldig</label>
                <input type="text" class="form-control" id="docTilladelseGyldig" runat="server"/>
            </div>
            <div class="form-group">
                <label>Tilladelse nummer</label>
                <input type="text" class="form-control" id="docTilladelseNr" runat="server"/>
            </div>
            <div class="form-group">
                <label>Tilladelse type</label>
                <input type="text" class="form-control" id="docTilladelseType" runat="server"/>
            </div>
            <div class="form-group">
                <label>Trafik Selskab</label>
                <input type="text" class="form-control" id="docTrafikSelskab" runat="server"/>
            </div>
            <div class="form-group">
                <label>Udstende myndighed</label>
                <input type="text" class="form-control" id="docUdstende" runat="server"/>
            </div>
        </div>
        <legend>Udvidet informationer</legend>
         <div class="form-horizontal">
             <div class="form-group">
                <label>Garanti vogn nr</label>
                <input type="text" class="form-control" id="uiGarantiVognNr" runat="server"/>
            </div>
             <div class="form-group">
                <label>Reg serie nr</label>
                <input type="text" class="form-control" id="uiRegSerieNr" runat="server"/>
            </div>
             <div class="form-group">
                <label>Sekundær OS</label>
                <input type="text" class="form-control" id="uiSekundærOs" runat="server"/>
            </div>
             <div class="form-group">
                <label>Telefon nummer</label>
                <input type="text" class="form-control" id="uiTelefon" runat="server"/>
            </div>
             <div class="form-group">
                <label>Vogntype</label>
                <input type="text" class="form-control" id="uiVognType" runat="server"/>
            </div>
             <div class="form-group">
                <label>Vognløbs nummer</label>
                <input type="text" class="form-control" id="uiVognløbNr" runat="server"/>
            </div>
         </div>
    </div>
    <div class="col-lg-12">
        <button class="btn btn-success btn-block" id="submit" runat="server">
            Opret tilbud
        </button>
        <button class="btn btn-warning btn-block">
            Reset
        </button>
        <button class="btn btn-danger btn-block">
            Annuller
        </button>
        <br/>
    </div>
</asp:Content>