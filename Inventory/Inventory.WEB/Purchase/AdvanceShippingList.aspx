<%@ Page Title="" Language="C#" MasterPageFile="~/Inventory.Master" AutoEventWireup="true" CodeBehind="AdvanceShippingList.aspx.cs" Inherits="Inventory.Web.Purchase.AdvanceShippingList" %>

<%@ Register Assembly="AjaxControlToolkit" Namespace="AjaxControlToolkit" TagPrefix="asp" %>
<%@ Register TagPrefix="uc1" TagName="PagerControls" Src="~/UserControl/PagerControl.ascx" %>
<asp:Content ID="Content1" ContentPlaceHolderID="HeadContent" runat="server">
    
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">
    <asp:ToolkitScriptManager ID="ToolkitScriptManager1" runat="server" CombineScripts="false"></asp:ToolkitScriptManager>
   
    
    <h1 class="title">Packing List </h1>

    <div class="searchBox br6">
        <label>
            Supplier</label>
        <asp:DropDownList ID="ddlSupplier" runat="server">
        </asp:DropDownList>
        
        <label>
            PO No :</label>
        <asp:TextBox ID="txtPONo" Width="90px" runat="server"></asp:TextBox>
        <label>
             Date From</label>
        <asp:TextBox ID="txtPODateFrom" CssClass="NonEntry" Width="90px" runat="server"></asp:TextBox>
        <label>
             Date To </label>
        <asp:TextBox ID="txtPODateTo" CssClass="NonEntry" Width="90px" runat="server"></asp:TextBox>
        <asp:Button ID="btnSearch" CssClass="button" runat="server" Text="Search"  />
        
    </div>
    <div id="divGrid">
        <asp:GridView runat="server" ID="grdAdvanceShipp" AutoGenerateColumns="false" CssClass="dataGrid" Width="100%">
            <Columns>
                <asp:BoundField DataField="ASNNo" HeaderText="ASN No" />
                <asp:BoundField DataField="SupplierName" HeaderText="Supplier" />
                <asp:BoundField DataField="PONumber" HeaderText="PO No" />
                <asp:BoundField DataField="PODate" HeaderText="PO Date" />
                <asp:BoundField DataField="ETA" HeaderText="ETA" />
                 <asp:TemplateField HeaderText="Print BarCode">
                            <ItemTemplate>
                                <asp:LinkButton ID="btnGenerate" CommandName="BarCode" runat="server" Text="Print BarCode" Style="width: 50px" CssClass="button" 
                                    PostBackUrl='<%# "~/PurchaseOrder/BarCodePrint.aspx?POID=PO0001 "%>' > </asp:LinkButton>
                                
                            </ItemTemplate>
                        </asp:TemplateField>
                 <asp:TemplateField HeaderText="Receive">
                            <ItemTemplate>
                                <asp:LinkButton ID="btnReceive" CommandName="Receive" runat="server" Text="Receive" Style="width: 50px" CssClass="button" 
                                    PostBackUrl='<%# "~/PurchaseOrder/ReceiveOrder.aspx?POID=PO0001 "%>' > </asp:LinkButton>
                                
                            </ItemTemplate>
                        </asp:TemplateField>
                 <asp:TemplateField HeaderText="Print" HeaderStyle-Width="20px" ControlStyle-Width="20px">
                 <ItemTemplate>
                 <asp:ImageButton  ID="imgBarCode" runat="server" ImageUrl="~/Images/print.png" Width="20px" Height="15px"
                 />
                 </ItemTemplate>
                 </asp:TemplateField>
               <asp:TemplateField HeaderText="Edit" HeaderStyle-Width="20px" ControlStyle-Width="20px">
                         <ItemTemplate>
                         <a href='<%# string.Format( "AdvanceShippingNotify.aspx?POID={0}&ASNID={1}",Eval("PurchaseOrderID"),Eval("ASNID"))%>'><img src="../Images/edit.png" /> </a>
                       
                          </ItemTemplate>
                          </asp:TemplateField>
                       <asp:TemplateField HeaderText="Delete" HeaderStyle-Width="20px" ControlStyle-Width="20px">
                       <ItemTemplate>                               
                       <asp:ImageButton   ID ="btnDelete" runat="server" OnClientClick="return confirm('Are you sure you want to cancel the selected ASN No?');" ImageUrl="~/Images/delete.png"  ></asp:ImageButton>
                       </ItemTemplate>
                       </asp:TemplateField>
                </Columns>
        </asp:GridView>
    
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

    </div>
    

</asp:Content>
