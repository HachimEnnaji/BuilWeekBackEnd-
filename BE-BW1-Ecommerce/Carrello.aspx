<%@ Page Language="C#" AutoEventWireup="true" MasterPageFile="~/Site.Master" CodeBehind="Carrello.aspx.cs" Inherits="BE_BW1_Ecommerce.Carrello" %>

<asp:Content ID="CartContent" ContentPlaceHolderID="MainContent" runat="server">
    <h2>Carrello</h2>

    <!--Repeater per visualizzare i prodotti nel carrello-->
    <div>
        <asp:Repeater ID="CartRepeater" runat="server">
            <ItemTemplate>
                <div class="card">
                    <div class="card-body">
                        <h5 class="card-title"><%# Eval ("Titolo") %></h5>
                        <p class="card-text"><%# Eval ("Prezzo", "{0:c2}") %></p>
                    </div>
                </div>
            </ItemTemplate>

        </asp:Repeater>
    </div>

</asp:Content>


