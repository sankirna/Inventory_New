/// <reference path="../_references.js" />

var productObj = new Object();
productObj.ItemCode = "0102";
productObj.ItemId = 1;
productObj.ItemCode = 103;
productObj.ItemDescription = "ItemDescription";
productObj.BarCode = 2302;
productObj.PurchaseCost = 10;
productObj.Cost = 0;
productObj.Quantity = 0;
productObj.Amount = 0;


// Product Item Add
function ProductItem(product) {
    var self = this;
    self.ItemCode = ko.observable(product.ItemCode);
    self.ItemId = ko.observable(product.ItemId);
    self.SelectedItemId = ko.observable(0);
    self.ItemCode = ko.observable(product.ItemCode);
    self.ItemDescription = ko.observable(product.ItemDescription);
    self.BarCode = ko.observable(product.BarCode);
    self.PurchaseCost = ko.observable(product.PurchaseCost);
    self.Cost = ko.observable(product.Cost);
    self.Quantity = ko.observable(product.Quantity);
    //self.Amount = ko.observable(product.Amount);

    self.Amount = ko.computed(function () {
        return self.Quantity() * self.Cost();
    }, self);


}

// Common Dropdown Bindings
function DropDownModel(drpItem) {
    var self = this;
    self.value = ko.observable(drpItem.drpValue);
    self.text = ko.observable(drpItem.drpText);
}

// Purchase main Model binding
function PurchaseOrderViewModel() {
    var self = this;
    self.SupplierDrp = ko.observableArray([]);
    self.ProductDrp = ko.observableArray([]);
    self.ProductItems = ko.observableArray([]);
    self.SupplierId = ko.observable();

    self.SetProduct = function (itmId) {
        //var testValue;
        //for (var i in self.ProductItems()) {
        //    if (self.ProductItems()[i].ItemId() == itmId()) {
        //        alert(self.ProductItems()[i].ItemId());
        //        alert(itmId());
        //        testValue = self.ProductItems()[i];
        //    }
        //}
        //  var test = productId();
    };

    self.init = function () {

        for (var i = 0; i < 10; i++) {
            var Drpsuppliers = new Object();
            Drpsuppliers.drpValue = i;
            Drpsuppliers.drpText = "supplier " + i;
            self.SupplierDrp.push(new DropDownModel(Drpsuppliers));
        }

        for (var i = 0; i < 10; i++) {
            var DrpProduct = new Object();
            DrpProduct.drpValue = i;
            DrpProduct.drpText = "Product " + i;
            self.ProductDrp.push(new DropDownModel(DrpProduct));
        }

        for (var i = 0; i < 10; i++) {
            var productObj1 = new Object();
            productObj1.ItemCode = 0102 + i;
            productObj1.ItemId = i;
            productObj1.SelectedItemId = i;
            productObj1.ItemCode = 103 + i;
            productObj1.ItemDescription = "ItemDescription " + i;
            productObj1.BarCode = 2302 + i;
            productObj1.PurchaseCost = 10 + i;
            productObj1.Cost = 20 + i;
            productObj1.Quantity = 5 + i;
            productObj1.Amount = 45 + i;
            self.ProductItems.push(new ProductItem(productObj1));
        }

    }();

    self.add = function () {
        self.ProductItems.push(new ProductItem(productObj));
    };
}



var model;
$(function () {
    model = new PurchaseOrderViewModel();
    ko.applyBindings(model, document.getElementById("formPurchase"));
});