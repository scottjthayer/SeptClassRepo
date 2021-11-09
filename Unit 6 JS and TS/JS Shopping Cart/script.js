let cart = []; //Where items get added

function addItem(_name, _price){
    let _quantity = prompt("How many would you like to purchase?");
    let item = {
        name: _name,
        price: _price,
        quantity: _quantity
    };
    cart.push(item);
}

function CheckOut(){
    document.getElementById("Receipt").innerHTML = "";
    let Total = 0;
    for(let Item of cart){
        Total += Item.price * Item.quantity;
        document.getElementById("Receipt").innerHTML+= `<div class="row">
        <h2 class="col">${Item.name}</h2>
        <p class="col">${Item.price} x ${Item.quantity}</p>
        </div>`;
        // console.log(`${Item.name}: ${Item.price} x ${Item.quantity}`);
    }
    document.getElementById("Receipt").innerHTML+= `<h2>Total: ${Total}</h2>`;
    // console.log(`Total: ${Total}`);

    cart = [];
}

// function CheckOut(){
//     let Total = 0;
//     for(let Item of cart){
//         Total += Item.price * Item.quantity;
//         console.log(`${Item.name}: ${Item.price} x ${Item.quantity}`);
//     }
//     console.log(`Total: ${Total}`);

//     cart = [];
// }

// function addRedBull(){
//     let item = {
//         name: "RedBull",
//         price: 3.00
//     };
//     cart.push(item);
// }

// function addChips(){
//     let item = {
//         name: "Chips",
//         price: 2.00
//     };
//     cart.push(item);
// }

// function addWater(){
//     let item = {
//         name: "Water",
//         price: 1.00
//     };
//     cart.push(item);
// }

