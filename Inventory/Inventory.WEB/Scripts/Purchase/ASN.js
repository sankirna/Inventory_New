var jsonpurchseItemobject;
$(function () {
    $(".calender").datepicker({ dateFormat: 'dd-M-yy' });
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
        SetGridItem($(this));
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
});



function SetGridItem(obj) {
    var trpobj = $(obj).closest("tr");
    var drpObj = $(trpobj).find(".drp-item");
    var descObj = $(trpobj).find(".po-desc");
    var barcodeObj = $(trpobj).find(".po-barcode");
    var costObj = $(trpobj).find(".po-cost");
    // var quapercerObj = $(trpobj).find(".po-quapercer");
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
            $(quaObj).val(obj.Quantity);
            $(amtObj).val(obj.Amount);
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
    return $(obj).val() != "";

}