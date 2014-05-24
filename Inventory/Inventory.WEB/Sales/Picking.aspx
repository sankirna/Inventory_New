<%@ Page Title="" Language="C#" MasterPageFile="~/Inventory.Master" AutoEventWireup="true" CodeBehind="Picking.aspx.cs" Inherits="Inventory.Web.Sales.PickingList" %>

<%@ Register Assembly="AjaxControlToolkit" Namespace="AjaxControlToolkit" TagPrefix="asp" %>

<asp:Content ID="Content1" ContentPlaceHolderID="HeadContent" runat="server">
    <script type="text/javascript">

        function Show() {


            document.getElementById('<%=btnDummy.ClientID%>').click();


}


</script>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">
  
    <asp:ToolkitScriptManager ID="ToolkitScriptManager1" CombineScripts="false" runat="server"></asp:ToolkitScriptManager>
    <h1 class="title">Create Picking List</h1>

  
            <table class="formGrid" width="100%">
                <tr>
                    <td>
                        <asp:Label ID="Label1" Text="Sales Order" runat="server" />
                      </td>
                    <td>
                          <asp:DropDownList runat="server" ID="drpSalesOrder">
                            <asp:ListItem Text="Item01" />
                            <asp:ListItem Text="Item02" />
                        </asp:DropDownList>
                        </td>
                </tr>
                <tr>
                    <td>
                        <asp:Label Text="Item Code" runat="server" />
                    </td>
                    <td>
                        <asp:DropDownList runat="server" ID="drpItemCode">
                            <asp:ListItem Text="Item01" />
                            <asp:ListItem Text="Item02" />
                        </asp:DropDownList>
                        <asp:ModalPopupExtender BackgroundCssClass="modalBackground" ID="mdl" runat="server" 
 
CancelControlID="btnClose" PopupControlID="pnl" TargetControlID="btnDummy"></asp:ModalPopupExtender>
                        <asp:Panel ID="pnl" runat="server" GroupingText="Select Qty" BackColor="White"> 
                            <asp:GridView ID="GrdInventoryProduct" runat="server" AutoGenerateColumns="False" class="dataGrid">
        <Columns>
            <asp:BoundField DataField="ItemCode" HeaderText="Item Code"/>
            <asp:BoundField DataField="Barcode" HeaderText="Barcode"/>
            <asp:BoundField DataField="Location" HeaderText="Location"  />

            <asp:BoundField DataField="PurchaseCost" HeaderText="Retail Price" SortExpression="PurchaseCost" />
          <asp:BoundField DataField="MFGDate" HeaderText="Manufacturing Date" SortExpression="Quantity" />
             <asp:BoundField DataField="ExpDate" HeaderText="Expiry Date" SortExpression="Quantity" />
            <asp:BoundField DataField="Qty" HeaderText="Available Qty" SortExpression="Quantity" />
           
          <asp:TemplateField HeaderText="Qty">
              
              <ItemTemplate>
                  <asp:TextBox ID="TxtQtyTake" runat="server"></asp:TextBox>
              </ItemTemplate>
          </asp:TemplateField>
         
        </Columns>
    </asp:GridView>
 
<asp:Button Text="Close" ID="btnClose" runat="server" CssClass="button" OnClick="btnClose_Click" /> 
 
                        </asp:Panel>
                    </td>
                </tr>
                <tr>
                    <td>
                        <asp:Button Text="Dummy" ID="btnDummy" runat="server" Style="display: none" /> 
                      
                    </td>
                    <td>
                       
                    </td>
                </tr>
                <tr>
                    <td colspan="2">
                        <asp:UpdatePanel ID="UpdatePanel1" runat="server">
                            <ContentTemplate>
                                <asp:GridView ID="GrdPickingListProduct" runat="server" AutoGenerateColumns="False" class="dataGrid">
        <Columns>
            <asp:BoundField DataField="ItemCode" HeaderText="Item Code"/>
            <asp:BoundField DataField="Barcode" HeaderText="Barcode"/>
            <asp:BoundField DataField="Location" HeaderText="Location"  />

            <asp:BoundField DataField="PurchaseCost" HeaderText="Retail Price" SortExpression="PurchaseCost" />
          <asp:BoundField DataField="MFGDate" HeaderText="Manufacturing Date" SortExpression="Quantity" />
             <asp:BoundField DataField="ExpDate" HeaderText="Expiry Date" SortExpression="Quantity" />
            <asp:BoundField DataField="Qty" HeaderText="Available Qty" SortExpression="Quantity" />
           
          <asp:TemplateField HeaderText="Qty">
              
              <ItemTemplate>
                12
              </ItemTemplate>
          </asp:TemplateField>
            <asp:CommandField ShowDeleteButton="True" />
        </Columns>
    </asp:GridView>
                            </ContentTemplate>
                            <Triggers>
                                <asp:AsyncPostBackTrigger ControlID="btnClose" />
                            </Triggers>
                        </asp:UpdatePanel>
                     
                    </td>
                </tr>
              
                <tr>
                    <td></td>
                    <td>
                        <asp:Button Text="Create Picking List" ID="btnSubmit" runat="server" CssClass="button" />
                    </td>
                </tr>
            </table>
      

</asp:Content>
