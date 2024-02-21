<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="AggiungiProdotto.aspx.cs" Inherits="BE_BW1_Ecommerce.AggiungiProdotto" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
        <div class="form-group">
            <label for="titolo">Titolo</label>
<asp:TextBox ID="titolo" runat="server" CssClass="form-control"></asp:TextBox>
</div>
        <div class="form-group">
            <label for="prezzo">Prezzo</label>
<asp:TextBox ID="prezzo" runat="server" CssClass="form-control"></asp:TextBox>
</div>
        <div class="form-group">
<label for="descrizione">Descrizione</label>
<asp:TextBox ID="descrizione" runat="server" CssClass="form-control"></asp:TextBox>
</div>
        <div class="form-group">
<label for="editore">Editore</label>
<asp:TextBox ID="editore" runat="server" CssClass="form-control"></asp:TextBox>
</div>
        <div class="form-group">
<label for="immagine">Immagine</label>
<asp:TextBox ID="immagine" runat="server" CssClass="form-control"></asp:TextBox>
</div>
        <asp:Button ID="Aggiungi" runat="server" Text="Aggiungi" OnClick="Aggiungi_Click" CssClass="btn btn-primary mt-3" />
</asp:Content>
