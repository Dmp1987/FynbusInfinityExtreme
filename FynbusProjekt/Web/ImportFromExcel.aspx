<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="ImportFromExcel.aspx.cs" Inherits="Web.ImportFromExcel" %>
<asp:Content ID="Content1" ContentPlaceHolderID="HeadContent" runat="server">
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">
    <legend>Importer fra Excelfil</legend>
    
    
    <div id="uploadbox" runat="server">
        <p>Upload excel fil i gyldigt format</p>
        
        <asp:FileUpload ID="exFileUpload" runat="server"/>
    
        <asp:Button id="saveFileUpload" OnClick="OpenTextFile" runat="server" Text="Upload"></asp:Button>
    </div>
    <div id="successbox" runat="server" Visible="false">
        <p class="text-success">Success!</p>
    </div>
</asp:Content>