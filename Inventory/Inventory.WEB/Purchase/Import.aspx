<%@ Page Title="" Language="C#" MasterPageFile="~/Inventory.Master" AutoEventWireup="true" CodeBehind="Import.aspx.cs" Inherits="Inventory.Web.Purchase.Import" %>

<asp:Content ID="Content1" ContentPlaceHolderID="HeadContent" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">
    <h1 class="title">Picking List Import</h1>
    <div class="vertical-tab">
        <div class="panes br6 bs full-width">
            <table>
                <tr>
                    <td>Upload file</td>

                    <td>
                        <asp:FileUpload ID="fuImportExcel" runat="server" /></td>
                </tr>
                <tr>
                    <td></td>
                    <td>
                        <asp:Button ID="btnSave" runat="server" Text="Submit" OnClick="btnSave_Click" CssClass="button" />

                    </td>
                </tr>
            </table>
        </div>
    </div>
</asp:Content>
