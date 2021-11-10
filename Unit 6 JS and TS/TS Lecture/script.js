"use strict";
exports.__esModule = true;
var MyName = "Justin";
var MyAge = 24;
var IsDeveloper = true;
var MyPets = ["Alice", "Anthony"];
var RandomThoughts = [1, "hi"];
console.log("My name is " + MyName + " and I am " + MyAge);
var Cat = {
    name: "Garfield",
    age: 45,
    isFurry: true
};
console.log(Cat.name);
console.log(Cat);
//if statement
if (Cat.name == "Garfield") {
    console.log("Hello Chris Pratt");
}
else if (Cat.name == "Mario") {
    console.log("Hello Chriss Pratt");
}
else {
    console.log("Who are you?");
}
//loops
for (var i = 0; i < 10; i++) {
    console.log(i);
}
var age = 0;
while (age <= MyAge) {
    console.log(age);
    age++;
}
MyPets.forEach(function (P) {
    console.log(P);
});
//functions
function GreetUser(Name) {
    console.log("Hello " + Name);
}
GreetUser("Jeff");
//classes
var Student = /** @class */ (function () {
    function Student(firstName, middleInitial, lastName) {
        this.firstName = firstName;
        this.middleInitial = middleInitial;
        this.lastName = lastName;
        this.fullName = firstName + " " + middleInitial + ". " + lastName + " ";
    }
    return Student;
}());
var Josh = new Student("Josh", "B", "Carolin");
console.log(Josh.fullName);
