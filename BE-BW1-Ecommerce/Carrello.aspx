<%@ Page Language="C#" AutoEventWireup="true" MasterPageFile="~/Site.Master" CodeBehind="Carrello.aspx.cs" Inherits="BE_BW1_Ecommerce.Carrello" EnableEventValidation="false" %>

<asp:Content ID="CartContent" ContentPlaceHolderID="MainContent" runat="server">
    <h2 class="aladinH2">Carrello</h2>

    <!--Repeater per visualizzare i prodotti nel carrello-->
    <div>
        <asp:Repeater ID="CartRepeater" runat="server">


    <ItemTemplate>
        <div class="card wrapper">
            <div class="card-body d-flex align-items-center">
                <img class="product-image" src='<%# Eval ("Prodotto.Immagine") %>' alt='<%# Eval ("Prodotto.Titolo") %>' />
                <div class="product-details">
                    <h5 class="cart-title"><%#Eval ("Prodotto.Titolo") %> </h5>
                    <p class="card-text detail-font"><%# Eval ("Prodotto.Prezzo", "{0:c2}") %></p>
                    <!--aggiungo controlli per modificare la quantità e aggiornare il carrello-->
                    <asp:TextBox ID="txtQuantity" runat="server" Text='<%# Eval("Quantita") %>'></asp:TextBox>
                    <asp:Button ID="btnUpdateQuantity" runat="server" Text="Aggiorna Carrello" CssClass="btn btnLogin detail-font" OnClick="btnUpdateQuantity_Click" CommandArgument='<%# Eval("Prodotto.Id") %>' />

                </div>
            </div>
        </div>
    </ItemTemplate>
</asp:Repeater>
        <hr />
        <!--Totale del carrello-->
        <h2 class="aladinH2">Totale: <span id="Totale" runat="server"></span></h2>
    </div>

</asp:Content>


