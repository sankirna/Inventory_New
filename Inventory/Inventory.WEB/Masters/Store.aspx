<%@ Page Title="" Language="C#" MasterPageFile="~/Inventory.Master" AutoEventWireup="true" CodeBehind="Store.aspx.cs" Inherits="Inventory.Web.Store" %>

<asp:Content ID="Content1" ContentPlaceHolderID="HeadContent" runat="server">
</asp:Content>


<asp:Content ID="Content3" ContentPlaceHolderID="MainContent" runat="server">
       <h1 class="title"> Store </h1>

            <table width="100%" class="formGrid">
<tr>
   <td>
  <asp:Label ID="lblStoreName" runat="server" AssociatedControlID="txtStoreName">Store Name</asp:Label>
 </td>

  <td> 
 <asp:TextBox runat="server" ID="txtStoreName" />
                            <asp:RequiredFieldValidator ID="rfvStoreName" runat="server" ControlToValidate="txtStoreName"
                                CssClass="field-validation-error" ErrorMessage="Store Name field is required." />
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
 <asp:TextBox runat="server" ID="txtAddress1" TextMode="MultiLine" />
                            <asp:RequiredFieldValidator ID="rfvAddress1" runat="server" ControlToValidate="txtAddress1"
                                CssClass="field-validation-error" ErrorMessage="Address1 field is required." />
</td>
    </tr>
<tr>
   <td>
  <asp:Label ID="lblAddress2" runat="server" AssociatedControlID="txtAddress2">Address2</asp:Label>
 </td>

  <td> 
  <asp:TextBox runat="server" ID="txtAddress2" TextMode="MultiLine" />
                            <asp:RequiredFieldValidator ID="rfvAddress2" runat="server" ControlToValidate="txtAddress2"
                                CssClass="field-validation-error" ErrorMessage="Address2 field is required." />
</td>
    </tr>

<tr>
   <td>
  <asp:Label ID="lblAddress3" runat="server" AssociatedControlID="txtAddress3">Address3</asp:Label>
 </td>

  <td> 
 <asp:TextBox runat="server" ID="txtAddress3" TextMode="MultiLine" />
                            <asp:RequiredFieldValidator ID="rfvAddress3" runat="server" ControlToValidate="txtAddress3"
                                CssClass="field-validation-error" ErrorMessage="Address3 field is required." />
</td>
    </tr>
<tr>
   <td>

 </td>

  <td> 
  <asp:Button ID="btnSave" runat="server" Text="Submit" OnClick="btnSave_Click" CssClass="button" />
</td>
    </tr>

</table>

      
                  
         

</asp:Content>
