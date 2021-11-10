//returns body element
const bodyNode = document.body;
//return html element
const htmlNode = document.body.parentNode;
//return all of body's children
const childNodes = document.body.childNodes;
//return target element using the id
let nav = document.getElementById("top-nav");
//return target element using element/id/class
let link1 = document.querySelector(".link1");
//return array of elements using element/id/class
let allLinks = document.querySelectorAll("a");

let header = document.getElementById("Header");
header.innerText = "WELCOME TO MY WEBSITE";
header.style.color = "Green";

function TurnOnLight(){
    let light = document.getElementById("LightBulb");
    light.classList.add("LightOn");
    light.classList.remove("LightOff");
}

function TurnOffLight() {
    let light = document.getElementById("LightBulb");
    light.classList.remove("LightOn");
    light.classList.add("LightOff");
}

function GetName(){
    let UserInput = document.getElementById("MyName");
    let result = UserInput.value;
    document.getElementById("NameResult").innerText = `Welcome to my page ${result}`;
}