<%@ Page Title="" Language="C#" MasterPageFile="~/Inventory.Master" AutoEventWireup="true" CodeBehind="PickingListForOperator.aspx.cs" Inherits="Inventory.Web.Sales.PickingListForOperator" %>
<asp:Content ID="Content1" ContentPlaceHolderID="HeadContent" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">
     <h1 class="title">Create Picking List</h1>

  
            <table class="formGrid" width="100%">
                <tr>
                    <td>
                        <asp:Label ID="Label1" runat="server" Text="Sales Order"></asp:Label>

                    </td>
                    <td>
                        <asp:DropDownList ID="DrpSalesOrder" runat="server">
                            <asp:ListItem Text="Item1">

                            </asp:ListItem>
                             <asp:ListItem Text="Item2">

                            </asp:ListItem>
                        </asp:DropDownList>
                    </td>
                </tr>
                <tr>
                    <td colspan="2">
                        <asp:GridView ID="GrdInventoryProduct" runat="server" Width="100%" AutoGenerateColumns="False" class="dataGrid">
        <Columns>
            <asp:BoundField DataField="ItemCode" HeaderText="Item Code"/>
            <asp:BoundField DataField="Barcode" HeaderText="Barcode"/>
            <asp:BoundField DataField="Location" HeaderText="Location"  />

            <asp:BoundField DataField="PurchaseCost" HeaderText="Retail Price" SortExpression="PurchaseCost" />
          <asp:BoundField DataField="MFGDate" HeaderText="Manufacturing Date" SortExpression="Quantity" />
             <asp:BoundField DataField="ExpDate" HeaderText="Expiry Date" SortExpression="Quantity" />
            <asp:BoundField DataField="Qty" HeaderText=" Qty" SortExpression="Quantity" />
           
          <asp:TemplateField HeaderText="Qty">
              
              <ItemTemplate>
                  <asp:TextBox ID="TxtQtyTake" runat="server"></asp:TextBox>
              </ItemTemplate>
          </asp:TemplateField>
         
        </Columns>
    </asp:GridView>
                        </td>
                </tr>
                <tr>
                    <td colspan="2">
                        <asp:Button ID="btnSave" runat="server" Text="Submit Discrepany" CssClass="button" />
                        &nbsp;</td>
                </tr>
                </table>
</asp:Content>
