<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Registrazione.aspx.cs" Inherits="BE_BW1_Ecommerce.WebForm1" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <div class="container">
        <div class="row">
            <div class="col-md-6">
                <h2>Registrazione</h2>
                    <div class="form-group">
                        <label for="nome">Nome</label>
                        <asp:TextBox ID="txtNome" runat="server" CssClass="form-control"></asp:TextBox>
                        <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="txtNome" ErrorMessage="Campo obbligatorio." CssClass="text-danger fw-bold" />
                        </div>
                    <div class="form-group">
                        <label for="cognome">Cognome</label>
                        <asp:TextBox ID="txtCognome" runat="server" CssClass="form-control"></asp:TextBox>
                        <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ControlToValidate="txtCognome" ErrorMessage="Campo obbligatorio." CssClass="text-danger fw-bold"/>
                        </div>
                    <div class="form-group">
                        <label for="username">Username</label>
                        <asp:TextBox ID="txtUsername" runat="server" CssClass="form-control"></asp:TextBox>
                        <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" ControlToValidate="txtUsername" ErrorMessage="Campo obbligatorio." CssClass="text-danger fw-bold"/>
                        </div>
                    <div class="form-group">
                        <label for="password">Password</label>
                        <asp:TextBox ID="txtPassword" runat="server" TextMode="Password" CssClass="form-control"></asp:TextBox>
                        <asp:RequiredFieldValidator ID="RequiredFieldValidator4" runat="server" ControlToValidate="txtPassword" ErrorMessage="Campo obbligatorio." CssClass="text-danger fw-bold"/>
                        </div>
                    <div class="form-group">
                        <label for="email">Email</label>
                        <asp:TextBox ID="txtEmail" runat="server" CssClass="form-control"></asp:TextBox>
                        <asp:RequiredFieldValidator ID="RequiredFieldValidator5" runat="server" ControlToValidate="txtEmail" ErrorMessage="Campo obbligatorio." CssClass="text-danger fw-bold"/>
                        </div>
                    <asp:Button ID="btnRegistra" runat="server" Text="Registra" CssClass="btn btn-primary" OnClick="btnRegistra_Click"/>
                </div>
            </div>
        </div>
</asp:Content>
