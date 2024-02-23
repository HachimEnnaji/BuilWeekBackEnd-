<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" enableEventValidation="false" CodeBehind="Admin.aspx.cs" Inherits="BE_BW1_Ecommerce.Admin" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent"  runat="server">

    <main>
        <div class="container">
            <div class="row">
                <asp:Repeater ID="cardRepeater" runat="server">
                    <ItemTemplate>
                        <div class="col-sm-6 col-md-4 col-lg-3 gy-3">
                            <div class="card wrapper h-100 w-100">
                                <img src='<%# Eval ("Immagine") %>' class="card-img-top" alt='<%# Eval ("Titolo") %>'>
                                <div class="card-body">
                                    <h5 class="card-title"><%# Eval ("Titolo") %></h5>
                                    <p class="card-text"><%# Eval ("Prezzo", "{0:c2}") %></p>
                                </div>
                                <div class="card-footer d-flex justify-content-between">
                                    <a href="Modifica.aspx?ID=<%# Eval("IDGiocoDaTavolo") %>" class="btn btn-warning rounded-circle"><i class="fa-solid fa-wrench"></i></a>
                                    <asp:LinkButton ID="Delete" runat="server" OnClick="Delete_Click" CssClass="btn btn-danger rounded-circle" CommandArgument=<%# Eval("IDGiocoDaTavolo") %>> <i class="fa-solid fa-trash"></i> </asp:LinkButton>
                                </div>
                            </div>
                        </div>
                    </ItemTemplate>
                </asp:Repeater>
            </div>
        </div>
    </main>

</asp:Content>
