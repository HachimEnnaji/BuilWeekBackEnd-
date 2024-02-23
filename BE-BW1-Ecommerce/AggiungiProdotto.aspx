<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="AggiungiProdotto.aspx.cs" Inherits="BE_BW1_Ecommerce.AggiungiProdotto" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">

   <div class="container">
    <div class="row rounded-2 my-3">
        <div class="col col-md-6 wrapper rounded-2 p-4 mx-3 detail-font">
     <h2 class="aladinH2 mb-2">Crea Prodotto</h2>
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
  <textarea class="form-control" ID="txtDescrizione"  runat="server" rows="6" CssClass="d-block"></textarea>
</div>
        <div class="form-group">
<label for="editore">Editore</label>
<asp:TextBox ID="editore" runat="server" CssClass="form-control"></asp:TextBox>
</div>
        <div class="form-group">
<label for="immagine">Immagine</label>
<asp:TextBox ID="immagine" runat="server" CssClass="form-control"></asp:TextBox>
</div>
        <asp:Button ID="Aggiungi" runat="server" Text="Aggiungi" OnClick="Aggiungi_Click" CssClass="btn btnLogin mt-3" />
         </div>
         </div>
       </div>
</asp:Content>
