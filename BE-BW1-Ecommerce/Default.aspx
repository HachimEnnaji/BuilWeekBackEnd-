<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="BE_BW1_Ecommerce._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

    <main>
                <div class="container">
                    <div class="row">
        <asp:Repeater ID="cardRepeater" runat="server">
            <ItemTemplate>
                        <div class="col-sm-6 col-md-4 col-lg-3 gy-3">
                            <div class="card wrapper h-100 w-100">
                                <img src='<%# Eval ("Immagine") %>' class="card-img-top" alt="...">
                                <div class="card-body">
                                    <h5 class="card-title"><%# Eval ("Titolo") %></h5>
                                    <p class="card-text"><%# Eval ("Prezzo", "{0:c2}") %></p>
                                </div>
                                <div class="card-footer">
                                    <a href="Dettagli.aspx?ID=<%# Eval("IDGiocoDaTavolo") %>" class="btn btn-outline-secondary me-3">Dettagli</a>
                                    
                                    <asp:LinkButton ID="addToCart"  runat="server" OnClick="addToCart_Click1" CommandArgument='<%# Eval("IDGiocoDaTavolo") %>'  CssClass="btn btn-outline-success"><i class="fa-solid fa-cart-plus"></i></asp:LinkButton>
                                </div>
                            </div>
                        </div>
            </ItemTemplate>
        </asp:Repeater>
                    </div>
                </div>
    </main>

</asp:Content>
