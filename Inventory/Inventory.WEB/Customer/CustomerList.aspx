<%@ Page Title="" Language="C#" MasterPageFile="~/Inventory.Master" AutoEventWireup="true" CodeBehind="CustomerList.aspx.cs" Inherits="Inventory.Web.Customer.CustomerList" %>

<%@ Register Src="~/UserControl/PagerControl.ascx" TagName="PagerControls" TagPrefix="uc1" %>
<asp:Content ID="Content1" ContentPlaceHolderID="HeadContent" runat="server">
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="MainContent" runat="server">
    <a href="CustomerSetup.aspx" class="button f-right">Add new Customer</a>
    <h1 class="title">Customer List </h1>
    <div id="divGridView">
        <asp:GridView ID="GrdCusomer" runat="server" AutoGenerateColumns="false" class="dataGrid" Width="100%">
            <Columns>
                <asp:BoundField DataField="CustomerName" HeaderText="Customer Name" SortExpression="CustomerName" />
                <asp:BoundField DataField="Address1" HeaderText="Address1" SortExpression="Address1" />
                <asp:BoundField DataField="Address2" HeaderText="Address2" SortExpression="Address2" />
                <asp:BoundField DataField="Street" HeaderText="Street" SortExpression="Street" />
                <asp:BoundField DataField="City" HeaderText="City" SortExpression="City" />
                <asp:BoundField DataField="Country" HeaderText="Country" SortExpression="Country" />
                <asp:BoundField DataField="Email" HeaderText="Email" SortExpression="Email" />
                <asp:BoundField DataField="Store" HeaderText="Store" SortExpression="Store" />
                <asp:BoundField DataField="TelephoneNo" HeaderText="Telephone #" SortExpression="TelephoneNo" />
                <asp:HyperLinkField DataNavigateUrlFields="CustomerId" DataNavigateUrlFormatString="CustomerSetup.aspx?id={0}" Text="Edit" />
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
