//Object literal
const car = {
    make: "Tesla",
    model: "Cybertruck 2",
    year: 2030,
    color: "White",
    describe() {
        console.log(`${this.year} ${this.make} ${this.model}`);
    },
    getYear() {
        return this.year;
    },
    paintTheCar(color) {
        this.color = color;
        console.log(`The car is now ${this.color}`);
    }
};

//access properties
console.log(car.make);
console.log(car["model"]);
car.color = "Black";
//commented out so methods above work
//delete car.year;
console.log(car);
car.describe();
console.log(car.getYear());
car.paintTheCar("Gold");

//Arrays
const listOfPeople = ["Justin", "Josh", "Tommy", "Carmen"];
console.log(listOfPeople[0]);
console.log(listOfPeople[listOfPeople.length - 1]);
//adding
//unshift adds to beginning
listOfPeople.unshift("Pikachu");
console.log(listOfPeople);
//push adds to end
listOfPeople.push("Eevee");
console.log(listOfPeople);
//Splice adds at index
listOfPeople.splice(2,0,"Egg");
console.log(listOfPeople);

//removing
//shift removes beginning element
listOfPeople.shift();
console.log(listOfPeople);
//pop removes at the end
listOfPeople.pop();
console.log(listOfPeople);
//splice removes at index
listOfPeople.splice(1,1);
console.log(listOfPeople);

//replace
//splice remove then add at index
listOfPeople.splice(2,1, "Hannah");
console.log(listOfPeople);

//other methods
//includes returns true if found
console.log(listOfPeople.includes("Justin"));
console.log(listOfPeople.includes("Egg"));

//indexOf returns index of parameter
console.log(listOfPeople.indexOf("Justin"));
console.log(listOfPeople.indexOf("Egg"));

//findindex uses a function and returns first match
console.log(listOfPeople.findIndex(P => P.length <=5));

//filter create an array using a function
console.log(listOfPeople.filter(P => P.length <=5));
let result = listOfPeople.filter((p) => {
    if(p === "Justin") {
        return p;
    }
    else {
        return "Not Justin";
    }
});

console.log(result);