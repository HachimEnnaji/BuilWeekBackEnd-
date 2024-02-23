<%@ Page Language="C#" AutoEventWireup="true" MasterPageFile="~/Site.Master" CodeBehind="Login.aspx.cs" Inherits="BE_BW1_Ecommerce.Login" %>

<asp:Content ID="CartContent" ContentPlaceHolderID="MainContent" runat="server">
    <div class="container">
        <div class="row">
            <div class="col-md-6 wrapper shadow rounded mt-4">
                <div class="container">
                    <h2 class="pt-3">Benvenuto in Pendragon Board Games</h2>
                    <p class="fs-4">
                        Accedi
                    </p>
                    <p>
                        <asp:Label ID="lblMessage" runat="server" Text=""></asp:Label>
                    </p>
                    <div class="form-group">
                        <asp:TextBox ID="txtUsername" runat="server" CssClass="form-control detail-font" placeholder="E-mail" />
                    </div>
                    <div class="form-group mt-2">
                        <asp:TextBox ID="txtPassword" runat="server" CssClass="form-control detail-font" TextMode="Password" placeholder="Password" />
                        <asp:Label ID="pwError" runat="server" Text="Password obbligatoria." CssClass="text-danger mt-2 detail-font" Visible="false"></asp:Label>
                    </div>
                    <div class="form-group">
                        <asp:Button ID="btnLogin" runat="server" Text="Login" CssClass="btn  mt-2 btnLogin detail-font"  OnClick="btnLogin_Click" />
                        <div class="mt-2 pb-3">
                            <asp:Label ID="lblRegistrati1" runat="server" Text="Username o password non validi. Se non hai un account, " Visible="false" CssClass="text-danger detail-font"></asp:Label>
                            <asp:LinkButton ID="LinkButton1" CssClass="detail-font" runat="server" PostBackUrl="~/Registrazione.aspx" Visible="false">Registrati</asp:LinkButton>
                        </div>
                    </div>
                </div>
            </div>
        </div>
    </div>

</asp:Content>
