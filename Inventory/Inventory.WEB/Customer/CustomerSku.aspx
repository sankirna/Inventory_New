<%@ Page Title="" Language="C#" MasterPageFile="~/Inventory.Master" AutoEventWireup="true" CodeBehind="CustomerSku.aspx.cs" Inherits="Inventory.Web.CustomerSku" %>

<asp:Content ID="Content1" ContentPlaceHolderID="HeadContent" runat="server">
</asp:Content>

<asp:Content ID="Content3" ContentPlaceHolderID="MainContent" runat="server">

    <h1 class="title">Customer SKU Setup</h1>

   
            <table class="formGrid" width="100%" cellpadding="0" cellspacing="0">
                <tr>
   <td> <asp:Label ID="lblCustomer" runat="server" AssociatedControlID="drpCustomer">Customers</asp:Label> </td>

  <td> <asp:DropDownList ID="drpCustomer" runat="server">
                    <asp:ListItem>ABC Ltd</asp:ListItem>
                    <asp:ListItem>STC Ltd</asp:ListItem>
                    <asp:ListItem>XYZ Ltd</asp:ListItem>
                </asp:DropDownList>
                <asp:RequiredFieldValidator ID="rfvCustomer" runat="server" ControlToValidate="drpCustomer" InitialValue="0"
                    CssClass="field-validation-error" ErrorMessage="Customer field is required." /> </td>
    </tr>
                <tr>
   <td>   <asp:Label ID="lblStore" runat="server" AssociatedControlID="drpStore">Store</asp:Label></td>

  <td> <asp:DropDownList ID="drpStore" runat="server"></asp:DropDownList>
                <asp:RequiredFieldValidator ID="rfvStore" runat="server" ControlToValidate="drpStore" InitialValue="0"
                    CssClass="field-validation-error" ErrorMessage="Store field is required." /> </td>
    </tr>
<tr>
   <td>  <asp:Label ID="lblItemCode" runat="server" AssociatedControlID="drpItemCode">ItemCode</asp:Label></td>

  <td>  <asp:DropDownList ID="drpItemCode" runat="server"></asp:DropDownList>
                <asp:RequiredFieldValidator ID="rfvItemCode" runat="server" ControlToValidate="drpItemCode" InitialValue="0"
                    CssClass="field-validation-error" ErrorMessage="ItemCode field is required." /> </td>
    </tr>

                <tr>
                    <td>
                        <asp:Label ID="lblCustomerSkuCode" runat="server" AssociatedControlID="txtCustomerSkuCode">Customer SKU Code</asp:Label>
                    </td>
                   
                    <td> <asp:TextBox runat="server" ID="txtCustomerSkuCode" />
                    <asp:RequiredFieldValidator ID="rfvCustomerSkuCode" runat="server" ControlToValidate="txtCustomerSkuCode"
                        CssClass="field-validation-error" ErrorMessage="CustomerSku Name field is required." /></td>

                </tr>

                


                



<tr>
   <td> </td>

  <td>     <asp:Button ID="btnSave" runat="server" Text="Submit " OnClick="btnSave_Click" CssClass="button"/></td>
    </tr>

            </table>


</asp:Content>
