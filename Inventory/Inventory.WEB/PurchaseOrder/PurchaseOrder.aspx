<%@ Page Title="" Language="C#" MasterPageFile="~/Inventory.Master" AutoEventWireup="true" CodeBehind="PurchaseOrder.aspx.cs" Inherits="Inventory.Web.PurchaseOrder.PurchaseOrder" %>

<asp:Content ID="Content1" ContentPlaceHolderID="HeadContent" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">
    <script src="../Scripts/PurchaseOrder/PONew.js"></script>
    <script type="text/javascript">
        var jsonpurchseItemobject;
        $(document).ready(function () {
            //Sys.WebForms.PageRequestManager.getInstance().add_endRequest(SetDatePicker);
          
        });

        function SetDatePicker() {
            $("#<%=txtPODate.ClientID%>").datepicker({ dateFormat: 'dd/mm/yy' });
        }

        $(function () {
          
            SetLoadEvent();
            
        });


        function SetLoadEvent() {
            SetDatePicker();
            $(".number").keydown(function (e) {

                var keyCode = e.which; // Capture the event

                //190 is the key code of decimal if you dont want decimals remove this condition keyCode != 190
                if (keyCode != 8 && keyCode != 9 && keyCode != 13 && keyCode != 37 && keyCode != 38 && keyCode != 39 && keyCode != 40 && keyCode != 46 && keyCode != 110 && keyCode != 190) {
                    if (keyCode < 48) {
                        e.preventDefault();
                    }
                    else if (keyCode > 57 && keyCode < 96) {
                        e.preventDefault();
                    }
                    else if (keyCode > 105) {
                        e.preventDefault();
                    }
                }
            });

            $(".drp-item").change(function (e) {
                SetGridItem($(this))
            });

            $(".number").blur(function (e) {
                var trpobj = $(this).closest("tr");
                var costeditObj = $(trpobj).find(".po-costedit");
                var quaObj = $(trpobj).find(".po-qua");
                var amtObj = $(trpobj).find(".po-amt");
                if (checkNumenric(costeditObj) && checkNumenric(quaObj)) {
                    $(amtObj).val(parseFloat($(costeditObj).val()) * parseFloat($(quaObj).val()));
                }
            });

            $('.dataGrid > tbody  > tr').each(function (j, e) {
                var trpobj = $(this);
                var drpObj = $(trpobj).find(".drp-item");
                var descObj = $(trpobj).find(".po-desc");
             //   var quapercerObj = $(trpobj).find(".po-quapercer");
                var barcodeObj = $(trpobj).find(".po-barcode");
                var costObj = $(trpobj).find(".po-cost");
                var currencyObj = $(trpobj).find(".currecy");
                if (j != 0) {
                    for (var i = 0 ; i < jsonpurchseItemobject.length; i++) {
                        var obj = jsonpurchseItemobject[i];
                        if (obj.ProductID == $(drpObj).val()) {
                            $(descObj).html(obj.Description);
                            $(barcodeObj).html(obj.BarCode);
                            $(costObj).html(obj.Cost);
                       //     $(quapercerObj).html(obj.QtyPerCarton);
                            $(currencyObj).html(obj.CurrencyCode);
                        }
                        else {
                            //   $(drpObj).val("0");
                            //$(descObj).html("");
                            //$(barcodeObj).html("");
                            //$(costObj).html("");

                        }
                    }
                }
            });
        }

        function SetGridItem(obj) {
            var trpobj = $(obj).closest("tr");
            var drpObj = $(trpobj).find(".drp-item");
            var descObj = $(trpobj).find(".po-desc");
            var barcodeObj = $(trpobj).find(".po-barcode");
            var costObj = $(trpobj).find(".po-cost");
           // var quapercerObj = $(trpobj).find(".po-quapercer");
            var amtObj = $(trpobj).find(".po-amt");
            var costeditObj = $(trpobj).find(".po-costedit");
            var quaObj = $(trpobj).find(".po-qua");
            var amtObj = $(trpobj).find(".po-amt");
            var currencyObj = $(trpobj).find(".currecy");
            //quapercer
            for (var i = 0 ; i < jsonpurchseItemobject.length; i++) {
                var obj = jsonpurchseItemobject[i];
                if (obj.ProductID == $(drpObj).val()) {
                    $(descObj).html(obj.Description);
                    $(barcodeObj).html(obj.BarCode);
                    $(costObj).html(obj.Cost);
                    //$(quapercerObj).html(obj.QtyPerCarton);
                    $(costeditObj).val(obj.Cost);
                    $(quaObj).val("0");
                    $(amtObj).val("0");
                    $(currencyObj).html(obj.CurrencyCode);
                    break;
                }
                else {
                    //$(drpObj).val("0");
                    $(descObj).html("");
                    $(barcodeObj).html("");
                    $(costObj).html("");
                   // $(quapercerObj).html("");
                    $(costeditObj).val("0");
                    $(quaObj).val("0");
                    $(amtObj).val("0");
                   // $(quapercerObj).html("");
                    $(currencyObj).html("");
                }
                $(quaObj).blur();
            }
            if (checkNumenric(costeditObj) && checkNumenric(quaObj)) {
                $(amtObj).val(parseFloat($(costeditObj).val()) * parseFloat($(quaObj).val()));
            }
        }

        function checkNumenric(obj) {
          return  $(obj).val() != "";

        }

    </script>
    <style>
        .po-cost {
            display:inline !important;
        }
    </style>
    <h1 class="title">PURCHASE ORDER 
       
                  </h1>
    <!-- This is a *view* - HTML markup that defines the appearance of your UI -->



    <table class="formGrid" width="100%" cellpadding="0" cellspacing="0">
        <tr>
            <td>
                <asp:Label ID="lblSupplier" runat="server">Supplier</asp:Label><span class="mandatory">*</span>
            </td>
            <td>
                <asp:DropDownList runat="server" ID="ddSupplier">
                </asp:DropDownList>
                <asp:RequiredFieldValidator ID="rfvCustomer" runat="server" ControlToValidate="ddSupplier" InitialValue="0"
                    CssClass="field-validation-error" ErrorMessage="Supplier field is required." />
            </td>
        </tr>
        <tr>
            <td>
                <asp:Label ID="lblDate" runat="server">PO Date:</asp:Label><span class="mandatory">*</span>
            </td>
            <td>
                <asp:TextBox ID="txtPODate" CssClass="NonEntry" runat="server"></asp:TextBox>
                <asp:RequiredFieldValidator ID="rfvPODate" runat="server" ControlToValidate="txtPODate" 
                    CssClass="field-validation-error" ErrorMessage="Please select Po Date." />
            </td>

        </tr>
        <tr>
            <td>
                <asp:Label ID="lblTermcondition" runat="server">Term Condition:</asp:Label>
            </td>
            <td>
                <asp:TextBox ID="txtTermcondition" CssClass="NonEntry" runat="server" TextMode="MultiLine"></asp:TextBox>
            </td>

        </tr>
    </table>
    <asp:Button ID="btnPOAdd" CssClass="button f-right" runat="server" Text="Add More Rows" Width="110px" OnClick="btnPOAdd_Click" CausesValidation="false" />
    <div class="clear"></div>
    <div id="divGridView">
        <asp:GridView ID="grdPurchaseOrder" runat="server" class="dataGrid" AutoGenerateColumns="False"
            Width="100%" CellPadding="0" CellSpacing="0" Style="margin-top: 0px;">
            <Columns>
                <asp:TemplateField>
                    <ItemTemplate>
                        <asp:HiddenField ID="hdPurchaseOrderDetailID" runat="server" Value='<%# Eval("PurchaseOrderDetailID") %>' />
                        <asp:HiddenField ID="hdPurchaseOrderID" runat="server" Value='<%# Eval("PurchaseOrderID") %>' />
                    </ItemTemplate>
                </asp:TemplateField>
                <asp:TemplateField>
                    <HeaderTemplate>
                        Serial No.
                    </HeaderTemplate>
                    <ItemTemplate>
                        <asp:Label ID="lblSRNO" runat="server"
                            Text='<%#Container.DataItemIndex+1 %>'></asp:Label>
                    </ItemTemplate>
                </asp:TemplateField>

                <asp:TemplateField HeaderText="ItemCode">
                    <ItemTemplate>
                        <asp:DropDownList runat="server" ID="drpItemCode" DataSource='<%# Eval("Products") %>' DataTextField="Code" DataValueField="ProductID" SelectedValue='<%# Eval("ProductID") %>'
                            CssClass="drp-item">
                        </asp:DropDownList>
                    </ItemTemplate>
                </asp:TemplateField>
                <asp:TemplateField HeaderText="Description">
                    <ItemTemplate>
                        <asp:Label runat="server" Width="200px" ID="lblDescription" CssClass="po-desc"></asp:Label>
                    </ItemTemplate>
                </asp:TemplateField>
                <asp:TemplateField HeaderText="BarCode">
                    <ItemTemplate>
                        <asp:Label runat="server" Width="120px" ID="lblBarCode" CssClass="po-barcode"></asp:Label>
                    </ItemTemplate>
                </asp:TemplateField>
                <asp:TemplateField HeaderText="Purchase Cost">
                    <ItemTemplate>
                        
                      <span style="display:inline" class="currecy"></span>  <asp:Label runat="server" Width="80px" ID="lblPurchaseCost"  CssClass="po-cost"></asp:Label>
                           
                    </ItemTemplate>
                </asp:TemplateField>

                <%--<asp:TemplateField HeaderText="Qty per Carton" >
                    <ItemTemplate>
                        <asp:Label runat="server" Width="50px" ID="lblQuaPerCer" CssClass="po-quapercer"></asp:Label>
                    </ItemTemplate>
                </asp:TemplateField>--%>
                <asp:TemplateField HeaderText="Actual Cost">
                    <ItemTemplate>
                       <span class="currecy" style="display:inline"></span> <asp:TextBox runat="server" Width="75px" ID="txtCost" CssClass="po-costedit number" Text='<%# Eval("Cost") %>'></asp:TextBox>
                    </ItemTemplate>
                </asp:TemplateField>
                <asp:TemplateField HeaderText="Quantity">
                    <ItemTemplate>
                        <asp:TextBox runat="server" Width="50px" ID="txtQty" CssClass="po-qua number" Text='<%# Eval("Quantity") %>'></asp:TextBox>
                    </ItemTemplate>
                </asp:TemplateField>
                <asp:TemplateField HeaderText="Amount">
                    <ItemTemplate>
                        <div class="test">
                     <span class="currecy" style="display:inline"></span>   <asp:TextBox runat="server" Width="50px" ID="txtAmount" CssClass="po-amt number" Text='<%# Eval("Amount") %>' ></asp:TextBox>
                            </div>
                    </ItemTemplate>
                </asp:TemplateField>

            </Columns>
        </asp:GridView>


    </div>

    <div class="btn-set">
        <asp:Button ID="btnSubmit" runat="server" Text="Submit" CssClass="button" OnClick="btnSubmit_Click" />
    </div>
</asp:Content>
