<%@ Page Title="" Language="C#" MasterPageFile="~/Inventory.Master" AutoEventWireup="true" CodeBehind="Product.aspx.cs" Inherits="Inventory.Web.Product" %>

<asp:Content ID="Content1" ContentPlaceHolderID="HeadContent" runat="server">
    
</asp:Content>

<asp:Content ID="Content3" ContentPlaceHolderID="MainContent" runat="server">
 
       <h1 class="title">PRODUCT DETAILS </h1>
    
             <table class="formGrid" width="100%" cellpadding="0" cellspacing="0">
                <tr>
                    <td>
 <asp:Label ID="lblItemCode" runat="server" AssociatedControlID="txtItemCode">Item Code</asp:Label>
                    </td>
                    <td>
 <asp:TextBox runat="server" ID="txtItemCode" data-validation="required"  data-validation-error-msg= />
              
                    </td>
                </tr>
                <tr>
                    <td>
 <asp:Label ID="lblDesc" runat="server" AssociatedControlID="txtDesc"> Description </asp:Label>
                    </td>
                    <td>
  <asp:TextBox runat="server" ID="txtDesc" data-validation="required" TextMode="MultiLine"  />
                    </td>
                </tr>
    <tr>
        <td>
 <asp:Label Text="MF BarCode" runat="server" AssociatedControlID="txtMFBarcode" />
        </td>
        <td>
  <asp:TextBox runat="server" ID="txtMFBarcode" data-validation="required" />
        </td>
    </tr>
                <tr>
        <td>
 <asp:Label ID="lblSupplier" runat="server" AssociatedControlID="drpSupplier"> Supplier</asp:Label>
        </td>
        <td>
  <asp:DropDownList runat="server" ID="drpSupplier" data-validation="required" AppendDataBoundItems="True" data-placeholder="Select the Supplier" CssClass="input-large">
      <asp:ListItem>--Select--</asp:ListItem>
                </asp:DropDownList>
        </td>
    </tr>
                <tr>
        <td>
 <asp:Label Text="UOM" runat="server" ID="lblUOM" AssociatedControlID="drpUOM"  />
        </td>
        <td>
 <asp:DropDownList runat="server" ID="drpUOM" data-validation="required"  AppendDataBoundItems="true">
     <asp:ListItem Value="" Text="--select**">

     </asp:ListItem>                    <asp:ListItem Text="text1" />
                    <asp:ListItem Text="text2" />
                </asp:DropDownList>
        </td>
    </tr>
                <tr>
        <td>
  <asp:Label Text="Dimensions Length(mm)" runat="server" ID="lblDimenLgth" AssociatedControlID="txtDimenLgth" />
        </td>
        <td>
  <asp:TextBox runat="server" ID="txtDimenLgth"  data-validation="number length" data-validation-length="1-3" />
        </td>
    </tr>
                <tr>
        <td>
  <asp:Label Text="Breadth(mm)" runat="server" ID="lblBreadth" AssociatedControlID="txtBreadth" />
        </td>
        <td>
 <asp:TextBox runat="server" ID="txtBreadth"  data-validation="required number length" data-validation-length="1-3"  />
        </td>
    </tr>
                <tr>
        <td>
  <asp:Label Text="Height(mm)" runat="server" ID="lblHeight" AssociatedControlID="txtHeight" />
        </td>
        <td>
  <asp:TextBox runat="server" ID="txtHeight" data-validation="required number length" data-validation-length="1-3"   />
        </td>
    </tr>
           <tr>
        <td>
  <asp:Label Text="Weight" runat="server" ID="lblWeight" AssociatedControlID="txtWeight" />
        </td>
        <td>
 <asp:TextBox runat="server" ID="txtWeight"  data-validation="required number length" data-validation-length="1-3"   />
        </td>
    </tr>
                <tr>
        <td>
<asp:Label Text="Std Packing Size Length" ID="lblPackSize" runat="server" AssociatedControlID="txtStdPackSize" />
        </td>
        <td>
  <asp:TextBox runat="server" ID="txtStdPackSize" data-validation="required"/>
        </td>
    </tr>
                <tr>
        <td>
 <asp:Label Text="Breadth" ID="lblStdBreadth" runat="server" AssociatedControlID="txtStdBreadth" />
        </td>
        <td>
 <asp:TextBox runat="server" ID="txtStdBreadth" data-validation="required number length" data-validation-length="1-3"   />
        </td>
    </tr>
                <tr>
        <td>
  <asp:Label Text="Height" ID="lblStdHeight" runat="server" AssociatedControlID="txtStdHeight" />
        </td>
        <td>
 <asp:TextBox runat="server" ID="txtStdHeight" data-validation="required number length" data-validation-length="1-3"  />
        </td>
    </tr>
                <tr>
        <td>
 <asp:Label Text="Weight" ID="lblStdWeight" runat="server" AssociatedControlID="txtStdWeight" />
        </td>
        <td>
 <asp:TextBox runat="server" ID="txtStdWeight" data-validation="required number length" data-validation-length="1-3"  />
        </td>
    </tr>
                <tr>
        <td>
 <asp:Label Text="Qty Per Carton" ID="lblQtuPerCartoon" runat="server"  AssociatedControlID="txtQtyperCartoon"/>
        </td>
        <td>
 <asp:TextBox runat="server" ID="txtQtyperCartoon" data-validation="required number length" data-validation-length="1-3"    />
        </td>
    </tr>
                <tr>
        <td>
<asp:Label Text="Basic Purchase Cost" ID="lblPurchCost" runat="server" AssociatedControlID="txtPurchCost" />
        </td>
        <td>
 <asp:TextBox runat="server" ID="txtPurchCost" data-validation="required number length" data-validation-length="1-3"  data-validation-allowing="float"  />
        </td>
    </tr>
                <tr>
        <td>
  <asp:Label Text="Currerncy" ID="lblCurncy" runat="server"  AssociatedControlID="drpCurncy"/>
        </td>
        <td>
 <asp:DropDownList runat="server" ID="drpCurncy" data-validation="required" CssClass="" AppendDataBoundItems="True">
                    <asp:ListItem Text="text1" />
                    <asp:ListItem Text="text2" />
                </asp:DropDownList>
        </td>
    </tr>
                <tr>
        <td>
 <asp:Label Text="Suggested Retail Price" ID="lblRetailPrice" runat="server" AssociatedControlID="txtRetailPrice" />
        </td>
        <td>
<asp:TextBox runat="server" ID="txtRetailPrice"  data-validation="required number length" data-validation-length="1-3"  data-validation-allowing="float"  />
        </td>
    </tr>
            <tr>
        <td>
 <asp:Label Text="Shelf Life" ID="lblShelfLife" runat="server" AssociatedControlID="txtShelfLife" />
        </td>
        <td>
 <asp:TextBox runat="server" ID="txtShelfLife" data-validation-help="Please give us some more information" data-validation="required number length" data-validation-length="1-3" data-validation-optional="false"  />
        </td>
    </tr>
          
      <tr>
        <td>

        </td>
        <td>
  <asp:Button ID="btnSave" runat="server" Text="Submit" OnClick="btnSave_Click"  CssClass="button"/>
        </td>
    </tr>   
       
      
   </table>
            <script src="../Scripts/jquery.min.js"></script>
<script src="../Scripts/jquery.form-validator.min.js"></script>
<script src="../Scripts/Validation.js"></script>
</asp:Content>
