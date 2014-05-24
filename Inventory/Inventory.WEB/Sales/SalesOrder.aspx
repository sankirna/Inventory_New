<%@ Page Title="" Language="C#" MasterPageFile="~/Inventory.Master" AutoEventWireup="true" CodeBehind="SalesOrder.aspx.cs" Inherits="Inventory.Web.SalesOrder" %>

<asp:Content ID="Content1" ContentPlaceHolderID="HeadContent" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">

    <h1 class="title">Sales Order for Supplier</h1>



    <table class="formGrid" width="100%">
        <tr>
            <td>
                <asp:Label Text="Customer Name" ID="lblCustomerNm" runat="server" />
            </td>
            <td>
                <asp:DropDownList runat="server" ID="drpCutmrNam"></asp:DropDownList>
            </td>
        </tr>
        <tr>
            <td>
                <asp:Label Text="Store Name" runat="server" ID="lblStoreNm" />
            </td>
            <td>
                <asp:DropDownList runat="server" ID="drpStoreNm"></asp:DropDownList>
            </td>
        </tr>
        <tr>
            <td colspan="2">
                <b>Add Item ::</b>
            </td>
        </tr>
    </table>



    <table class="formGrid">
        <tr>
            <td>
                <asp:DropDownList runat="server" ID="drpItemCode">
                    <asp:ListItem Text="Item01" />
                    <asp:ListItem Text="Item02" />
                </asp:DropDownList></td>
            <td>
                <asp:TextBox runat="server" ID="txtDesc" />
            </td>
            <td>
                <asp:Label Text="Barcode" ID="lblBarcode" runat="server" />
            </td>
            <td>
                <asp:TextBox runat="server" ID="txtQtyOrder" />
            </td>
            <td>
                <asp:Button Text="Add Item" runat="server" CssClass="button" />
            </td>
        </tr>
    </table>
    <asp:GridView runat="server" ID="grdItem" AutoGenerateColumns="False" class="dataGrid" Width="100%">
        <Columns>
            <asp:TemplateField HeaderText="Item Code">
                <ItemTemplate>
                                    <asp:DropDownList runat="server" ID="drpItemCode">
                                    <asp:ListItem Text="Item01" />
                                    <asp:ListItem Text="Item02" />
                                </asp:DropDownList>
                </ItemTemplate>
            </asp:TemplateField>
            <asp:TemplateField HeaderText="Description">
                <ItemTemplate>
                    <asp:Label Text="Item  Description" runat="server" ID="lblDesc" />
                </ItemTemplate>
            </asp:TemplateField>
            <asp:TemplateField HeaderText="Barcode">
                <ItemTemplate>
                    <asp:Label Text="Barcode" runat="server" ID="lblBarcode" />
                </ItemTemplate>
            </asp:TemplateField>
            <asp:TemplateField HeaderText="Quantity">
                <ItemTemplate>
                    <asp:TextBox runat="server" ID="txtQtyOrder" />
                </ItemTemplate>
            </asp:TemplateField>
            <asp:TemplateField>
                <ItemTemplate>
                    <asp:Button Text="Add" ID="btnAdd" runat="server" CssClass="button" />
                </ItemTemplate>
            </asp:TemplateField>

            
        </Columns>


    </asp:GridView>

    <div>
        <asp:Button Text="Submit" ID="btnSubmit" runat="server" CssClass="button" />
    </div>

</asp:Content>
