<%@ Page Title="" Language="C#" MasterPageFile="~/Inventory.Master" AutoEventWireup="true" CodeBehind="Country.aspx.cs" Inherits="Inventory.Web.Country" %>

<asp:Content ID="Content1" ContentPlaceHolderID="HeadContent" runat="server">
</asp:Content>

<asp:Content ID="Content3" ContentPlaceHolderID="MainContent" runat="server">
    <h1 class="title">Country</h1>

    
            <table class="formGrid" width="100%">
                <tr>
                    <td>
                        <asp:Label ID="lblCountryName" runat="server" AssociatedControlID="txtCountryName">Country Name</asp:Label>
                    </td>
                    <td>
                        <asp:TextBox runat="server" ID="txtCountryName" />
                        <asp:RequiredFieldValidator ID="rfvCountryName" runat="server" ControlToValidate="txtCountryName"
                            CssClass="field-validation-error" ErrorMessage="Country Name field is required." />
                    </td>
                </tr>
                <tr>
                    <td></td>
                    <td>
                        <asp:Button ID="btnSave" runat="server" Text="Submit" OnClick="btnSave_Click" CssClass="button" />

                    </td>
                </tr>
            </table>
        

</asp:Content>
