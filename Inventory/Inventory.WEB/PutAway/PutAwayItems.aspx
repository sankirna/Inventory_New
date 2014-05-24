<%@ Page Title="" Language="C#" MasterPageFile="~/Inventory.Master" AutoEventWireup="true" CodeBehind="PutAwayItems.aspx.cs" Inherits="Inventory.Web.PutAway.PutAwayItems" %>
<asp:Content ID="Content1" ContentPlaceHolderID="HeadContent" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">
    
    <h1 class="title">Put Away the Items</h1>

    <asp:GridView ID="GrdInventoryProduct" runat="server" AutoGenerateColumns="False" class="dataGrid" Width="100%">
        <Columns>
            <asp:BoundField DataField="ItemCode" HeaderText="Item Code" />
            <asp:BoundField DataField="Barcode" HeaderText="Barcode" />
            <asp:BoundField DataField="Location" HeaderText="Location" />
            <asp:BoundField DataField="PurchaseCost" HeaderText="Retail Price" SortExpression="PurchaseCost" />
            <%--<asp:BoundField DataField="MFGDate" HeaderText="Manufacturing Date" SortExpression="Quantity" />--%>
            <asp:BoundField DataField="ExpDate" HeaderText="Expiry Date" SortExpression="Quantity" />
            <%--<asp:BoundField DataField="Qty" HeaderText=" Qty" SortExpression="Quantity" />--%>
            
            <asp:TemplateField HeaderText="New Location ">
                <ItemTemplate>
                    <asp:TextBox ID="txtNewLocation" runat="server" Width="80px" Text="" />
                </ItemTemplate>
            </asp:TemplateField>            
              <asp:TemplateField HeaderText="Action">
                <ItemTemplate>
                    <asp:Button Text="Edit" ID="btnEdit" runat="server" CssClass="button" />
                </ItemTemplate>
            </asp:TemplateField>  

        </Columns>
    </asp:GridView>

</asp:Content>
