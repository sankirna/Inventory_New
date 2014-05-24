<%@ Page Title="" Language="C#" MasterPageFile="~/Inventory.Master" AutoEventWireup="true" CodeBehind="Brand.aspx.cs" Inherits="Inventory.Web.Brand" %>

<asp:Content ID="Content1" ContentPlaceHolderID="HeadContent" runat="server">
</asp:Content>

<asp:Content ID="Content3" ContentPlaceHolderID="MainContent" runat="server">
    
       <h1 class="title">Brand </h1>
    
            <table class="formGrid" width="100%" cellpadding="0" cellspacing="0">

                <tr>
   <td>
<asp:Label ID="lblBrandName" runat="server" AssociatedControlID="txtBrandName">Brand Name</asp:Label>
 </td>

  <td>
 
  <asp:TextBox runat="server" ID="txtBrandName" data-validation="required" />
               
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
