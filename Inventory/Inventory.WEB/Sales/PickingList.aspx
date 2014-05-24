<%@ Page Title="" Language="C#" MasterPageFile="~/Inventory.Master" AutoEventWireup="true" CodeBehind="PickingList.aspx.cs" Inherits="Inventory.Web.Sales.PickingList1" %>

<%@ Register Assembly="AjaxControlToolkit" Namespace="AjaxControlToolkit" TagPrefix="asp" %>
<asp:Content ID="Content1" ContentPlaceHolderID="HeadContent" runat="server">
    <script type="text/javascript">
        function Show() {
            document.getElementById('<%=btnDummy.ClientID%>').click();
        }
    </script>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">
    <asp:ToolkitScriptManager ID="ToolkitScriptManager1" runat="server" CombineScripts="false"></asp:ToolkitScriptManager>
    <a href="Picking.aspx" class="button f-right">Create Picking List
    </a>
    <h1 class="title">Picking list </h1>
    <div id="divGridView">
        <asp:GridView ID="GrdPickingList" runat="server" AutoGenerateColumns="False" class="dataGrid" Width="100%">
            <Columns>
                <asp:BoundField DataField="SalesOrderId" HeaderText="Sales Order Id" />
                <asp:BoundField DataField="CustomerName" HeaderText="Customer Name" />
                <asp:BoundField DataField="StoreName" HeaderText="Store Name" />
                <asp:TemplateField HeaderText="Show ">
                    <ItemTemplate>
                        <a href="#" onclick="Show();">Show Product</a>
                    </ItemTemplate>
                </asp:TemplateField>
                <asp:TemplateField HeaderText="Action">
                    <ItemTemplate>
                        <a href="Picking.aspx">Edit</a>
                    </ItemTemplate>
                </asp:TemplateField>
                <asp:CommandField ShowDeleteButton="True" />
            </Columns>
        </asp:GridView>
    </div>
    <asp:Button Text="Dummy" ID="btnDummy" runat="server" Style="display: none" />
    <asp:ModalPopupExtender BackgroundCssClass="modalBackground" ID="mdl" runat="server"
        CancelControlID="btnClose" PopupControlID="pnl" TargetControlID="btnDummy">
    </asp:ModalPopupExtender>
    <asp:Panel ID="pnl" runat="server" GroupingText="Select Qty" BackColor="White">
        <asp:GridView ID="GrdInventoryProduct" runat="server" AutoGenerateColumns="False" class="dataGrid">
            <Columns>
                <asp:BoundField DataField="ItemCode" HeaderText="Item Code" />
                <asp:BoundField DataField="Barcode" HeaderText="Barcode" />
                <asp:BoundField DataField="Location" HeaderText="Location" />
                <asp:BoundField DataField="PurchaseCost" HeaderText="Retail Price" SortExpression="PurchaseCost" />
                <asp:BoundField DataField="MFGDate" HeaderText="Manufacturing Date" SortExpression="Quantity" />
                <asp:BoundField DataField="ExpDate" HeaderText="Expiry Date" SortExpression="Quantity" />
                <asp:BoundField DataField="Qty" HeaderText=" Qty" SortExpression="Quantity" />
            </Columns>
        </asp:GridView>

        <asp:Button Text="Close" ID="btnClose" runat="server" CssClass="button" />

    </asp:Panel>
</asp:Content>
