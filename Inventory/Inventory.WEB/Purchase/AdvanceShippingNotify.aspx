<%@ Page Title="" Language="C#" MasterPageFile="~/Inventory.Master" AutoEventWireup="true" CodeBehind="AdvanceShippingNotify.aspx.cs" Inherits="Inventory.Web.Purchase.AdvanceShippingNotify" %>

<%@ Register Assembly="AjaxControlToolkit" Namespace="AjaxControlToolkit" TagPrefix="asp" %>
<asp:Content ID="Content1" ContentPlaceHolderID="HeadContent" runat="server">
    <script src="../Scripts/Purchase/ASN.js"></script>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">
    <asp:ToolkitScriptManager ID="ToolkitScriptManager1" runat="server" CombineScripts="false"></asp:ToolkitScriptManager>
    <asp:UpdatePanel ID="UpdatePanel1" runat="server">
        <ContentTemplate>
            <h1 class="title">INVOICE /PACKING LIST</h1>
            <asp:Label ID="lblError" runat="server" Text="" ForeColor="Red"></asp:Label>
            <table class="formGrid" width="100%" cellpadding="0" cellspacing="0">
                <tr>
                    <td>
                        <asp:Label ID="lblSupplier" runat="server">Supplier</asp:Label><span class="mandatory">*</span>
                    </td>
                    <td>
                        <asp:TextBox runat="server" ID="txtSupplier" ReadOnly="true">
           
                        </asp:TextBox><asp:HiddenField ID="hdnSupplierId" runat="server" />
                        <asp:RequiredFieldValidator ID="rfvSupplier" runat="server" ControlToValidate="txtSupplier"
                            CssClass="field-validation-error" ErrorMessage="Please enter Supplier." />
                    </td>


                    <td>
                        <asp:Label ID="lblPONo" runat="server">PO No:</asp:Label><span class="mandatory">*</span>
                    </td>
                    <td>
                        <asp:HiddenField ID="hdPoId" runat="server" />
                        <asp:TextBox ID="txtPONo" ReadOnly="true" CssClass="NonEntry" runat="server"></asp:TextBox>
                        <asp:RequiredFieldValidator ID="rfvtxtPONo" runat="server" ControlToValidate="txtPONo"
                            CssClass="field-validation-error" ErrorMessage="Please enter PONo." />
                    </td>

                </tr>
                <tr>
                    <td>
                        <asp:Label ID="lblDate" runat="server">PO Date:</asp:Label><span class="mandatory">*</span>
                    </td>
                    <td>
                        <asp:TextBox ID="txtPODate" ReadOnly="true" CssClass="NonEntry calender" runat="server"></asp:TextBox>
                        <asp:RequiredFieldValidator ID="rfvtxtPODate" runat="server" ControlToValidate="txtPODate"
                            CssClass="field-validation-error" ErrorMessage="Please enter PODate." />
                    </td>


                    <td>
                        <asp:Label ID="lblETD" runat="server">ETA:</asp:Label><span class="mandatory">*</span>
                    </td>


                    <td>
                        <asp:TextBox ID="txtETD" CssClass="NonEntry calender" runat="server"></asp:TextBox>
                        <asp:RequiredFieldValidator ID="rfvtxtETD" runat="server" ControlToValidate="txtETD"
                            CssClass="field-validation-error" ErrorMessage="Please enter ETD." />
                    </td>

                </tr>

                <tr>
                    <td>
                        <asp:Label ID="lblPINo" runat="server">PI No:</asp:Label><span class="mandatory">*</span>
                    </td>
                    <td>
                        <asp:TextBox ID="txtPINo" runat="server"></asp:TextBox>
                        <asp:RequiredFieldValidator ID="rfvtxtPINo" runat="server" ControlToValidate="txtPINo"
                            CssClass="field-validation-error" ErrorMessage="Please enter PINo." />
                    </td>




                    <td>
                        <asp:Label ID="Label3" runat="server">Invoice No:</asp:Label><span class="mandatory">*</span>
                    </td>
                    <td>
                        <asp:TextBox ID="txtInvoiceNo" runat="server"></asp:TextBox>
                        <asp:RequiredFieldValidator ID="rfvtxtInvoiceNo" runat="server" ControlToValidate="txtInvoiceNo"
                            CssClass="field-validation-error" ErrorMessage="Please enter InvoiceNo." />
                    </td>

                </tr>

                <tr>
                    <td>
                        <asp:Label ID="lblCountryFrom" runat="server">From:</asp:Label><span class="mandatory">*</span>
                    </td>
                    <td>
                        <asp:DropDownList ID="ddlCountryFrom" runat="server" AppendDataBoundItems="True"></asp:DropDownList>
                        <asp:RequiredFieldValidator ID="rfvddlCountryFrom" runat="server" ControlToValidate="ddlCountryFrom" InitialValue="0"
                            CssClass="field-validation-error" ErrorMessage="Please select CountryFrom." />
                    </td>



                    <td>
                        <asp:Label ID="lblCountryTo" runat="server">To:</asp:Label><span class="mandatory">*</span>

                    </td>
                    <td>

                        <asp:DropDownList ID="ddlCountryTo" runat="server" AppendDataBoundItems="True"></asp:DropDownList>
                        <asp:RequiredFieldValidator ID="rfvddlCountryTo" runat="server" ControlToValidate="ddlCountryTo" InitialValue="0"
                            CssClass="field-validation-error" ErrorMessage="Please select country To." />
                    </td>

                </tr>
                <tr>



                    <td>
                        <asp:Label ID="Label1" runat="server">Shipping Method:</asp:Label>
                    </td>
                    <td>
                        <asp:DropDownList ID="ddlShippingMethod" runat="server">
                            <asp:ListItem Value="0">--SELECT--</asp:ListItem>
                            <asp:ListItem Value="1">By Sea</asp:ListItem>
                            <asp:ListItem Value="2">By Air</asp:ListItem>
                        </asp:DropDownList>
                    </td>



                    <td>
                        <asp:Label ID="lblTotalM3" runat="server">Total M3:</asp:Label><span class="mandatory">*</span>
                    </td>
                    <td>
                        <asp:TextBox ID="txtTotalM3" runat="server"></asp:TextBox>
                        <asp:RequiredFieldValidator ID="rfvtxtTotalM3" runat="server" ControlToValidate="txtTotalM3"
                            CssClass="field-validation-error" ErrorMessage="Please enter TotalM3." />

                    </td>


                </tr>

                <tr>
                    <td>
                        <asp:Label ID="lblTradeTerms" runat="server">Trade Terms:</asp:Label>
                    </td>
                    <td>
                        <asp:TextBox TextMode="MultiLine" Rows="5" cols="100" ID="txtTradeTerms" runat="server"></asp:TextBox>
                    </td>

                </tr>
                
            </table>
            <asp:Panel ID="pnlEdit" runat="server">
            <div id="divGridView">
                <asp:GridView ID="grdPackingList" runat="server" class="dataGrid" AutoGenerateColumns="False"
                    Width="100%" CellPadding="0" CellSpacing="0" Style="margin-top: 0px;">
                    <Columns>

                        <asp:TemplateField>
                            <HeaderTemplate>
                                Serial No.
                            </HeaderTemplate>
                            <ItemTemplate>
                                <asp:Label ID="lblSRNO" runat="server"
                                    Text='<%#Container.DataItemIndex+1 %>'></asp:Label>
                                <asp:HiddenField ID="hdASNID" runat="server" Value='<%# Eval("ASNID") %>' />
                                <asp:HiddenField ID="hdPurchaseOrderDetailProductId" runat="server" Value='<%# Eval("PurchaseOrderDetailProductId") %>' />
                                <asp:HiddenField ID="hdAsnProductDetailsId" runat="server" Value='<%# Eval("AsnProductDetailsId") %>' />
                                <asp:HiddenField ID="hdProductId" runat="server" Value='<%# Eval("ProductId") %>' />
                            </ItemTemplate>
                        </asp:TemplateField>
                        <asp:TemplateField HeaderText="Carton Starting No">
                            <ItemTemplate>
                                <asp:TextBox runat="server" Width="20px" ID="txtStartinNo" CssClass="number "></asp:TextBox>
                            </ItemTemplate>
                        </asp:TemplateField>
                        <asp:TemplateField HeaderText="Carton Ending No">
                            <ItemTemplate>
                                <asp:TextBox Width="20px" runat="server" ID="txtEndNo" CssClass="number "></asp:TextBox>
                            </ItemTemplate>
                        </asp:TemplateField>
                        <asp:TemplateField HeaderText="Item Code">
                            <ItemTemplate>
                                <asp:Label runat="server" Text='<%#Eval("ItemCode") %>' Width="50px" ID="lblItemCode"></asp:Label>
                            </ItemTemplate>
                        </asp:TemplateField>
                        <asp:TemplateField HeaderText="Description">
                            <ItemTemplate>
                                <asp:Label runat="server" Text='<%#Eval("Description") %>' Width="50px" ID="lblDescription"></asp:Label>
                            </ItemTemplate>
                        </asp:TemplateField>
                        <asp:TemplateField HeaderText="BarCode">
                            <ItemTemplate>
                                <asp:Label runat="server" Text='<%#Eval("BarCode") %>' Width="50px" ID="lblBarCode"></asp:Label>
                            </ItemTemplate>
                        </asp:TemplateField>

                        <asp:TemplateField HeaderText="Unit Price">
                            <ItemTemplate>
                                <asp:TextBox runat="server" value='<%#Eval("UnitPrice") %>' Width="50px" ID="lblPurchaseCost" CssClass="number po-costedit"></asp:TextBox>
                            </ItemTemplate>
                        </asp:TemplateField>
                        <asp:TemplateField HeaderText="Quantity">
                            <ItemTemplate>
                                <asp:TextBox runat="server" value='<%#Eval("Quantity") %>' Width="50px" ID="txtQty" CssClass="number  po-qua"></asp:TextBox>
                            </ItemTemplate>
                        </asp:TemplateField>
                        <asp:TemplateField HeaderText="Amount (S$)">
                            <ItemTemplate>
                                <asp:TextBox runat="server" Width="80px" value='<%#Eval("Amount") %>' ID="txtAmount" CssClass="number po-amt "></asp:TextBox>
                            </ItemTemplate>
                        </asp:TemplateField>
                        <asp:TemplateField HeaderText="Country">
                            <ItemTemplate>
                                <asp:DropDownList runat="server" Width="80px" ID="ddlCountry" DataSource='<%# Eval("CurrencyModels") %>'
                                    DataTextField="CurrencyName" DataValueField="CurrencyId" SelectValue='<%# Eval("CountryId") %>'>
                                </asp:DropDownList>
                            </ItemTemplate>
                        </asp:TemplateField>

                        <asp:TemplateField HeaderText="Size/MM">
                            <ItemTemplate>
                                <asp:TextBox runat="server" Width="80px" ID="txtSize" value='<%#Eval("SizeMM") %>'></asp:TextBox>
                            </ItemTemplate>
                        </asp:TemplateField>
                        <asp:TemplateField HeaderText="G/W@KG">
                            <ItemTemplate>
                                <asp:TextBox runat="server" Width="80px" ID="txtGrossWeight" value='<%#Eval("GWKG") %>'></asp:TextBox>
                            </ItemTemplate>
                        </asp:TemplateField>

                        <asp:TemplateField HeaderText="N/W@KG">
                            <ItemTemplate>
                                <asp:TextBox runat="server" Width="80px" ID="txtNetWeight" value='<%#Eval("NWKG") %>'></asp:TextBox>
                            </ItemTemplate>
                        </asp:TemplateField>
                        <asp:TemplateField HeaderText="No of Cartons">
                            <ItemTemplate>
                                <asp:TextBox runat="server" Width="50px" ID="txtNofofCartons" value='<%#Eval("NoofCartons") %>' CssClass="number "></asp:TextBox>
                            </ItemTemplate>
                        </asp:TemplateField>
                        <asp:TemplateField HeaderText="Weight/Carton">
                            <ItemTemplate>
                                <asp:TextBox runat="server" Width="50px" ID="txtWeightperCarton" value='<%#Eval("WeightCarton") %>'></asp:TextBox>
                            </ItemTemplate>
                        </asp:TemplateField>

                        <asp:TemplateField HeaderText="Quantity/Carton">
                            <ItemTemplate>
                                <asp:TextBox runat="server" Width="50px" ID="txtQtyperCarton" value='<%#Eval("QuantityCarton") %>' CssClass="number "></asp:TextBox>
                            </ItemTemplate>
                        </asp:TemplateField>


                        <asp:TemplateField HeaderText="MF Date">
                            <ItemTemplate>
                                <asp:TextBox runat="server" Width="50px" ID="txtMFDate" value='<%#Eval("MFDate") %>' CssClass="NonEntry calender"></asp:TextBox>
                            </ItemTemplate>
                        </asp:TemplateField>


                    </Columns>

                </asp:GridView>


            </div>
            <br />
            <table class="formGrid" width="50%" cellpadding="0" cellspacing="0">
                <tr>
                    <td>Select Product:
                        <asp:DropDownList ID="drpProduct" runat="server"></asp:DropDownList>
                    </td>
                    <td>
                        <asp:Button ID="btnAddGift" runat="server" Text="Add Gift" CssClass="button" OnClick="btnAddGift_click" CausesValidation="False" />
                    </td>

                </tr>
            </table>
            <div id="div1">
                <asp:GridView ID="grdGiftList" runat="server" class="dataGrid" AutoGenerateColumns="False"
                    Width="100%" CellPadding="0" CellSpacing="0" Style="margin-top: 0px;">
                    <Columns>

                        <asp:TemplateField>
                            <HeaderTemplate>
                                Serial No.
                            </HeaderTemplate>
                            <ItemTemplate>
                                <asp:Label ID="lblSRNO" runat="server"
                                    Text='<%#Container.DataItemIndex+1 %>'></asp:Label>
                                <asp:HiddenField ID="hdASNID" runat="server" Value='<%# Eval("ASNID") %>' />
                                <asp:HiddenField ID="hdPurchaseOrderDetailProductId" runat="server" Value='<%# Eval("PurchaseOrderDetailProductId") %>' />
                                <asp:HiddenField ID="hdAsnProductDetailsId" runat="server" Value='<%# Eval("AsnProductDetailsId") %>' />
                                <asp:HiddenField ID="hdProductId" runat="server" Value='<%# Eval("ProductId") %>' />
                            </ItemTemplate>
                        </asp:TemplateField>
                        <asp:TemplateField HeaderText="Carton Starting No">
                            <ItemTemplate>
                                <asp:TextBox runat="server" Width="20px" ID="txtStartinNo" CssClass="number "></asp:TextBox>
                            </ItemTemplate>
                        </asp:TemplateField>
                        <asp:TemplateField HeaderText="Carton Ending No">
                            <ItemTemplate>
                                <asp:TextBox Width="20px" runat="server" ID="txtEndNo" CssClass="number "></asp:TextBox>
                            </ItemTemplate>
                        </asp:TemplateField>
                        <asp:TemplateField HeaderText="Item Code">
                            <ItemTemplate>
                                <asp:Label runat="server" Text='<%#Eval("ItemCode") %>' Width="50px" ID="lblItemCode"></asp:Label>
                            </ItemTemplate>
                        </asp:TemplateField>
                        <asp:TemplateField HeaderText="Description">
                            <ItemTemplate>
                                <asp:Label runat="server" Text='<%#Eval("Description") %>' Width="50px" ID="lblDescription"></asp:Label>
                            </ItemTemplate>
                        </asp:TemplateField>
                        <asp:TemplateField HeaderText="BarCode">
                            <ItemTemplate>
                                <asp:Label runat="server" Text='<%#Eval("BarCode") %>' Width="50px" ID="lblBarCode"></asp:Label>
                            </ItemTemplate>
                        </asp:TemplateField>

                        <asp:TemplateField HeaderText="Unit Price">
                            <ItemTemplate>
                                <asp:TextBox runat="server" value='<%#Eval("UnitPrice") %>' Width="50px" ID="lblPurchaseCost" CssClass="number po-costedit"></asp:TextBox>
                            </ItemTemplate>
                        </asp:TemplateField>
                        <asp:TemplateField HeaderText="Quantity">
                            <ItemTemplate>
                                <asp:TextBox runat="server" value='<%#Eval("Quantity") %>' Width="50px" ID="txtQty" CssClass="number  po-qua"></asp:TextBox>
                            </ItemTemplate>
                        </asp:TemplateField>
                        <asp:TemplateField HeaderText="Amount (S$)">
                            <ItemTemplate>
                                <asp:TextBox runat="server" Width="80px" value='<%#Eval("Amount") %>' ID="txtAmount" CssClass="number po-amt "></asp:TextBox>
                            </ItemTemplate>
                        </asp:TemplateField>
                        <asp:TemplateField HeaderText="Country">
                            <ItemTemplate>
                                <asp:DropDownList runat="server" Width="80px" ID="ddlCountry" DataSource='<%# Eval("CurrencyModels") %>'
                                    DataTextField="CurrencyName" DataValueField="CurrencyId" SelectValue='<%# Eval("CountryId") %>'>
                                </asp:DropDownList>
                            </ItemTemplate>
                        </asp:TemplateField>

                        <asp:TemplateField HeaderText="Size/MM">
                            <ItemTemplate>
                                <asp:TextBox runat="server" Width="80px" ID="txtSize" value='<%#Eval("SizeMM") %>'></asp:TextBox>
                            </ItemTemplate>
                        </asp:TemplateField>
                        <asp:TemplateField HeaderText="G/W@KG">
                            <ItemTemplate>
                                <asp:TextBox runat="server" Width="80px" ID="txtGrossWeight" value='<%#Eval("GWKG") %>'></asp:TextBox>
                            </ItemTemplate>
                        </asp:TemplateField>

                        <asp:TemplateField HeaderText="N/W@KG">
                            <ItemTemplate>
                                <asp:TextBox runat="server" Width="80px" ID="txtNetWeight" value='<%#Eval("NWKG") %>'></asp:TextBox>
                            </ItemTemplate>
                        </asp:TemplateField>
                        <asp:TemplateField HeaderText="No of Cartons">
                            <ItemTemplate>
                                <asp:TextBox runat="server" Width="50px" ID="txtNofofCartons" value='<%#Eval("NoofCartons") %>' CssClass="number "></asp:TextBox>
                            </ItemTemplate>
                        </asp:TemplateField>
                        <asp:TemplateField HeaderText="Weight/Carton">
                            <ItemTemplate>
                                <asp:TextBox runat="server" Width="50px" ID="txtWeightperCarton" value='<%#Eval("WeightCarton") %>'></asp:TextBox>
                            </ItemTemplate>
                        </asp:TemplateField>

                        <asp:TemplateField HeaderText="Quantity/Carton">
                            <ItemTemplate>
                                <asp:TextBox runat="server" Width="50px" ID="txtQtyperCarton" value='<%#Eval("QuantityCarton") %>' CssClass="number "></asp:TextBox>
                            </ItemTemplate>
                        </asp:TemplateField>


                        <asp:TemplateField HeaderText="MF Date">
                            <ItemTemplate>
                                <asp:TextBox runat="server" Width="50px" ID="txtMFDate" value='<%#Eval("MFDate") %>' CssClass="NonEntry calender"></asp:TextBox>
                            </ItemTemplate>
                        </asp:TemplateField>


                    </Columns>

                </asp:GridView>


            </div>
                </asp:Panel>
            <div class="btn-set">
                <asp:Button ID="btnSubmit" runat="server" Text="Submit" CssClass="button" OnClick="btnSubmit_Click" />
            </div>
        </ContentTemplate>
    </asp:UpdatePanel>
</asp:Content>
