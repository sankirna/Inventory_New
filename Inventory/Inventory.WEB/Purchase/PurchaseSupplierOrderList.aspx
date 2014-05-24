<%@ Page Title="" Language="C#" MasterPageFile="~/Inventory.Master" AutoEventWireup="true" CodeBehind="PurchaseSupplierOrderList.aspx.cs" Inherits="Inventory.Web.PurchaseSupplierOrderList" %>
<%@ Register Src="~/UserControl/PagerControl.ascx" TagName="PagerControls" TagPrefix="uc1" %>
<asp:Content ID="Content1" ContentPlaceHolderID="HeadContent" runat="server">
</asp:Content>

<asp:Content ID="Content3" ContentPlaceHolderID="MainContent" runat="server">
      <a href="PurchaseSupplierOrder.aspx" class="button f-right" >Add Purchase Order</a>
      <h1 class="title"> Purchase Order Supplier </h1>
    <div id="divGridView">
   
    <asp:GridView ID="GrdSupplierBrand" runat="server" AutoGenerateColumns="False" class="dataGrid">
        <Columns>
            <asp:BoundField DataField="SupplierName" HeaderText="SupplierName" SortExpression="SupplierName" />
            <asp:BoundField DataField="ItemCode" HeaderText="Item Code" SortExpression="ItemCode" />
            <asp:BoundField DataField="BarCode" HeaderText="BarCode" SortExpression="BarCode" />
            <asp:BoundField DataField="PurchaseCost" HeaderText="Purchase Cost" SortExpression="PurchaseCost" />
            <asp:BoundField DataField="Cost" HeaderText="Cost" SortExpression="Cost" />
            <asp:BoundField DataField="Quantity" HeaderText="Quantity" SortExpression="Quantity" />
            <asp:BoundField DataField="Amount" HeaderText="Amount" SortExpression="Amount" />
            <asp:CheckBoxField DataField="Disable" HeaderText="Disable" SortExpression="Disable" />
            <asp:HyperLinkField DataNavigateUrlFields="Id" DataNavigateUrlFormatString="PurchaseSupplierOrder.aspx?id={0}" Text="Edit" />
            <asp:CommandField ShowDeleteButton="True" />
        </Columns>
    </asp:GridView>
        </div>
     <div id="divPager" class="pagerbox" runat="server">
                <span class="pbleft">
                    <asp:Label ID="lblNoRecords" runat="server" Text="" SkinID="Warningred"></asp:Label>
                </span>
                <span class="pbcenter">
                    <asp:Label ID="CurrentPageNo" runat="server"></asp:Label>
                </span>
                <span class="pbright">
                    <uc1:PagerControls ID="Pager" runat="server" />
                </span>
                <div class="clear">
                </div>
            </div>

</asp:Content>
