<%@ Page Title="" Language="C#" MasterPageFile="~/Inventory.Master" AutoEventWireup="true" CodeBehind="ReturnNotesFromCustomer.aspx.cs" Inherits="Inventory.Web.Sales.ReturnNotesFromCustomer" %>

<asp:Content ID="Content1" ContentPlaceHolderID="HeadContent" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">
    <h1 class="title">Return Notes from Customer</h1>


    <table class="formGrid" width="100%">
        <tr>
            <td>
                <asp:Label Text="Item Code :" runat="server" />
            </td>
            <td>
                <asp:DropDownList runat="server" ID="drpItem">
                    <asp:ListItem Text="Item01" />
                    <asp:ListItem Text="Item02" />
                </asp:DropDownList>
            </td>
        </tr>
        <tr>
            <td>
                <asp:Label Text="Quantity :" runat="server" />
            </td>
            <td>
                <asp:TextBox runat="server" ID="txtQuantity" />
            </td>
        </tr>
        <tr>
            <td>
                <asp:Label Text="Location :" runat="server" />
            </td>
            <td>
                <asp:TextBox runat="server" ID="txtLocation" />
            </td>
        </tr>
        <tr>
            <td>
                <asp:Label Text="Status :" runat="server" />
            </td>
            <td>
                <asp:DropDownList runat="server" ID="drpStatus">
                    <asp:ListItem Text="Pending" />
                    <asp:ListItem Text="Completed" />
                </asp:DropDownList>
            </td>
        </tr>
        <tr>
            <td>
                <asp:Label Text="Notes :" runat="server" />
            </td>
            <td>
                <asp:TextBox runat="server" ID="txtNotes" TextMode="MultiLine" />
            </td>
        </tr>
        <tr>
            <td></td>
            <td>
                <asp:Button Text="Submit" CssClass="button" runat="server" />
            </td>
        </tr>
    </table>
</asp:Content>
