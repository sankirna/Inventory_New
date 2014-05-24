<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="Country.ascx.cs" Inherits="Inventory.Web.Modules.Country" %>
<hgroup class="title">
    <h1>Country.</h1>
</hgroup>

<fieldset>
    <legend>Registration Form</legend>
    <ol>
        <li>
            <asp:Label ID="lblCountryName" runat="server" AssociatedControlID="txtCountryName">Country Name</asp:Label>
            <asp:TextBox runat="server" ID="txtCountryName" />
            <asp:RequiredFieldValidator ID="rfvCountryName" runat="server" ControlToValidate="txtCountryName"
                CssClass="field-validation-error" ErrorMessage="Country Name field is required." />
        </li>
        
    </ol>
    <asp:Button ID="btnSave" runat="server" Text="Save"  />
</fieldset>
