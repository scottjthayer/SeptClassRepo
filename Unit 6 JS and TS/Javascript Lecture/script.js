//var allows for delcaring/reassigning/redeclaring
var BadVariable = 1;
BadVariable = "Justin";
var BadVariable = true;

//let allows for delcaring/reassigning
let GoodVariable = 1;
GoodVariable = 20;
// let GoodVaraible = 3 // This throws an error

//const allows for declaring
const tax = 0.06;
//tax = 0.01 //this throws an error
//const tax = 1.50 //this throws an error

//Display to console
console.log(`The current tax rate is ${tax}`);

//objects
const myInfo = {
    name: "Justin",
    FavoriteFood: "Baja Blast",
    Hometown: "Wyoming",
    Langauges: {
        Favorite: "C#",
        Least: "Javascript"
    }
};

console.log(myInfo);
console.log(myInfo.name);
console.log(myInfo.Langauges.Favorite);
//why does this work???
myInfo.car = "Mercury Milan";
console.log(myInfo);

//if statement
if(myInfo.name === "Justin" && myInfo.car === "Mercury Milan")
{
    console.log("Welcome Master");
}
else if (myInfo.name === "Anthony" || myInfo.name === "Alice")
{
    console.log("Get off the computer");
}
else
{
    console.log("Who are you?");
} 

//USER INPUT
const choice = prompt("Select a size");

//switch statement
switch (choice) {
    case "small":
        console.log("You have ordered a small shirt");
        break;
    case "medium":
        console.log("You have ordered a medium shirt");
        break;
    case "large":
        console.log("You have ordered a large shirt");
        break;
    default:
        console.log("We do not have that size");
        break;
}

//ternary operator
const age = 1;
const canVote = age >= 18 ? true: false;

console.log(canVote);

//for loop
for(let i = 0; i<= 10; i++){
    console.log(i);
}

//while loop
let result = null;
while(true)
{
    result = prompt("Please enter 'hi'");
    if(result ==="hi")
    {
        break;
    }
}

//do while
let userPass = null;
do {
    userPass = prompt("What is your password?");
}while(userPass !== "secret");

//ARRAYS
let Langauges = ["Java", "JavaScript", "Ruby", "Python", "C#", "PHP", "HTML", "CSS"];

//for of loop
//use to loop through arrays

for(let L of Langauges) {
    console.log(L);
}

//for in loop
//use to loop through object property names

for(let prop in myInfo){
    console.log(prop);
}

//functions
function greetClass() {
    console.log("Hello Class!");
}

greetClass();

//function with return and parameters
function adder(x, y){
    return x + y;
}

console.log(adder(5,9));

//arrow function
const subber = (x, y) => x-y;

console.log(subber(10,5));

const multipler = (x,y) => {
    let result = x*y;
    return result;
}

console.log(multipler(7,8));

function logRectInfo(x, y){
    let width = y[0]-x[0];
    let length = x[1]-y[1]; 

    let area = length * width;
    let perimeter = 2*(length + width);

    console.log(area);
    console.log(perimeter);
}

logRectInfo([0,5] , [3,2]);
logRectInfo([1,1] , [2,2]);
logRectInfo([0,0] , [300,200]);

//onclick example

let clickCount = 0;

function AddCount(){
    clickCount++;
    console.log(clickCount);
}