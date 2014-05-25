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
    <asp:GridView ID="GrdCategory" runat="server" AutoGenerateColumns="False" class="dataGrid" Width="100%" OnRowCommand="GrdCategory_RowCommand">
        <Columns>
            <asp:BoundField DataField="CategoryName" HeaderText="Category Name" SortExpression="Name" />
            <asp:BoundField DataField="DateCreated" HeaderText="Created Date" SortExpression="Name" />

           
            <asp:TemplateField>
         
                <ItemTemplate>
                 <a href='<%# "Category.aspx?CatID=" + Eval("CategoryID") %>'> <img src="../Images/edit.png"/></a>
                </ItemTemplate>
         
            </asp:TemplateField>
            <asp:TemplateField>
                <ItemTemplate>
                    <asp:ImageButton ID="ImageButton1" runat="server" OnClientClick="return confirm('Are you sure to delete Category?');" ImageUrl="../Images/delete.png"  CommandName="del" CommandArgument='<%# Eval("CategoryID") %>'/>
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

</asp:Content>
