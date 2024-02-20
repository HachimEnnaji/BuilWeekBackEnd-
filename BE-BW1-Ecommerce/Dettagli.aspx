<%@ Page Language="C#" AutoEventWireup="true" MasterPageFile="~/Site.Master" CodeBehind="Dettagli.aspx.cs" Inherits="BE_BW1_Ecommerce.Dettagli" %>

<asp:Content ID="CartContent" ContentPlaceHolderID="MainContent" runat="server">
    <h2>Dettagli</h2>
    <asp:Repeater runat="server">
        <ItemTemplate>
            <div class="card">
              <img src='<%# Eval ("Immagine") %>' class="card-img-top" alt="...">
              <div class="card-body">
                <h5 class="card-title"><%# Eval ("Titolo") %></h5>
                <p class="card-text"><%# Eval ("Prezzo") %></p>
              </div>
                <div class="card-footer">
                    <a href="Dettagli.aspx?ID=<%# Eval("ID") %>" class="btn btn-primary">Dettagli</a>
                    <asp:Button ID="addToCart" runat="server" Text="Aggiungi al carrello" OnClick="addToCart_Click"/>
                </div>
            </div>
        </ItemTemplate>

    </asp:Repeater>
    </asp:Content>
