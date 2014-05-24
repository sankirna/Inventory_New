<%@ Page Title="" Language="C#" MasterPageFile="~/Inventory.Master" AutoEventWireup="true" CodeBehind="InventoryAdjustment.aspx.cs" Inherits="Inventory.Web.Sales.InventoryAdjustment" %>

<%@ Register Assembly="AjaxControlToolkit" Namespace="AjaxControlToolkit" TagPrefix="asp" %>
<asp:Content ID="Content1" ContentPlaceHolderID="HeadContent" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">
    <asp:ToolkitScriptManager ID="ToolkitScriptManager1" runat="server" CombineScripts="false"></asp:ToolkitScriptManager>
    <h1 class="title">Adjustment Inventory</h1>
    <asp:GridView ID="GrdInventoryProduct" runat="server" AutoGenerateColumns="False" class="dataGrid" Width="100%">
        <Columns>
            <asp:BoundField DataField="ItemCode" HeaderText="Item Code" />
            <asp:BoundField DataField="Barcode" HeaderText="Barcode" />
            <asp:BoundField DataField="Location" HeaderText="Location" />

            <asp:BoundField DataField="PurchaseCost" HeaderText="Retail Price" SortExpression="PurchaseCost" />
            <%--<asp:BoundField DataField="MFGDate" HeaderText="Manufacturing Date" SortExpression="Quantity" />--%>
            <asp:BoundField DataField="ExpDate" HeaderText="Expiry Date" SortExpression="Quantity" />
            <%--<asp:BoundField DataField="Qty" HeaderText=" Qty" SortExpression="Quantity" />--%>
            <asp:TemplateField HeaderText="MFG Date ">
                <ItemTemplate>
                    <asp:TextBox ID="txtMFGdt" runat="server" Text='<%# Eval("MFGDate") %>' />
                    <asp:CalendarExtender TargetControlID="txtMFGdt" runat="server" ID="calMFGdt"></asp:CalendarExtender>
                </ItemTemplate>
            </asp:TemplateField>
            <asp:TemplateField HeaderText="Quanitiy ">
                <ItemTemplate>
                    <asp:TextBox runat="server" Width="80px" Text='<%# Eval("Qty") %>' />
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
