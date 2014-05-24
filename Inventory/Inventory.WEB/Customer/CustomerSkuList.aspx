<%@ Page Title="" Language="C#" MasterPageFile="~/Inventory.Master" AutoEventWireup="true" CodeBehind="CustomerSkuList.aspx.cs" Inherits="Inventory.Web.CustomerSkuList" %>
<%@ Register Src="~/UserControl/PagerControl.ascx" TagName="PagerControls" TagPrefix="uc1" %>
<asp:Content ID="Content1" ContentPlaceHolderID="HeadContent" runat="server">
</asp:Content>

<asp:Content ID="Content3" ContentPlaceHolderID="MainContent" runat="server">
         <a href="CustomerSku.aspx"  class="button f-right">Add Customer SKU</a>
     <h1 class="title">Customer SKU List</h1>
    <div id="divGridView">
    <asp:GridView ID="GrdCustomerSku" runat="server" AutoGenerateColumns="False" class="dataGrid" Width="100%">
        <Columns>
            <asp:BoundField DataField="CustomerName" HeaderText="CustomerName" SortExpression="CustomerName" />
             <asp:BoundField DataField="StoreName" HeaderText="StoreName" SortExpression="StoreName" />
         
            <asp:BoundField DataField="ItemCode" HeaderText="ItemCode" SortExpression="ItemCode" />
            
              <asp:BoundField DataField="CustomerSkuCode" HeaderText="Customer Sku Code" SortExpression="CustomerSkuCode" />
            <asp:CheckBoxField DataField="Disable" HeaderText="Disable" SortExpression="Disable" />
            <asp:HyperLinkField DataNavigateUrlFields="Id" DataNavigateUrlFormatString="CustomerSku.aspx?id={0}" Text="Edit" />
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
