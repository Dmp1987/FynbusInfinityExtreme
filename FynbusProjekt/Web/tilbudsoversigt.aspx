<%@ Page AutoEventWireup="true" CodeBehind="tilbudsoversigt.aspx.cs" Inherits="Web.Tilbudsoversigt" Language="C#" MasterPageFile="~/Site.Master" Title=""  EnableEventValidation="false"%>
<%@ Import Namespace="Model" %>
<asp:Content ID="Content1" ContentPlaceHolderID="HeadContent" runat="server">
    
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">
    
    <script type="text/javascript">
        $(document).ready(function () {


            

            setTimeout(function () {
                $.each($('table tbody tr td:nth-child(1)'), function () {
                    var tempval = $(this).text();

                    $(this).html('<a href="/edit.aspx?id=' + tempval + '">' + tempval + '</a>');
                    console.log(this);
                });
                $('#MainContent_gvBidinfos').DataTable({
                    searching: true,
                    ordering: true
                });
            }, 20);
        });
    </script>
    
    

    <h1 class="text-center">Tilbudsoversigt</h1>
    <hr/>
          
    
    <asp:GridView runat="server" ID="gvBidinfos">
        
    </asp:GridView>
</asp:Content>
