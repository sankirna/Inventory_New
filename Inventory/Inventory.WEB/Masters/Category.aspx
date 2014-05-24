<%@ Page Title="" Language="C#" MasterPageFile="~/Inventory.Master" AutoEventWireup="true" CodeBehind="Category.aspx.cs" Inherits="Inventory.Web.Category" %>

<asp:Content ID="Content1" ContentPlaceHolderID="HeadContent" runat="server">
</asp:Content>

<asp:Content ID="Content3" ContentPlaceHolderID="MainContent" runat="server">
    <h1 class="title">Category</h1>

  
            <table class="formGrid" width="100%">
                <tr>
                    <td>
                        <asp:Label ID="lblCategoryName" runat="server" AssociatedControlID="txtCategoryName">Category Name</asp:Label>
                    </td>
                    <td>
                        <asp:TextBox runat="server" ID="txtCategoryName" />
                        <asp:RequiredFieldValidator ID="rfvCategoryName" runat="server" ControlToValidate="txtCategoryName"
                            CssClass="field-validation-error" ErrorMessage="Category Name field is required." />
                    </td>
               
                </tr>
                <tr>
                    <td></td>
                    <td>
                        <div >
                            <asp:Button ID="btnSave" runat="server" Text="Submit" OnClick="btnSave_Click" CssClass="button" />
                        </div>
                    </td>
                </tr>
            </table>


      
</asp:Content>
