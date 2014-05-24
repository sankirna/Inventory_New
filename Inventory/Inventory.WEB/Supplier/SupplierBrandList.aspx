<%@ Page Title="" Language="C#" MasterPageFile="~/Inventory.Master" AutoEventWireup="true" CodeBehind="SupplierBrandList.aspx.cs" Inherits="Inventory.Web.Supplier.SupplierBrandList" %>

<asp:Content ID="Content1" ContentPlaceHolderID="HeadContent" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">
    <a href="SupplierBrand.aspx" class="button f-right">Add Supplier Brand</a>
    <h1 class="title">Add supplier Brand</h1>
    <asp:GridView runat="server" ID="grdSupplierBrand" AutoGenerateColumns="false"  CssClass="dataGrid" Width="50%">
        <Columns>
            <asp:BoundField HeaderText="Supplier" DataField="SupplierName" />
            <asp:BoundField HeaderText="Brand Name" DataField="BrandName" />
            <asp:CommandField ShowDeleteButton="True" />
        </Columns>
    </asp:GridView>

</asp:Content>
