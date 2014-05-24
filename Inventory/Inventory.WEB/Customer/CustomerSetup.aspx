<%@ Page Title="" Language="C#" MasterPageFile="~/Inventory.Master" AutoEventWireup="true" CodeBehind="CustomerSetup.aspx.cs" Inherits="Inventory.Web.Customer.CustomerSetup" %>

<asp:Content ID="Content1" ContentPlaceHolderID="HeadContent" runat="server">
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="MainContent" runat="server">
    
      <h1 class="title">Customer Setup </h1>
   
            <table class="formGrid" width="100%">
    <tr>
        <td>
 <asp:Label ID="lblCustomerName" runat="server" AssociatedControlID="txtCustomerName">Customer Name</asp:Label>
        </td>
        <td>
<asp:TextBox runat="server" ID="txtCustomerName" />
                <asp:RequiredFieldValidator ID="rfvCustomerName" runat="server" ControlToValidate="txtCustomerName"
                    CssClass="field-validation-error" ErrorMessage="Customer Name field is required." />
        </td>
    </tr>
                <tr>
        <td>
  <asp:Label ID="lblAddress1" runat="server" AssociatedControlID="txtAddress1">Address1</asp:Label>
        </td>
        <td>
  <asp:TextBox runat="server" ID="txtAddress1" />
        </td>
    </tr>
                <tr>
        <td>
 <asp:Label ID="lblAddress2" runat="server" AssociatedControlID="txtAddress2">Address2</asp:Label>
        </td>
        <td>
   <asp:TextBox runat="server" ID="txtAddress2" />
        </td>
    </tr>
                <tr>
        <td>
  <asp:Label ID="lblStreet" runat="server" AssociatedControlID="txtStreet">Street</asp:Label>
        </td>
        <td>
 <asp:TextBox runat="server" ID="txtStreet" />
        </td>
    </tr>
                <tr>
        <td>
   <asp:Label ID="lblCity" runat="server" AssociatedControlID="txtCity">City</asp:Label>
        </td>
        <td>
 <asp:TextBox runat="server" ID="txtCity" />
        </td>
    </tr>
       <tr>
        <td>
 <asp:Label ID="lblCountry" runat="server" AssociatedControlID="drpCountry">Country </asp:Label>
        </td>
        <td>
<asp:DropDownList runat="server" ID="drpCountry"></asp:DropDownList>
        </td>
    </tr>
                <tr>
        <td>
  <asp:Label ID="lblTelephoneNo" runat="server" AssociatedControlID="txtTelephoneNo"> Telephone Number </asp:Label>
        </td>
        <td>
 <asp:TextBox runat="server" ID="txtTelephoneNo" />
                <asp:RequiredFieldValidator ID="rfvContactNo" runat="server" ControlToValidate="txtTelephoneNo"
                    CssClass="field-validation-error" ErrorMessage="TelephoneNo field is required." />
        </td>
    </tr>
                <tr>
        <td>
 <asp:Label ID="lblEmail" runat="server" AssociatedControlID="txtEmail"> Email </asp:Label>
        </td>
        <td>
   <asp:TextBox runat="server" ID="txtEmail" />
                <asp:RequiredFieldValidator ID="rfvEmail" runat="server" ControlToValidate="txtEmail"
                    CssClass="field-validation-error" ErrorMessage="Email field is required." />
        </td>
    </tr>
                <tr>
        <td>
 <asp:Label runat="server" ID="lblStore" AssociatedControlID="drpStore">Store </asp:Label>
        </td>
        <td>
 <asp:DropDownList runat="server" ID="drpStore">
                    <asp:ListItem Text="store1" />
                    <asp:ListItem Text="store2" />
                </asp:DropDownList>
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
