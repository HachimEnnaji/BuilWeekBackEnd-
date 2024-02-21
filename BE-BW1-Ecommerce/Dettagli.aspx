<%@ Page Language="C#" AutoEventWireup="true" MasterPageFile="~/Site.Master" CodeBehind="Dettagli.aspx.cs" Inherits="BE_BW1_Ecommerce.Dettagli" %>

<asp:Content ID="CartContent" ContentPlaceHolderID="MainContent" runat="server">



              <h2>Dettagli</h2>
               <div class="row m-4 p-5 bg-opacity-75 rounded-3 cardDettagli"  runat="server">
                  <div class="col-3">
                    <asp:Image ID="Image1"  class="card-img-top" runat="server" AlternateText="Miniatura" />
                  <div class=" input-group mt-3 ">
                     <span class="input-group-btn">
                     <button type="button" class="btn btn-danger btn-number"  data-type="minus" data-field="quant[2]">
                       <span >-</span>
                     </button>
                     </span>
                       <input type="text" class="form-control input-number " size="2" value="1" min="1" max="10">
                       <span class="input-group-btn">
                      <button type="button" class="btn btn-success btn-number" data-type="plus" data-field="quant[2]">
                      <span >+</span>
                     </button>
                      </span>
                      </div>
                      </div>
                    <div class="col-9">
                      <h3 class="card-title" id="Titolo" runat="server"></h3>
                      <h4 class="card-title" id="Prezzo" runat="server"></h4>
                      <p class="card-text" id="Dettaglio" runat="server"></p>
                      <asp:Button ID="Button1" runat="server" Text="Aggiungi al carrello" OnClick="Button1_Click"/>

                    </div>
                </div>



    </asp:Content>
