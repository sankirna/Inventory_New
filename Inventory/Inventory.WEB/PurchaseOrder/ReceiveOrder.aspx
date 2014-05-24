<%@ Page Title="" Language="C#" MasterPageFile="~/Inventory.Master" AutoEventWireup="true" CodeBehind="ReceiveOrder.aspx.cs" Inherits="Inventory.Web.PurchaseOrder.ReceiveOrder" %>
<%@ Register Assembly="AjaxControlToolkit" Namespace="AjaxControlToolkit" TagPrefix="asp" %>
<asp:Content ID="Content1" ContentPlaceHolderID="HeadContent" runat="server">
     <script type="text/javascript">
         $(document).ready(function () {
            // Sys.WebForms.PageRequestManager.getInstance().add_endRequest(SetDatePicker);
             SetDatePicker();
         });

         function SetDatePicker() {
             $("#<%=txtReceiveDate.ClientID%>").datepicker({ dateFormat: 'dd-M-yy' });
          }
    </script>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">
    <h1 class="title">RECEIVE ORDER DETAILS</h1>
    <table class="formGrid" width="100%" cellpadding="0" cellspacing="0">
     <tr>
     <td>
     <asp:Label ID="lblSupplier" runat="server" >Supplier</asp:Label><span class="mandatory">*</span>
     </td>
     <td>
        <asp:TextBox runat="server" ID="txtSupplier" ReadOnly="true" Value="LIN Quan">
           
        </asp:TextBox>
         
                </td>
                
        
             <td>
     <asp:Label ID="Label1" runat="server" >ASN No:</asp:Label><span class="mandatory">*</span>
     </td>
             <td >
        <asp:TextBox ID="txtASNNo" ReadOnly="true" CssClass="NonEntry" value="ASN0001" runat="server" ></asp:TextBox>
                        </td>

         </tr>
          <tr>
             <td>
     <asp:Label ID="lblPONo" runat="server" >PO No:</asp:Label><span class="mandatory">*</span>
     </td>
             <td >
        <asp:TextBox ID="txtPONo" ReadOnly="true" CssClass="NonEntry" value="DEPO20140512" runat="server" ></asp:TextBox>
                        </td>

         
                      <td>
     <asp:Label ID="lblDate" runat="server" >PO Date:</asp:Label><span class="mandatory">*</span>
     </td>
             <td >
        <asp:TextBox ID="txtPODate" ReadOnly="true" CssClass="NonEntry" value="14-May-2014" runat="server" ></asp:TextBox>
                        </td>

         </tr>
                 
        
          <tr>
               <td>
     <asp:Label ID="Label2" runat="server" >Receive Date:</asp:Label><span class="mandatory">*</span>
     </td>
            

                     <td >
        <asp:TextBox ID="txtReceiveDate"  CssClass="NonEntry" runat="server" ></asp:TextBox>
                        </td>

         </tr>

          
         </table>
    <br />
    <div id="divGrid">
    <h1 class="title"> PRODUCT DETAILS</h1>

    <table class="formGrid" width="100%" cellpadding="0" cellspacing="0">
     <tr>
     <td>
     <asp:Label ID="Label3" runat="server" >Item Code</asp:Label><span class="mandatory">*</span>
     </td>
     <td>
     <asp:TextBox runat="server" ID="txtItemCode" >           
      </asp:TextBox>
         
                </td>
                </tr>
        <tr>
             <td>
     <asp:Label ID="Label4" runat="server" >Description:</asp:Label><span class="mandatory">*</span>
     </td>
      <td >
       <asp:TextBox ID="txtDescription" ReadOnly="true" CssClass="NonEntry"  runat="server" ></asp:TextBox>
        </td>

         </tr>
          <tr>
             <td>
     <asp:Label ID="Label5" runat="server" >Quantity:</asp:Label><span class="mandatory">*</span>
     </td>
             <td >
        <asp:TextBox ID="txtQuantity"  runat="server" ></asp:TextBox>
                        </td>

         </tr>
         <tr>
             <td>
     <asp:Label ID="Label6" runat="server" >No of Cartons:</asp:Label><span class="mandatory">*</span>
     </td>
             <td >
        <asp:TextBox ID="TextBox4"  runat="server" ></asp:TextBox>
                        </td>

         </tr>
                 
        
          <tr>
               <td>
     <asp:Label ID="Label7" runat="server" >Quantity Per Carton:</asp:Label><span class="mandatory">*</span>
     </td>
            

                     <td >
        <asp:TextBox ID="TextBox5"   runat="server" ></asp:TextBox>
                        </td>

         </tr>

          
         </table>
   

   </div>
                        
     <div class="btn-set">
                            <asp:Button ID="btnSubmit" runat="server" Text="Submit"  CssClass="button" />
        </div>
    
</asp:Content>
