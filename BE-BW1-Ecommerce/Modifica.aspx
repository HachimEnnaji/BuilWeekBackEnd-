<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Modifica.aspx.cs" Inherits="BE_BW1_Ecommerce.Modifica" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">

   <div class="container">
    <div class="row rounded-2 my-3">
        <div class="col col-md-6 wrapper rounded-2 p-4 mx-3 detail-font">
     <h2 class="aladinH2 mb-2">Modifica Prodotto</h2>
        <div class="form-group">
            <label for="txtTitolo">Titolo</label>
            <asp:TextBox ID="txtTitolo" runat="server" CssClass="form-control"></asp:TextBox>
        </div>
        <div class="form-group mt-2">
            <label for="txtPrezzo">Prezzo</label>
            <asp:TextBox ID="txtPrezzo" runat="server" CssClass="form-control"></asp:TextBox>
        </div>
        <div class="form-group mt-2">
            <label for="txtDescrizione">Descrizione</label>
            <textarea class="form-control" ID="txtDescrizione"  runat="server" rows="6" CssClass="d-block"></textarea>
           
        </div>
        <div class="form-group mt-2">
            <label for="txtEditore">Editore</label>
            <asp:TextBox ID="txtEditore" runat="server" CssClass="form-control"></asp:TextBox>
        </div>
        <div class="form-group mt-2">
            <label for="txtImmagine">Immagine</label>
            <asp:TextBox ID="txtImmagine" runat="server" CssClass="form-control"></asp:TextBox>
        </div>
        <div class="form-group">
            <asp:Button ID="btnModifica" runat="server" Text="Modifica" CssClass="btnLogin btn btn-primary my-2" OnClick="btnModifica_Click" />
        </div>
            </div>
    </div>
       </div>
    <asp:Label ID="lblMessaggio" runat="server" Text=""></asp:Label>
</asp:Content>
