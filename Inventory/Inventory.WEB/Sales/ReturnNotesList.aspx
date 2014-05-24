<%@ Page Title="" Language="C#" MasterPageFile="~/Inventory.Master" AutoEventWireup="true" CodeBehind="ReturnNotesList.aspx.cs" Inherits="Inventory.Web.Sales.ReturnNotesList" %>

<asp:Content ID="Content1" ContentPlaceHolderID="HeadContent" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">
    <a href="ReturnNotesFromCustomer.aspx" class="button f-right">Create Return Notes 
    </a>
    <h1 class="title">Return notes list</h1>

    <asp:GridView ID="GrdInventoryProduct" runat="server" Width="100%" AutoGenerateColumns="False" class="dataGrid">
        <Columns>
            <asp:BoundField DataField="ItemCode" HeaderText="Item Code" />
            
            <asp:BoundField DataField="location" HeaderText="Location" />
         
           
            <asp:BoundField DataField="Qty" HeaderText=" Qty" SortExpression="Quantity" />
            <asp:BoundField DataField="Status" HeaderText="Status" SortExpression="Status" />
             <asp:BoundField DataField="Notes" HeaderText="Retail Price" SortExpression="PurchaseCost" />
        </Columns>
    </asp:GridView>
</asp:Content>
