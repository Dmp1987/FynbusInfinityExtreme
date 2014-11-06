<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="edit.aspx.cs" Inherits="Web.Edit" %>
<asp:Content ID="Content1" ContentPlaceHolderID="HeadContent" runat="server">
    <link href="//cdnjs.cloudflare.com/ajax/libs/x-editable/1.5.0/bootstrap3-editable/css/bootstrap-editable.css" rel="stylesheet"/>
    <script src="//cdnjs.cloudflare.com/ajax/libs/x-editable/1.5.0/bootstrap3-editable/js/bootstrap-editable.min.js"></script>
    
    <script type="text/javascript">

        $(function() {
            $.fn.editable.defaults.mode = 'inline';

            $('#formContent').find('a').editable();

        })
        
    </script>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">
    

    <div class="panel-group"  id="formContent">
        <div class="panel">
            <div class="panel-heading">
                <h3>Tilbud</h3>
            </div>
            <div class="panel-body">
                <div class="form-group">
                    <label class="control-label">Firmanavn</label><br/>
                    <a href="#" id="biddername" data-type="text" runat="server"></a>
                </div>
                <div class="form-group">
                    <label>CVR nummer</label><br/>
                    <a href="#" id="cvrnr" data-type="text" runat="server"></a>
                </div>
            </div>
        </div>
        <div class="panel">
            <div class="panel-heading">
                <h3>Kontaktinformation</h3>
            </div>
            <div class="panel-body">
                <div class="form-group">
                    <label>By</label><br/>
                    <a href="#" id="by" data-type="text" runat="server"></a>
                </div>
                <div class="form-group">
                    <label>Kommune</label><br/>
                    <a href="#" id="kommune" data-type="text" runat="server"></a>
                </div>
                <div class="form-group">
                    <label>Postnummer</label><br/>
                    <a href="#" id="postnr" data-type="text" runat="server"></a>
                </div>
                <div class="form-group">
                    <label>Vejnavn</label><br/>
                    <a href="#" id="vejnavn" data-type="text" runat="server"></a>
                </div>
                <div class="form-group">
                    <label>Vejnummer</label><br/>
                    <a href="#" id="vejnr" data-type="text" runat="server"></a>
                </div>
            </div>
        </div>
        <div class="panel">
            <div class="panel-heading">
                <h3>Dokumentation</h3>
            </div>
            <div class="panel-body">
                <div class="form-group">
                    <label>Dato For Registrering</label><br/>
                    <a href="#" id="datoforregistrering" data-type="text" runat="server"></a>
                </div>
                <div class="form-group">
                    <label>Dokumentations info</label><br/>
                    <a href="#" id="dokInfo" data-type="text" runat="server"></a>
                </div>
                <div class="form-group">
                    <label>Registreringsnummer</label><br/>
                    <a href="#" id="regnr" data-type="text" runat="server"></a>
                </div>
                <div class="form-group">
                    <label>Tilladelse gyldig</label><br/>
                    <a href="#" data-type="select" id="tilladelsegyldig" runat="server"></a>
                </div>
                <div class="form-group">
                    <label>Tilladelsesnummer</label><br/>
                    <a href="#" id="tilladelsesnummer" data-type="text" runat="server"></a>
                </div>
                <div class="form-group">
                    <label>Tilladelsestype</label><br/>
                    <a href="#" id="tilladelsetype" data-type="text" runat="server"></a>
                </div>
                <div class="form-group">
                    <label>Trafikselskab</label><br/>
                    <a href="#" id="trafikselskab" data-type="text" runat="server"></a>
                </div>
                <div class="form-group">
                    <label>Udstende myndighed</label><br/>
                    <a href="#" id="docUdstende" data-type="text" runat="server"></a>
                </div>
                <div class="form-group">
                    <label>Klar til drift ID</label><br/>
                    <a href="#" id="klarTilDrift" data-type="text" runat="server"></a>
                </div>
            </div>
            <div class="form-group">
                <button class="btn btn-primary" id="saveBtn" runat="server"><i class="fa fa-save"></i><br />Gem</button>
            </div>
        </div>
    </div>

</asp:Content>