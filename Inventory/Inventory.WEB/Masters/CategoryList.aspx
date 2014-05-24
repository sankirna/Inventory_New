<%@ Page Title="" Language="C#" MasterPageFile="~/Inventory.Master" AutoEventWireup="true" CodeBehind="CategoryList.aspx.cs" Inherits="Inventory.Web.CategoryList" %>
<%@ Register Src="~/UserControl/PagerControl.ascx" TagName="PagerControls" TagPrefix="uc1" %>
<asp:Content ID="Content1" ContentPlaceHolderID="HeadContent" runat="server">
</asp:Content>

<asp:Content ID="Content3" ContentPlaceHolderID="MainContent" runat="server">
     <a href="Category.aspx" class="button f-right" >Add Category</a>
      <h1 class="title"> 
          Category List
      </h1>
   <div id="divGridView">
    <asp:GridView ID="GrdCategory" runat="server" AutoGenerateColumns="false" class="dataGrid">
        <Columns>
            <asp:BoundField DataField="Name" HeaderText="Name" SortExpression="Name" />
            <asp:HyperLinkField DataNavigateUrlFields="Id" DataNavigateUrlFormatString="Category.aspx?id={0}" Text="Edit" />
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
