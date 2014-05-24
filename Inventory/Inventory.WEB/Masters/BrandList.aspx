<%@ Page Title="" Language="C#" MasterPageFile="~/Inventory.Master" AutoEventWireup="true" CodeBehind="BrandList.aspx.cs" Inherits="Inventory.Web.BrandList" %>
<%@ Register Src="~/UserControl/PagerControl.ascx" TagName="PagerControls" TagPrefix="uc1" %>
<asp:Content ID="Content1" ContentPlaceHolderID="HeadContent" runat="server">
</asp:Content>

<asp:Content ID="Content3" ContentPlaceHolderID="MainContent" runat="server">
     <a href="Brand.aspx" class="button f-right">Add Brand</a>
    <h1 class="title">Brand List</h1>
    <div id="divGridView">
    <asp:GridView ID="GrdBrand" runat="server" AutoGenerateColumns="false" Width="100%"  class="dataGrid">
        <Columns>
            <asp:BoundField DataField="BrandName" HeaderText="Brand Name" SortExpression="Name" />
              <asp:BoundField DataField="DateCreated" HeaderText="Created Date"  />
           
            <asp:TemplateField HeaderText="Edit">
                <ItemTemplate>
                  <a href='<%# "Brand.aspx?BrandId=" + Eval("BrandId") %>'><img src="../Images/edit.png" /></a>
                </ItemTemplate>
            </asp:TemplateField>
             <asp:TemplateField HeaderText="Delete">
                <ItemTemplate>
                    <asp:ImageButton ID="ImageButton1" ImageUrl="~/Images/delete.png" CommandArgument='<%# Eval("BrandID") %>' CommandName="del" runat="server" />
                </ItemTemplate>
            </asp:TemplateField>
           
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
    <asp:HiddenField ID="hdnPageSize" runat="server" Value="" />
    <asp:HiddenField ID="hdnPageButtonCount" runat="server" Value="" />
    <asp:HiddenField ID="hdnTotalRecords" runat="server" Value="" />
    <asp:HiddenField ID="hdnCurrentPageIndex" runat="server" Value="" />
     <asp:HiddenField ID="hdnSupplierID" runat="server" Value="" />
</asp:Content>
