<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="AdminPage.aspx.cs" Inherits="AutoAddicts.Admin.AdminPage" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <div style="text-align: center;">
    <h1><u><b>Administration</b></u></h1>
    <br />
    <br//>
    <h3><b><u>Add Product:</u></b></h3>
        <br />
    <table style="margin: 0 auto;">
        <tr>
            <td><asp:Label ID="LabelAddCategory" runat="server"><b>Category:</b></asp:Label></td>
            <td>
                <asp:DropDownList ID="DropDownAddCategory" runat="server" 
                    ItemType="AutoAddicts.Models.Category" 
                    SelectMethod="GetCategories" DataTextField="CategoryName" 
                    DataValueField="CategoryID" >
                </asp:DropDownList>
            </td>
        </tr>
        
        <tr>
            <td>
                <br />
            </td>
        </tr>

        <tr>
            <td><asp:Label ID="LabelAddName" runat="server"><b>Name:</b></asp:Label></td>
            <td>
                <asp:TextBox ID="AddProductName" runat="server"></asp:TextBox>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" Text="* Product name required." ControlToValidate="AddProductName" SetFocusOnError="true" Display="Dynamic"></asp:RequiredFieldValidator>
            </td>
        </tr>
        <tr>
            <td><asp:Label ID="LabelAddDescription" runat="server"><b>Description:</b></asp:Label></td>
            <td>
                <asp:TextBox ID="AddProductDescription" runat="server"></asp:TextBox>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" Text="* Description required." ControlToValidate="AddProductDescription" SetFocusOnError="true" Display="Dynamic"></asp:RequiredFieldValidator>
            </td>
        </tr>
        <tr>
            <td><asp:Label ID="LabelAddPrice" runat="server"><b>Price:</b></asp:Label></td>
            <td>
                <asp:TextBox ID="AddProductPrice" runat="server"></asp:TextBox>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" Text="* Price required." ControlToValidate="AddProductPrice" SetFocusOnError="true" Display="Dynamic"></asp:RequiredFieldValidator>
                <asp:RegularExpressionValidator ID="RegularExpressionValidator1" runat="server" Text="* Must be a valid price without $." ControlToValidate="AddProductPrice" SetFocusOnError="True" Display="Dynamic" ValidationExpression="^[0-9]*(\.)?[0-9]?[0-9]?$"></asp:RegularExpressionValidator>
            </td>
        </tr>
        <tr>
            <td><asp:Label ID="LabelAddWarranty" runat="server"><b>Waranty Period:</b></asp:Label></td>
            <td>
                <asp:TextBox ID="AddWarranty" runat="server"></asp:TextBox>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator5" runat="server" Text="* Warranty period required." ControlToValidate="AddWarranty" SetFocusOnError="true" Display="Dynamic"></asp:RequiredFieldValidator>
            </td>
        </tr>
        <tr>
            <td>
                <br />
            </td>
        </tr>
        <tr>
            <td><asp:Label ID="LabelAddImageFile" runat="server"><b>Image File:</b></asp:Label></td>
            <td>
                <asp:FileUpload ID="ProductImage" runat="server" />
                <asp:RequiredFieldValidator ID="RequiredFieldValidator4" runat="server" Text="* Image path required." ControlToValidate="ProductImage" SetFocusOnError="true" Display="Dynamic"></asp:RequiredFieldValidator>
            </td>
        </tr>
    </table>
    <p></p>
    <p></p>
        <br />
    <asp:Button ID="AddProductButton" runat="server" Text="Add Product" OnClick="AddProductButton_Click"  CausesValidation="true"/>
    <asp:Label ID="LabelAddStatus" runat="server" Text=""></asp:Label>
    <p></p>
        <br />
        <br />
    <h3><u><b>Remove Product:</b></u></h3>
        <br />
    <table style="margin: 0 auto;">
        <tr>
            <td><asp:Label ID="LabelRemoveProduct" runat="server"><b>Product:</b></asp:Label></td>
            <td><asp:DropDownList ID="DropDownRemoveProduct" runat="server" ItemType="AutoAddicts.Models.Product" 
                    SelectMethod="GetProducts" AppendDataBoundItems="true" 
                    DataTextField="ProductName" DataValueField="ProductID" >
                </asp:DropDownList>
            </td>
        </tr>
    </table>
    <p></p>
        <br />
    <asp:Button ID="RemoveProductButton" runat="server" Text="Remove Product" OnClick="RemoveProductButton_Click" CausesValidation="false"/>
    <asp:Label ID="LabelRemoveStatus" runat="server" Text=""></asp:Label>
        <br />
        <br />
    <h3><b><u>Modify Product</u></b></h3>
        <br />
    <table style="margin: 0 auto;">
        <tr>
            <td><asp:Label ID="lblModifyCategory" runat="server"><b>Category:</b></asp:Label></td>
            <td><asp:DropDownList ID="cmbCategory" runat="server" ItemType="AutoAddicts.Models.Product" 
                        SelectMethod="GetProducts" AppendDataBoundItems="true" 
                        DataTextField="ProductName" DataValueField="ProductID" >
                </asp:DropDownList>
            </td>
        </tr>
        <tr>
            <td>
                <br />
            </td>
        </tr>
        <tr>
            <td><asp:Label ID="lblName" runat="server"><b>Name:</b></asp:Label></td>
            <td>
                <asp:TextBox ID="txtName" runat="server"></asp:TextBox>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator6" runat="server" Text="* Product name required." ControlToValidate="AddProductName" SetFocusOnError="true" Display="Dynamic"></asp:RequiredFieldValidator>
            </td>
        </tr>
        <tr>
            <td><asp:Label ID="lblDesc" runat="server"><b>Description:</b></asp:Label></td>
            <td>
                <asp:TextBox ID="txtDesc" runat="server"></asp:TextBox>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator7" runat="server" Text="* Description required." ControlToValidate="AddProductDescription" SetFocusOnError="true" Display="Dynamic"></asp:RequiredFieldValidator>
            </td>
        </tr>
        <tr>
            <td><asp:Label ID="lblPrice" runat="server"><b>Price:</b></asp:Label></td>
            <td>
                <asp:TextBox ID="txtPrice" runat="server"></asp:TextBox>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator8" runat="server" Text="* Price required." ControlToValidate="AddProductPrice" SetFocusOnError="true" Display="Dynamic"></asp:RequiredFieldValidator>
                <asp:RegularExpressionValidator ID="RegularExpressionValidator2" runat="server" Text="* Must be a valid price without $." ControlToValidate="AddProductPrice" SetFocusOnError="True" Display="Dynamic" ValidationExpression="^[0-9]*(\.)?[0-9]?[0-9]?$"></asp:RegularExpressionValidator>
            </td>
        </tr>
        <tr>
            <td><asp:Label ID="lblWarranty" runat="server"><b>Waranty Period:</b></asp:Label></td>
            <td>
                <asp:TextBox ID="txtWarranty" runat="server"></asp:TextBox>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator9" runat="server" Text="* Warranty period required." ControlToValidate="AddWarranty" SetFocusOnError="true" Display="Dynamic"></asp:RequiredFieldValidator>
            </td>
        </tr>
       
    </table>
    <p></p>
    <p></p>
        <br />
    <asp:Button ID="ModifyProductButton" runat="server" Text="Modify Prduct" OnClick="ModifyProductButton_Click" CausesValidation="false" />
    </div>
</asp:Content>