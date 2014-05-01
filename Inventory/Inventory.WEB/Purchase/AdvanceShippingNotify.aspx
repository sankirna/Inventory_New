<%@ Page Title="" Language="C#" MasterPageFile="~/Inventory.Master" AutoEventWireup="true" CodeBehind="AdvanceShippingNotify.aspx.cs" Inherits="Inventory.Web.Purchase.AdvanceShippingNotify" %>

<%@ Register Assembly="AjaxControlToolkit" Namespace="AjaxControlToolkit" TagPrefix="asp" %>
<asp:Content ID="Content1" ContentPlaceHolderID="HeadContent" runat="server">
    <script src="../Scripts/Purchase/ASN.js"></script>
     
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">
    <asp:ToolkitScriptManager ID="ToolkitScriptManager1" runat="server" CombineScripts="false"></asp:ToolkitScriptManager>
    <h1 class="title">INVOICE /PACKING LIST</h1>
    
     <table class="formGrid" width="100%" cellpadding="0" cellspacing="0">
     <tr>
     <td>
     <asp:Label ID="lblSupplier" runat="server" >Supplier</asp:Label><span class="mandatory">*</span>
     </td>
     <td>
        <asp:TextBox runat="server" ID="txtSupplier" ReadOnly="true" Value="LIN Quan">
           
        </asp:TextBox>
         
                </td>
                </tr>

          <tr>
             <td>
     <asp:Label ID="lblPONo" runat="server" >PO No:</asp:Label><span class="mandatory">*</span>
     </td>
             <td >
        <asp:TextBox ID="txtPONo" ReadOnly="true" CssClass="NonEntry" value="DEPO20140512" runat="server" ></asp:TextBox>
                        </td>

         </tr>
         <tr>
             <td>
     <asp:Label ID="lblDate" runat="server" >PO Date:</asp:Label><span class="mandatory">*</span>
     </td>
             <td >
        <asp:TextBox ID="txtPODate" ReadOnly="true" CssClass="NonEntry" value="14-May-2014" runat="server" ></asp:TextBox>
                        </td>

         </tr>

          <tr>
               <td>
     <asp:Label ID="lblETD" runat="server" >ETA:</asp:Label><span class="mandatory">*</span>
     </td>
            

                     <td >
        <asp:TextBox ID="txtETD"  CssClass="NonEntry calender" runat="server" ></asp:TextBox>
                        </td>

         </tr>

          <tr>
             <td>
     <asp:Label ID="lblPINo" runat="server" >PI No:</asp:Label><span class="mandatory">*</span>
     </td>
             <td >
        <asp:TextBox ID="txtPINo"  runat="server" ></asp:TextBox>
                        </td>

         </tr>

           <tr>
             <td>
     <asp:Label ID="Label1" runat="server" >From:</asp:Label><span class="mandatory">*</span>
     </td>
             <td >
        <asp:TextBox ID="txtCountryFrom"  runat="server"  CssClass="calender"></asp:TextBox>
                        </td>

         </tr>
         <tr>
           <td>
     <asp:Label ID="Label2" runat="server" >To:</asp:Label><span class="mandatory">*</span>
     </td>
             <td >
        <asp:TextBox ID="txtCountryTo"  runat="server" CssClass="calender"></asp:TextBox>
                        </td>

         </tr>
         </table>
   <div id="divGridView">
                            <asp:GridView ID="grdPackingList" runat="server" class="dataGrid" AutoGenerateColumns="False"
                                Width="100%" CellPadding="0" CellSpacing="0" Style="margin-top: 0px;"  >
                                <Columns>
                                    
                                    <asp:TemplateField>
            <HeaderTemplate>
            Serial No.</HeaderTemplate>
            <ItemTemplate>
            <asp:Label ID="lblSRNO" runat="server" 
                Text='<%#Container.DataItemIndex+1 %>'></asp:Label>
            </ItemTemplate>
            </asp:TemplateField>
                                    <asp:TemplateField   HeaderText="Carton Starting No">
                                         <ItemTemplate>
                                             <asp:TextBox runat="server" width="20px" ID="txtStartinNo"></asp:TextBox>
                                             </ItemTemplate>
                                    </asp:TemplateField>
                                    <asp:TemplateField HeaderText="Carton Ending No">
                                         <ItemTemplate>
                                             <asp:TextBox Width="20px" runat="server" ID="txtEndNo"></asp:TextBox>
                                             </ItemTemplate>
                                    </asp:TemplateField>
                                    <asp:TemplateField HeaderText="ItemCode">
                                        <ItemTemplate>
                                            <asp:DropDownList runat="server" ID="ItemCode">
                                            <asp:ListItem>--SELECT--</asp:ListItem>
                                            <asp:ListItem>96510599</asp:ListItem>
                                            <asp:ListItem>96510520</asp:ListItem>
                                            <asp:ListItem>96510530</asp:ListItem>
                                            <asp:ListItem>96510540</asp:ListItem>
                                            <asp:ListItem>--New--</asp:ListItem>
                                            </asp:DropDownList>
                                            </ItemTemplate>
                                            </asp:TemplateField>
                                      <asp:TemplateField HeaderText="Description">
                                        <ItemTemplate>
                                            <asp:Label runat="server" Width="200px" ID="lblDescription"></asp:Label>
                                            </ItemTemplate>
                                            </asp:TemplateField>                                   
                                     <asp:TemplateField HeaderText="BarCode">
                                        <ItemTemplate>
                                            <asp:Label runat="server" Width="120px" ID="lblBarCode"></asp:Label>
                                            </ItemTemplate>
                                            </asp:TemplateField>
                                      <asp:TemplateField HeaderText="Unit Price">
                                        <ItemTemplate>
                                            <asp:TextBox runat="server" Width="50px" ID="lblPurchaseCost"></asp:TextBox>
                                            </ItemTemplate>
                                            </asp:TemplateField>                                                                                                       
                                      <asp:TemplateField HeaderText="Quantity">
                                        <ItemTemplate>
                                            <asp:TextBox runat="server" Width="50px" ID="txtQty"></asp:TextBox>
                                            </ItemTemplate>
                                            </asp:TemplateField>               
                                     <asp:TemplateField HeaderText="Amount (S$)">
                                        <ItemTemplate>
                                            <asp:TextBox runat="server" Width="80px" ID="txtAmount"></asp:TextBox>
                                            </ItemTemplate>
                                            </asp:TemplateField>               
                                     <asp:TemplateField HeaderText="No of Cartons">
                                        <ItemTemplate>
                                            <asp:TextBox runat="server" Width="50px" ID="txtNofofCartons"></asp:TextBox>
                                            </ItemTemplate>
                                            </asp:TemplateField>  

                                     <asp:TemplateField HeaderText="Quantity/Carton">
                                        <ItemTemplate>
                                            <asp:TextBox runat="server" Width="50px" ID="txtQtyperCarton"></asp:TextBox>
                                            </ItemTemplate>
                                            </asp:TemplateField>  
                              

                                <asp:TemplateField HeaderText="MF Date">
                                        <ItemTemplate>
                                            <asp:TextBox runat="server" Width="50px" ID="txtMFDate" CssClass="calender"></asp:TextBox>
                                            </ItemTemplate>
                                            </asp:TemplateField>  

                                   
                                    </Columns>
                                    
                                    </asp:GridView>
                 

         </div>
                        
     <div class="btn-set">
                            <asp:Button ID="btnSubmit" runat="server" Text="Submit"  CssClass="button" />
        </div>
</asp:Content>
