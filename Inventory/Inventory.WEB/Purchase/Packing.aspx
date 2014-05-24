<%@ Page Title="" Language="C#" MasterPageFile="~/Inventory.Master" AutoEventWireup="true" CodeBehind="Packing.aspx.cs" Inherits="Inventory.Web.Purchase.Packing" %>

<asp:Content ID="Content1" ContentPlaceHolderID="HeadContent" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">

    <h1 class="title">Picking List Form</h1>
   
            <table class="formGrid" width="100%">
                <tr>
                    <td>
                        <asp:Label ID="lblItemCode" runat="server" AssociatedControlID="txtItemCode">ItemCode</asp:Label>
                    </td>
                    <td>
                        <asp:TextBox runat="server" ID="txtItemCode" />
                        <asp:RequiredFieldValidator ID="rfvItemCode" runat="server" ControlToValidate="txtItemCode"
                            CssClass="field-validation-error" ErrorMessage="ItemCode field is required." />
                    </td>
                </tr>
                <tr>
                    <td>
                        <asp:Label ID="lblDescription" runat="server" AssociatedControlID="txtDescription">Item Description</asp:Label>
                    </td>
                    <td>
                        <asp:TextBox runat="server" ID="txtDescription" /></td>
                </tr>
                 <tr>
                    <td> 
<asp:Label ID="lblUnitPrice" runat="server" AssociatedControlID="txtUnitPrice">UnitPrice</asp:Label></td>
                    <td>   <asp:TextBox runat="server" ID="txtUnitPrice" />
                <asp:RequiredFieldValidator ID="rfvUnitPrice" runat="server" ControlToValidate="txtUnitPrice"
                    CssClass="field-validation-error" ErrorMessage="UnitPrice field is required." /> </td>
                </tr>
          
                 <tr>
                    <td> 
<asp:Label ID="lblQty" runat="server" AssociatedControlID="txtQty">Qty</asp:Label></td>
                    <td>   <asp:TextBox runat="server" ID="txtQty" />
                <asp:RequiredFieldValidator ID="rfvQty" runat="server" ControlToValidate="txtQty"
                    CssClass="field-validation-error" ErrorMessage="Qty field is required." /> </td>
                </tr>
           <tr>
                    <td> 
<asp:Label ID="lblAmount" runat="server" AssociatedControlID="txtAmount">Amount</asp:Label></td>
                    <td>   <asp:TextBox runat="server" ID="txtAmount" />
                <asp:RequiredFieldValidator ID="rfvAmount" runat="server" ControlToValidate="txtAmount"
                    CssClass="field-validation-error" ErrorMessage="Amount field is required." /> </td>
                </tr>
           <tr>
                    <td> 
<asp:Label ID="lblBarCodeNO" runat="server" AssociatedControlID="txtBarCodeNO">BarCode NO</asp:Label></td>
                    <td>   <asp:TextBox runat="server" ID="txtBarCodeNO" />
                <asp:RequiredFieldValidator ID="rfvBarCodeNO" runat="server" ControlToValidate="txtBarCodeNO"
                    CssClass="field-validation-error" ErrorMessage="BarCode NO field is required." /> </td>
                </tr>
           <tr>
                    <td> 
<asp:Label ID="lblNoofCartons" runat="server" AssociatedControlID="txtNoofCartons">No of Cartons</asp:Label></td>
                    <td>   <asp:TextBox runat="server" ID="txtNoofCartons" />
                <asp:RequiredFieldValidator ID="rfvNoofCartons" runat="server" ControlToValidate="txtNoofCartons"
                    CssClass="field-validation-error" ErrorMessage="No of Cartons field is required." /> </td>
                </tr>
           <tr>
                    <td> 
<asp:Label ID="lblTotalQuantity" runat="server" AssociatedControlID="txtTotalQuantity">Total Quantity</asp:Label></td>
                    <td>   <asp:TextBox runat="server" ID="txtTotalQuantity" />
                <asp:RequiredFieldValidator ID="rfvTotalQuantity" runat="server" ControlToValidate="txtTotalQuantity"
                    CssClass="field-validation-error" ErrorMessage="Total Quantity field is required." /> </td>
                </tr>
           <tr>
                    <td> 
<asp:Label ID="lblMfgDate" runat="server" AssociatedControlID="txtMfgDate">Mfg Date</asp:Label></td>
                    <td>   <asp:TextBox runat="server" ID="txtMfgDate" />
                <asp:RequiredFieldValidator ID="rfvMfgDate" runat="server" ControlToValidate="txtMfgDate"
                    CssClass="field-validation-error" ErrorMessage="Mfg Date field is required." /> </td>
                </tr>
           <tr>
                    <td> 
<asp:Label ID="lblExpiryDate" runat="server" AssociatedControlID="txtExpiryDate">Expiry Date</asp:Label></td>
                    <td>   <asp:TextBox runat="server" ID="txtExpiryDate" />
                <asp:RequiredFieldValidator ID="rfvExpiryDate" runat="server" ControlToValidate="txtExpiryDate"
                    CssClass="field-validation-error" ErrorMessage="Expiry Date field is required." /> </td>
                </tr>
          
                <tr>
                    <td></td>
                    <td>
                        <asp:Button ID="btnSave" runat="server" Text="Submit" OnClick="btnSave_Click" CssClass="button" />

                    </td>
                </tr>
            </table>
       

</asp:Content>
