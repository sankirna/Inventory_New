<%@ Page Title="" Language="C#" MasterPageFile="~/Inventory.Master" AutoEventWireup="true" CodeBehind="Supplier.aspx.cs" Inherits="Inventory.Web.SupplierBrand" %>

<asp:Content ID="Content1" ContentPlaceHolderID="HeadContent" runat="server">
</asp:Content>


<asp:Content ID="Content3" ContentPlaceHolderID="MainContent" runat="server">
       <h1 class="title"> Supplier</h1>

            <table class="formGrid" width="100%"> 
<tr>
   <td>
 <asp:Label ID="lblSupplierName" runat="server" AssociatedControlID="txtSupplierName">Supplier Name</asp:Label>
 </td>

  <td> 
 <asp:TextBox runat="server" ID="txtSupplierName" />
                <asp:RequiredFieldValidator ID="rfvSupplierBrandName" runat="server" ControlToValidate="txtSupplierName"
                    CssClass="field-validation-error" ErrorMessage="Supplier Name field is required." />
</td>
    </tr>
<tr>
   <td>
  <asp:Label ID="lblDescription" runat="server" AssociatedControlID="txtDescription">Description</asp:Label>
 </td>

  <td> 
  <asp:TextBox runat="server" ID="txtDescription" />
</td>
    </tr>
<tr>
   <td>
 <asp:Label ID="lblContactNo" runat="server" AssociatedControlID="txtContactNo">ContactNo</asp:Label>
 </td>

  <td> 
 <asp:TextBox runat="server" ID="txtContactNo" />
                <asp:RequiredFieldValidator ID="rfvContactNo" runat="server" ControlToValidate="txtContactNo"
                    CssClass="field-validation-error" ErrorMessage="ContactNo field is required." />
</td>
    </tr>
<tr>
   <td>
 <asp:Label ID="lblEmail" runat="server" AssociatedControlID="txtEmail">Email</asp:Label>
 </td>

  <td> 
<asp:TextBox runat="server" ID="txtEmail" />
                <asp:RequiredFieldValidator ID="rfvEmail" runat="server" ControlToValidate="txtEmail"
                    CssClass="field-validation-error" ErrorMessage="Email field is required." />
</td>
    </tr>
<tr>
   <td>
  <asp:Label ID="lblAddress1" runat="server" AssociatedControlID="txtAddress1">Address1</asp:Label>
 </td>

  <td> 
 <asp:TextBox runat="server" ID="txtAddress1" />
                <asp:RequiredFieldValidator ID="rfvAddress1" runat="server" ControlToValidate="txtAddress1"
                    CssClass="field-validation-error" ErrorMessage="Address1 field is required." />
</td>
    </tr>
<tr>
   <td>
 <asp:Label ID="lblBuildingName" runat="server" AssociatedControlID="txtBuildingName">Building Name</asp:Label>
 </td>

  <td> 
 <asp:TextBox runat="server" ID="txtBuildingName" />
                <asp:RequiredFieldValidator ID="rfvBuildingName" runat="server" ControlToValidate="txtBuildingName"
                    CssClass="field-validation-error" ErrorMessage="BuildingName field is required." />
</td>
    </tr>
<tr>
   <td>
<asp:Label ID="lblStreet" runat="server" AssociatedControlID="txtStreet">Street</asp:Label>
 </td>

  <td> 
 <asp:TextBox runat="server" ID="txtStreet" />
                <asp:RequiredFieldValidator ID="rfvStreet" runat="server" ControlToValidate="txtStreet"
                    CssClass="field-validation-error" ErrorMessage="Street field is required." />
</td>
    </tr>
<tr>
   <td>
 <asp:Label ID="lblCity" runat="server" AssociatedControlID="txtCity">City</asp:Label>
 </td>

  <td> 
 <asp:TextBox runat="server" ID="txtCity" />
                <asp:RequiredFieldValidator ID="rfvCity" runat="server" ControlToValidate="txtCity"
                    CssClass="field-validation-error" ErrorMessage="City field is required." />
</td>
    </tr>
<tr>
   <td>
  <asp:Label ID="lblCountry" runat="server" AssociatedControlID="txtCountry">Country</asp:Label>
 </td>

  <td> 
 <asp:TextBox runat="server" ID="txtCountry" />
                <asp:RequiredFieldValidator ID="rfvCountry" runat="server" ControlToValidate="txtCountry"
                    CssClass="field-validation-error" ErrorMessage="Country field is required." />
</td>
    </tr>
<tr>
   <td>
  <asp:Label ID="lblBrandNames" runat="server" AssociatedControlID="drpBrandNames">Brand Names</asp:Label>
 </td>

  <td> 
  <asp:DropDownList ID="drpBrandNames" runat="server"></asp:DropDownList>
                <asp:RequiredFieldValidator ID="rfvBrandNames" runat="server" ControlToValidate="drpBrandNames" InitialValue="0"
                    CssClass="field-validation-error" ErrorMessage="BrandNames field is required." />
</td>
    </tr>
<tr>
   <td>

 </td>

  <td> 
  <asp:Button ID="btnSave" runat="server" Text="Submit" OnClick="btnSave_Click" CssClass="button" />
      <asp:Button ID="Button1" runat="server" Text="Button" OnClick="Button1_Click" />
</td>
    </tr>

</table>


    
              
               
        
      
   
</asp:Content>