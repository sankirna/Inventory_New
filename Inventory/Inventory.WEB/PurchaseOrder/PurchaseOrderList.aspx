﻿<%@ Page Title="" Language="C#" MasterPageFile="~/Inventory.Master" AutoEventWireup="true" CodeBehind="PurchaseOrderList.aspx.cs" Inherits="Inventory.Web.PurchaseOrder.PurchaseOrderList" %>
<%@ Register Assembly="AjaxControlToolkit" Namespace="AjaxControlToolkit" TagPrefix="asp" %>
<%@ Register TagPrefix="uc1" TagName="PagerControls" Src="~/UserControl/PagerControl.ascx" %>
<asp:Content ID="Content1" ContentPlaceHolderID="HeadContent" runat="server">
    </asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">
      <script type="text/javascript">
          $(document).ready(function () {
              SetDatePicker();
          });

          function SetDatePicker() {
              $("#<%=txtPODateFrom.ClientID%>").datepicker({ dateFormat: 'dd-MM-yy' });
               $("#<%=txtPODateTo.ClientID%>").datepicker({ dateFormat: 'dd-MM-yy' });
           }
    </script>
    <asp:ToolkitScriptManager ID="ToolkitScriptManager1" runat="server" CombineScripts="false"></asp:ToolkitScriptManager>

     
     <asp:Button ID="btnPO" CssClass="button f-right" runat="server" Text="Create PO" OnClick="btnPO_Click" Width="110px" />
    
    <h1 class="title">Purchase Order List </h1>

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
        <asp:Button ID="btnSearch" CssClass="button" runat="server" Text="Search" OnClick="btnSearch_Click"  />
        
    </div>
    <div id="divGridView">
        <asp:GridView ID="grdPOList" runat="server" AutoGenerateColumns="False" class="dataGrid" Width="100%">
            <Columns>
                <asp:BoundField DataField="PONumber" HeaderText="Purchase Order Number" />
                <asp:BoundField DataField="SupplierMaster.SupplierName" HeaderText="Supplier Name" />
                <asp:BoundField DataField="DateCreated" HeaderText="PO Date" />
                <asp:BoundField DataField="DateCreated" HeaderText="Date Created" />
                <asp:BoundField DataField="CreatedBy" HeaderText="Created By" />   
                  <asp:TemplateField HeaderText="Export Packing List">
                            <ItemTemplate>
                                <asp:LinkButton ID="btnPacking1" CommandName="PackingList" runat="server" Text="Export Packing List" Style="width: 50px" CssClass="button" 
                                    PostBackUrl='<%#  string.Format( "~/Purchase/AdvanceShippingNotify.aspx?POID={0}",Eval("PurchaseOrderID"))%>'  > </asp:LinkButton>
                                
                            </ItemTemplate>
                        </asp:TemplateField> 
                <asp:TemplateField HeaderText="Packing List">
                            <ItemTemplate>
                                <asp:LinkButton ID="btnPacking" CommandName="PackingList" runat="server" Text="Packing List" Style="width: 50px" CssClass="button" 
                                    PostBackUrl='<%# string.Format( "~/Purchase/AdvanceShippingNotify.aspx?POID={0}",Eval("PurchaseOrderID"))%>' > </asp:LinkButton>
                                
                            </ItemTemplate>
                        </asp:TemplateField>
                 <asp:TemplateField HeaderText="Print PO" HeaderStyle-Width="20px" ControlStyle-Width="20px">
                 <ItemTemplate>
                 <asp:ImageButton  ID="imgBarCode" runat="server" ImageUrl="~/Images/print.png" Width="20px" Height="15px"
                 />
                 </ItemTemplate>
                 </asp:TemplateField>
               <asp:TemplateField HeaderText="Edit" HeaderStyle-Width="20px" ControlStyle-Width="20px">
                         <ItemTemplate>
                             <a href='<%# string.Format( "PurchaseOrder.aspx?POID={0}",Eval("PurchaseOrderID"))%>'><img src="../Images/edit.png" /> </a>
                       
                             
                          </ItemTemplate>
                          </asp:TemplateField>
                       <asp:TemplateField HeaderText="Delete" HeaderStyle-Width="20px" ControlStyle-Width="20px">
                       <ItemTemplate>                               
                       <asp:ImageButton   ID ="btnDelete" runat="server" OnClientClick="return confirm('Are you sure you want to cancel the selected PO No?');" ImageUrl="~/Images/delete.png"  ></asp:ImageButton>
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
