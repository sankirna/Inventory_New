<%@ Page Title="" Language="C#" MasterPageFile="~/Inventory.Master" AutoEventWireup="true" CodeBehind="ReceiveOrderList.aspx.cs" Inherits="Inventory.Web.PurchaseOrder.ReceiveOrderList" %>

<%@ Register Assembly="AjaxControlToolkit" Namespace="AjaxControlToolkit" TagPrefix="asp" %>
<asp:Content ID="Content1" ContentPlaceHolderID="HeadContent" runat="server">
    
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">
    <asp:ToolkitScriptManager ID="ToolkitScriptManager1" runat="server" CombineScripts="false"></asp:ToolkitScriptManager>
    
    <h1 class="title">RECEIVE LIST </h1>
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
              
     <div id="divGridView">
        <asp:GridView ID="grdReceiveList" runat="server" AutoGenerateColumns="False" class="dataGrid" Width="100%">
            <Columns>
                <asp:BoundField DataField="RTagNo" HeaderText="RTAG No" />
                <asp:BoundField DataField="PONo" HeaderText="Purchase Order Number" />
                <asp:BoundField DataField="SupplierName" HeaderText="Supplier Name" />
                <asp:BoundField DataField="DateCreated" HeaderText="PO Date" />
                <asp:BoundField DataField="DateCreated" HeaderText="Date Created" />
                <asp:BoundField DataField="CreatedBy" HeaderText="Created By" />
                  <asp:TemplateField HeaderText="PutAway">
                            <ItemTemplate>
                                <asp:LinkButton ID="btnPacking" CommandName="PutAway" runat="server" Text="PutAway" Style="width: 50px" CssClass="button" 
                                    PostBackUrl='<%# "~/Purchase/PutAway.aspx?RTagNo=RT0001 "%>' > </asp:LinkButton>
                                
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
                       <asp:ImageButton   ID ="btnDelete" runat="server" OnClientClick="return confirm('Are you sure you want to cancel the selected PO No?');" ImageUrl="~/Images/delete.png"  ></asp:ImageButton>
                       </ItemTemplate>
                       </asp:TemplateField>
               
            </Columns>
        </asp:GridView>
    </div>
   
</asp:Content>
