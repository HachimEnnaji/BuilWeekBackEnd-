<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="BE_BW1_Ecommerce._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

    <main>
                <div class="container">
                    <div class="row">
        <asp:Repeater ID="cardRepeater" runat="server">
            <ItemTemplate>
                        <div class="col">
                            <div class="card">
                                <img src='<%# Eval ("Immagine") %>' class="card-img-top w-100" alt="...">
                                <div class="card-body">
                                    <h5 class="card-title"><%# Eval ("Titolo") %></h5>
                                    <p class="card-text"><%# Eval ("Prezzo", "{0:c2}") %></p>
                                </div>
                                <div class="card-footer">
                                    <a href="Dettagli.aspx?ID=<%# Eval("IDGiocoDaTavolo") %>" class="btn btn-primary">Dettagli</a>
                                    <asp:Button ID="addToCart" runat="server" Text="Aggiungi al carrello" OnClick="addToCart_Click" CommandArgument='<%# Eval("IDGiocoDaTavolo") %>'/>
                                </div>
                            </div>
                        </div>
            </ItemTemplate>
        </asp:Repeater>
                    </div>
                </div>
    </main>

</asp:Content>
