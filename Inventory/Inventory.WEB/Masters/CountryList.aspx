<%@ Page Title="" Language="C#" MasterPageFile="~/Inventory.Master" AutoEventWireup="true" CodeBehind="CountryList.aspx.cs" Inherits="Inventory.Web.CountryList" %>
<%@ Register Src="~/UserControl/PagerControl.ascx" TagName="PagerControls" TagPrefix="uc1" %>

<asp:Content ID="Content1" ContentPlaceHolderID="HeadContent" runat="server">
</asp:Content>

<asp:Content ID="Content3" ContentPlaceHolderID="MainContent" runat="server">

   <a href="Country.aspx" class="button f-right">Add Country</a>
      <h1 class="title">Country List </h1>
    <div id="divGridView">
        <asp:GridView ID="GrdCountry" runat="server" AutoGenerateColumns="false" class="dataGrid">
            <Columns>
                <asp:BoundField DataField="Name" HeaderText="Name" SortExpression="Name" />
                <asp:HyperLinkField DataNavigateUrlFields="Id" DataNavigateUrlFormatString="Country.aspx?id={0}" Text="Edit" />
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
