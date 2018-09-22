<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="CheckOut.aspx.cs" Inherits="AutoAddicts.CheckOut" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <h1>
        Checkout-Invoice
    </h1>

    <br />

    <asp:Label ID="lblCode" runat="server" Text="Discount Code: "></asp:Label>
    <asp:TextBox ID="txtDiscount" runat="server"></asp:TextBox>   
    <asp:Button ID="btnDiscount" runat="server" Text="Add Discount" Visible="true" OnClick="btnDiscount_Click"  />

    <asp:DropDownList ID="cmbDelivery" runat="server" >
            <asp:ListItem Value="1">1 Day Express Delivery</asp:ListItem>
            <asp:ListItem Value="2">5 Day Speedy Delivery</asp:ListItem>
            <asp:ListItem Value="3">7 Day Standard Delivery</asp:ListItem>
    </asp:DropDownList>

    <table>
        <tr>
            <td>
                <u>Price</u>
            </td>
            <td>
                <asp:Label ID="lblPrice" runat="server" ></asp:Label>
            </td>
        </tr>
        <tr>
            <td>
                <u>VAT</u>
            </td>
            <td>
                <asp:Label ID="lblVAT" runat="server" ></asp:Label>
            </td>
        </tr>
        <tr>
            <td>
                <u>Discount</u>
            </td>
            <td>
                <asp:Label ID="lblDiscount" runat="server" ></asp:Label>
            </td>
        </tr>
        <tr>
            <td>
                <u>Delivery</u>
            </td>
            <td>
                <asp:Label ID="lblDelivery" runat="server" ></asp:Label>
            </td>
        </tr>
        <tr>
            <td>
                <u>Total</u>
            </td>
            <td>
                <asp:Label ID="lblTotal" runat="server" ></asp:Label>
            </td>
        </tr>
    </table>

   <br />        
   <asp:Button ID="btnConfirm" runat="server" Text="Confirm Order" Visible="true" OnClick="btnConfirm_Click"  />
   <asp:Button ID="btnBuy" runat="server" Text="Buy" Visible="false" OnClick="btnBuy_Click"  />
        
    
</asp:Content>
