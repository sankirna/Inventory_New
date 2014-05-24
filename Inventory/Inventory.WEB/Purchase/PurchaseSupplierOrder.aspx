<%@ Page Title="" Language="C#" MasterPageFile="~/Inventory.Master" AutoEventWireup="true" CodeBehind="PurchaseSupplierOrder.aspx.cs" Inherits="Inventory.Web.PurchaseSupplierOrder" %>

<asp:Content ID="Content1" ContentPlaceHolderID="HeadContent" runat="server">
</asp:Content>

<asp:Content ID="Content3" ContentPlaceHolderID="MainContent" runat="server">
    <h1 class="title"> Purchase Order for Supplier</h1>


            <table class="formGrid" width="100%">
<tr>
   <td>
 <asp:Label ID="lblSupplierName" runat="server" AssociatedControlID="txtSupplierName">Supplier Name</asp:Label>
   </td>

  <td>  <asp:DropDownList ID="ddlSupplierName" runat="server">
      <asp:ListItem Selected="True" Value="0">--Select--</asp:ListItem>
      <asp:ListItem>Supplier 1</asp:ListItem>
      <asp:ListItem>Supplier 2</asp:ListItem>
      </asp:DropDownList>
                <asp:RequiredFieldValidator ID="rfvSupplierBrandName" runat="server" ControlToValidate="txtSupplierName"
                    CssClass="field-validation-error" ErrorMessage="Supplier Name field is required." /></td>
    </tr>
<tr>
   <td> 
  <asp:Label ID="lblItemCode" runat="server" AssociatedControlID="txtItemCode">ItemCode</asp:Label>
   </td>

  <td>
  <asp:DropDownList ID="ddlItems" runat="server">
      <asp:ListItem Selected="True" Value="0">--Select--</asp:ListItem>
      <asp:ListItem>Item 1</asp:ListItem>
      <asp:ListItem>Item 2</asp:ListItem>
      </asp:DropDownList>
                <asp:RequiredFieldValidator ID="rfvItemCode" runat="server" ControlToValidate="txtItemCode"
                    CssClass="field-validation-error" ErrorMessage="ItemCode field is required." />
  </td>
    </tr>
<tr>
   <td>
  <asp:Label ID="lblItemDescription" runat="server" AssociatedControlID="txtItemDescription">Item Description</asp:Label>
 </td>
   <asp:TextBox runat="server" ID="txtItemDescription" />
  <td> 

</td>
    </tr>
<tr>
   <td>
  <asp:Label ID="lblBarCode" runat="server" AssociatedControlID="txtBarCode">BarCode</asp:Label>
 </td>
 <asp:TextBox runat="server" ID="txtBarCode" />
                <asp:RequiredFieldValidator ID="rfvBarCode" runat="server" ControlToValidate="txtBarCode"
                    CssClass="field-validation-error" ErrorMessage="BarCode field is required." />
  <td> 

</td>
    </tr>
<tr>
   <td>
 <asp:Label ID="lblPurchaseCost" runat="server" AssociatedControlID="txtPurchaseCost">PurchaseCost</asp:Label>
 </td>
   <asp:TextBox runat="server" ID="txtPurchaseCost" />
                <asp:RequiredFieldValidator ID="rfvPurchaseCost" runat="server" ControlToValidate="txtPurchaseCost"
                    CssClass="field-validation-error" ErrorMessage="PurchaseCost field is required." />
  <td> 

</td>
    </tr>
<tr>
   <td>
  <asp:Label ID="lblCost" runat="server" AssociatedControlID="txtCost">Cost</asp:Label>
 </td>

  <td> 
 <asp:TextBox runat="server" ID="txtCost" />
                <asp:RequiredFieldValidator ID="rfvCost" runat="server" ControlToValidate="txtCost"
                    CssClass="field-validation-error" ErrorMessage="Cost field is required." />
</td>
    </tr>
<tr>
   <td>
  <asp:Label ID="lblQuantity" runat="server" AssociatedControlID="txtQuantity">Quantity</asp:Label>
 </td>

  <td> 
 <asp:TextBox runat="server" ID="txtQuantity" />
                <asp:RequiredFieldValidator ID="rfvQuantity" runat="server" ControlToValidate="txtQuantity"
                    CssClass="field-validation-error" ErrorMessage="Quantity field is required." />
</td>
    </tr>
<tr>
   <td>
  <asp:Label ID="lblAmount" runat="server" AssociatedControlID="txtAmount">Amount</asp:Label>
 </td>

  <td> 
  <asp:TextBox runat="server" ID="txtAmount" />
                <asp:RequiredFieldValidator ID="rfvAmount" runat="server" ControlToValidate="txtAmount"
                    CssClass="field-validation-error" ErrorMessage="Amount field is required." />
</td>
    </tr>
<tr>
   <td>

 </td>

  <td> 
  <asp:Button ID="btnSave" runat="server" Text="Create Purchase Order" OnClick="btnSave_Click"  CssClass="button"/>
</td>
    </tr>


</table>
 
       
           
           
           
     
   
</asp:Content>
