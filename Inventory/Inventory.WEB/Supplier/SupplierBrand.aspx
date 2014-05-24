<%@ Page Title="" Language="C#" MasterPageFile="~/Inventory.Master" AutoEventWireup="true" CodeBehind="SupplierBrand.aspx.cs" Inherits="Inventory.Web.Supplier.SupplierBrand" %>
<asp:Content ID="Content1" ContentPlaceHolderID="HeadContent" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">

    <h1 class="title">Add Brand</h1>

    <table class="formGrid" style="width: 50%;">
        <tr>
            <td>
                <asp:Label ID="Label1" Text="Select Supplier" runat="server" />
            </td>
            <td>
                <asp:DropDownList runat="server" ID="drpSupplier" Width="70%">
                    <asp:ListItem Text="text1" />
                    <asp:ListItem Text="text2" />
                </asp:DropDownList>
            </td>
        </tr>
        <tr>
            <td>
                <asp:Label ID="Label2" Text="Select Brand" runat="server" />
            </td>
            <td>
                <asp:ListBox ID="ListBox1" runat="server" SelectionMode="Multiple" Width="70%">
                    <asp:ListItem Text="Brand1" />
                    <asp:ListItem Text="Brand2" />
                    <asp:ListItem Text="Brand3" />
                    <asp:ListItem Text="Brand4" />
                    <asp:ListItem Text="Brand5" />
                    <asp:ListItem Text="Brand6" />
                    <asp:ListItem Text="Brand7" />
                    <asp:ListItem Text="Brand8" />
                </asp:ListBox>
            </td>
        </tr>
        <tr>
            <td></td>
            <td>
                <asp:Button Text="Submit" ID="btnSubmit" CssClass="button" runat="server" />
            </td>
        </tr>
    </table>


</asp:Content>
