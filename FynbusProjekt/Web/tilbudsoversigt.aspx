<%@ Page AutoEventWireup="true" CodeBehind="tilbudsoversigt.aspx.cs" Inherits="Web.Tilbudsoversigt" Language="C#" MasterPageFile="~/Site.Master" Title=""  EnableEventValidation="false"%>
<%@ Import Namespace="Model" %>
<asp:Content ID="Content1" ContentPlaceHolderID="HeadContent" runat="server">
    <script type="text/javascript">
        $(document).ready(function () {
            $('#dataTable').DataTable({
                searching: true,
                ordering: true
            });
        });
    </script>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">
    
    <h1 class="text-center">Tilbudsoversigt</h1>
    <hr/>
            <table class="table table-bordered table-condensed table-hover table-responsive table-striped" id="dataTable" runat="Server">
                <thead>
                    <tr>
                        
                        <th>
                            Tilbud
                        </th>
                        <th>
                            Etellerandet
                        </th>
                    </tr>
                </thead>
                <tbody>
                    <tr>
                        <td>
                            Kage med Ost
                        </td>
                        <td>
                            Noget
                        </td>
                    </tr>
                </tbody>
            </table>
</asp:Content>
