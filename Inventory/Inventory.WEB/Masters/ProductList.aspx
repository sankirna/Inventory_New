<%@ Page Title="" Language="C#" MasterPageFile="~/Inventory.Master" AutoEventWireup="true" CodeBehind="ProductList.aspx.cs" Inherits="Inventory.Web.ProductList" %>
<%@ Register Src="~/UserControl/PagerControl.ascx" TagName="PagerControls" TagPrefix="uc1" %>
<asp:Content ID="Content1" ContentPlaceHolderID="HeadContent" runat="server">
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="MainContent" runat="server">
      <asp:Button ID="btnProduct" CssClass="button f-right" runat="server" Text="Add Product" OnClick="btnProduct_Click"  Width="110px" />
    <h1 class="title">Product List</h1>
    
    <div class="searchBox br6">
        <label>
            Supplier Code</label>
        <asp:DropDownList ID="drpSupplier" runat="server" CssClass="combobox" AppendDataBoundItems="True">
        </asp:DropDownList>
        
        
        <asp:Button ID="btnSearch" CssClass="button" runat="server" Text="Search" OnClick="btnSearch_Click"  />
        <asp:Button ID="btnExport" CssClass="button" runat="server" Text="Export to Excel"  />
    </div>
       <div id="divGridView">
    <asp:GridView ID="grdProduct" runat="server" AutoGenerateColumns="false" class="dataGrid" Width="100%" CellPadding="0" CellSpacing="0" Style="margin-top: 0px;" OnRowCommand="grdProduct_RowCommand" >
        <Columns>
           <%-- <asp:BoundField DataField="Name" HeaderText="Name" SortExpression="Name" />--%>
            
           
            <asp:BoundField DataField="ItemCode" HeaderText="Item Code" />
            <asp:BoundField DataField="MFBarcode" HeaderText="Bar Code" />
            <asp:BoundField DataField="BasicPC" HeaderText="Basic Cost" />
            <asp:BoundField DataField="DateCreated" HeaderText="Created Date" />
             <asp:TemplateField HeaderText="Edit">
                <ItemTemplate>
                    <a href='<%# "Product.aspx?id=" + Eval("ProductID") %>' ><img src="../Images/edit.png" /></a>
                </ItemTemplate>
            </asp:TemplateField>
            <asp:TemplateField HeaderText="Delete">
                <ItemTemplate>
                  
                    <asp:ImageButton ID="ImageButton1" runat="server" ImageUrl="~/Images/delete.png" CommandName="del" OnClientClick="return confirm('Are you sure you want to delte Product?')" CommandArgument='<%# Eval("ProductID") %>'  />
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
