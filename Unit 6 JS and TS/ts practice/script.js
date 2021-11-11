"use strict";
exports.__esModule = true;
var mountains = [
    {
        name: "Kilimanjaro",
        height: 19341
    },
    {
        name: "Everest",
        height: 29029
    },
    {
        name: "Denali",
        height: 20310
    },
];
function findNameOfTallestMountain(mountainList) {
    var result = { name: "", height: 0 };
    mountainList.forEach(function (M) {
        if (M.height > result.height) {
            result = M;
        }
    });
    return result.name;
}
var TallestName = findNameOfTallestMountain(mountains);
console.log(TallestName);
var products = [
    {
        name: "Beer",
        price: 2.50
    },
    {
        name: "Cigs",
        price: 6.99
    },
    {
        name: "Slushie",
        price: 1.99
    },
    {
        name: "Soda",
        price: 2.00
    }
];
function calcAverageProductPrice(ProductList) {
    var result = 0;
    ProductList.forEach(function (P) {
        result += P.price;
    });
    return result / ProductList.length;
}
var AvgPrice = calcAverageProductPrice(products);
console.log(AvgPrice);
var Inventory = [
    {
        product: {
            name: "motor",
            price: 10
        },
        quantity: 10
    },
    {
        product: {
            name: "sensor",
            price: 12.50
        },
        quantity: 4
    },
    {
        product: {
            name: "LED",
            price: 1
        },
        quantity: 20
    },
];
function calcInventoryValue(InventoryList) {
    var result = 0;
    InventoryList.forEach(function (I) {
        result += I.product.price * I.quantity;
    });
    return result;
}
var inventoryValue = calcInventoryValue(Inventory);
console.log(inventoryValue);
