<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Modifica.aspx.cs" Inherits="BE_BW1_Ecommerce.Modifica" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    
        <div class="form-group">
            <label for="txtTitolo">Titolo</label>
            <asp:TextBox ID="txtTitolo" runat="server" CssClass="form-control"></asp:TextBox>
        </div>
        <div class="form-group">
            <label for="txtPrezzo">Prezzo</label>
            <asp:TextBox ID="txtPrezzo" runat="server" CssClass="form-control"></asp:TextBox>
        </div>
        <div class="form-group">
            <label for="txtDescrizione">Descrizione</label>
            <asp:TextBox ID="txtDescrizione" runat="server" CssClass="form-control"></asp:TextBox>
        </div>
        <div class="form-group">
            <label for="txtEditore">Editore</label>
            <asp:TextBox ID="txtEditore" runat="server" CssClass="form-control"></asp:TextBox>
        </div>
        <div class="form-group">
            <label for="txtImmagine">Immagine</label>
            <asp:TextBox ID="txtImmagine" runat="server" CssClass="form-control"></asp:TextBox>
        </div>
        <div class="form-group">
            <asp:Button ID="btnModifica" runat="server" Text="Modifica" CssClass="btn btn-primary" OnClick="btnModifica_Click" />
        </div>
    <asp:Label ID="lblMessaggio" runat="server" Text=""></asp:Label>
</asp:Content>
