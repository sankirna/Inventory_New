<%@ Page Title="" Language="C#" MasterPageFile="~/Inventory.Master" AutoEventWireup="true" CodeBehind="AdvanceShippingList.aspx.cs" Inherits="Inventory.Web.Purchase.AdvanceShippingList" %>

<%@ Register Assembly="AjaxControlToolkit" Namespace="AjaxControlToolkit" TagPrefix="asp" %>
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
                <asp:BoundField DataField="Supplier" HeaderText="Supplier" />
                <asp:BoundField DataField="PoNumber" HeaderText="PO No" />
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
                         <asp:ImageButton  ID="imgEdit" runat="server" ImageUrl="~/Images/edit.png" Width="20px" Height="15px"
                           />
                          </ItemTemplate>
                          </asp:TemplateField>
                       <asp:TemplateField HeaderText="Delete" HeaderStyle-Width="20px" ControlStyle-Width="20px">
                       <ItemTemplate>                               
                       <asp:ImageButton   ID ="btnDelete" runat="server" OnClientClick="return confirm('Are you sure you want to cancel the selected ASN No?');" ImageUrl="~/Images/delete.png"  ></asp:ImageButton>
                       </ItemTemplate>
                       </asp:TemplateField>
                </Columns>
        </asp:GridView>
    </div>
     <div class="btn-set">
        <asp:Button ID="btnSubmit" runat="server" Text="Submit" CssClass="button" OnClick="btnSubmit_Click" />
    </div>
</asp:Content>
