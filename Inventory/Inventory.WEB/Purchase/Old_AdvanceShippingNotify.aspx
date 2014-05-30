<%@ Page Title="" Language="C#" MasterPageFile="~/Inventory.Master" AutoEventWireup="true" CodeBehind="Old_AdvanceShippingNotify.aspx.cs" Inherits="Inventory.Web.Purchase.AdvanceShippingNotify" %>

<%@ Register Assembly="AjaxControlToolkit" Namespace="AjaxControlToolkit" TagPrefix="asp" %>
<asp:Content ID="Content1" ContentPlaceHolderID="HeadContent" runat="server">
    <script src="../Scripts/Purchase/ASN.js"></script>

</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">
    <asp:ToolkitScriptManager ID="ToolkitScriptManager1" runat="server" CombineScripts="false"></asp:ToolkitScriptManager>
    <h1 class="title">INVOICE /PACKING LIST</h1>

    <div class="hidden">
        <asp:HiddenField ID="hdSupplierId" runat="server" />
    </div>
    <table class="formGrid" width="100%" cellpadding="0" cellspacing="0">
        <tr>
            <td>
                <asp:Label ID="lblSupplier" runat="server">Supplier</asp:Label><span class="mandatory">*</span>
            </td>
            <td>
                <asp:TextBox runat="server" ReadOnly="true" ID="txtSupplier"  >
           
                </asp:TextBox>

            </td>
        </tr>

        <tr>
            <td>
                <asp:Label ID="lblPONo" runat="server">PO No:</asp:Label><span class="mandatory">*</span>
            </td>
            <td>
                <asp:TextBox ID="txtPONo" ReadOnly="true" CssClass="NonEntry" runat="server"></asp:TextBox>
            </td>

        </tr>
        <tr>
            <td>
                <asp:Label ID="lblDate" runat="server">PO Date:</asp:Label><span class="mandatory">*</span>
            </td>
            <td>
                <asp:TextBox ID="txtPODate" ReadOnly="true" CssClass="NonEntry"  runat="server"></asp:TextBox>
            </td>

        </tr>

        <tr>
            <td>
                <asp:Label ID="lblETD" runat="server">ETA:</asp:Label><span class="mandatory">*</span>
            </td>
 

            <td>
                <asp:TextBox ID="txtETD" CssClass="NonEntry calender" runat="server"></asp:TextBox>
            </td>

        </tr>

        <tr>
            <td>
                <asp:Label ID="lblPINo" runat="server">PI No:</asp:Label><span class="mandatory">*</span>
            </td>
            <td>
                <asp:TextBox ID="txtPINo" runat="server"></asp:TextBox>
            </td>

        </tr>

        <tr>
            <td>
                <asp:Label ID="Label1" runat="server">From:</asp:Label><span class="mandatory">*</span>
            </td>
            <td>
                <asp:TextBox ID="txtCountryFrom" runat="server" CssClass="calender"></asp:TextBox>
            </td>

        </tr>
        <tr>
            <td>
                <asp:Label ID="Label2" runat="server">To:</asp:Label><span class="mandatory">*</span>
            </td>
            <td>
                <asp:TextBox ID="txtCountryTo" runat="server" CssClass="calender"></asp:TextBox>
            </td>

        </tr>
    </table>
    <div id="divGridView">
        <asp:GridView ID="grdPackingList" runat="server" class="dataGrid" AutoGenerateColumns="False"
            Width="100%" CellPadding="0" CellSpacing="0" Style="margin-top: 0px;">
            <Columns>

                <asp:TemplateField>
                    <HeaderTemplate>
                        Serial No.
                    </HeaderTemplate>
                    <ItemTemplate>
                        <asp:Label ID="lblSRNO" runat="server"
                            Text='<%#Container.DataItemIndex+1 %>'></asp:Label>
                        <asp:HiddenField ID="hdASNProductDetailsID" runat="server" Value='<%# Eval("ASNProductDetailsID") %>'/>
                        <asp:HiddenField ID="hdASNID" runat="server"  Value='<%# Eval("ASNID") %>'/>
                    </ItemTemplate>
                </asp:TemplateField>
                <asp:TemplateField HeaderText="Carton Starting No">
                    <ItemTemplate>
                        <asp:TextBox runat="server" Width="20px" ID="txtStartinNo" CssClass="number"></asp:TextBox>
                    </ItemTemplate>
                </asp:TemplateField>
                <asp:TemplateField HeaderText="Carton Ending No">
                    <ItemTemplate>
                        <asp:TextBox Width="20px" runat="server" ID="txtEndNo" CssClass="number"></asp:TextBox>
                    </ItemTemplate>
                </asp:TemplateField>
                <asp:TemplateField HeaderText="ItemCode">
                    <ItemTemplate>
                        <asp:DropDownList runat="server" ID="drpItemCode" DataSource='<%# Eval("Products") %>' DataTextField="Code" DataValueField="ProductID" SelectedValue='<%# Eval("ProductID") %>'
                            CssClass="drp-item">
                        </asp:DropDownList>
                    </ItemTemplate>
                </asp:TemplateField>
                     <asp:TemplateField HeaderText="Description">
                    <ItemTemplate>
                        <asp:Label runat="server" Width="200px" ID="lblDescription" CssClass="po-desc"></asp:Label>
                    </ItemTemplate>
                </asp:TemplateField>
                <asp:TemplateField HeaderText="BarCode">
                    <ItemTemplate>
                        <asp:Label runat="server" Width="120px" ID="lblBarCode" CssClass="po-barcode"></asp:Label>
                    </ItemTemplate>
                </asp:TemplateField>
                <asp:TemplateField HeaderText="Purchase Cost">
                    <ItemTemplate>
                        
                      <span style="display:inline" class="currecy"></span>  <asp:Label runat="server" Width="80px" ID="lblPurchaseCost"  CssClass="po-cost"></asp:Label>
                           
                    </ItemTemplate>
                </asp:TemplateField>
                            <asp:TemplateField HeaderText="Unit Price">
                    <ItemTemplate>
                        <span style="display:inline" class="currecy"></span>
                        <asp:TextBox runat="server" Width="50px" ID="txtCost" CssClass="po-costedit number" Text='<%# Eval("UnitPrice") %>'></asp:TextBox>
                    </ItemTemplate>
                </asp:TemplateField>
                <asp:TemplateField HeaderText="Quantity">
                    <ItemTemplate>
                        <span style="display:inline" class="currecy"></span>
                        <asp:TextBox runat="server" Width="50px" ID="txtQty" CssClass="po-qua number" Text='<%# Eval("Qty") %>'></asp:TextBox>
                    </ItemTemplate>
                </asp:TemplateField>
                <asp:TemplateField HeaderText="Amount (S$)">
                    <ItemTemplate>
                       <span style="display:inline" class="currecy"></span>
                         <asp:TextBox runat="server" Width="80px" ID="txtAmount" CssClass="po-amt number" Text='<%# Eval("Rate") %>'></asp:TextBox>
                    </ItemTemplate>
                </asp:TemplateField>
                <asp:TemplateField HeaderText="No of Cartons">
                    <ItemTemplate>
                        <asp:TextBox runat="server" Width="50px" ID="txtNofofCartons" CssClass="number" Text='<%# Eval("NoofCartons") %>'></asp:TextBox>
                    </ItemTemplate>
                </asp:TemplateField>

                <asp:TemplateField HeaderText="Quantity/Carton">
                    <ItemTemplate>
                        <asp:TextBox runat="server" Width="50px" ID="txtQtyperCarton" CssClass="number" ></asp:TextBox>
                    </ItemTemplate>
                </asp:TemplateField>


                <asp:TemplateField HeaderText="MF Date">
                    <ItemTemplate>
                        <asp:TextBox runat="server" Width="50px" ID="txtMFDate" CssClass="calender" Text='<%# Eval("MFDate") %>'></asp:TextBox>
                    </ItemTemplate>
                </asp:TemplateField>


            </Columns>

        </asp:GridView>


    </div>

     <div class="btn-set">
        <asp:Button ID="btnSubmit" runat="server" Text="Submit" CssClass="button" OnClick="btnSubmit_Click" />
    </div>
</asp:Content>
