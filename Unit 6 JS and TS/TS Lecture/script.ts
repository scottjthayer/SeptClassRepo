export {};

let MyName: string = "Justin";
let MyAge: number = 24;
let IsDeveloper: boolean = true;
let MyPets: string[] = ["Alice", "Anthony"];
let RandomThoughts: any = [1,"hi"];

console.log(`My name is ${MyName} and I am ${MyAge}`);

interface Animal {
    name: string;
    age: number;
    isFurry: Boolean;
}

let Cat: Animal = {
    name: "Garfield",
    age:45,
    isFurry:true
};

console.log(Cat.name);
console.log(Cat);

//if statement
if(Cat.name == "Garfield"){
    console.log("Hello Chris Pratt");
} else if (Cat.name == "Mario"){
    console.log("Hello Chriss Pratt");
}
else{
    console.log("Who are you?");
}

//loops
for(let i:number = 0; i<10; i++){
    console.log(i);
}
let age: number =0;
while(age <= MyAge){
    console.log(age);
    age++;
}

MyPets.forEach(function (P:string) {
    console.log(P);
});

//functions
function GreetUser(Name:string):void {
    console.log(`Hello ${Name}`);
}

GreetUser("Jeff");

//classes
class Student {
    fullName: string;
    constructor(public firstName: string, public middleInitial: string, public lastName: string){
        this.fullName = `${firstName} ${middleInitial}. ${lastName} `;
    }
}

let Josh: Student = new Student("Josh", "B", "Carolin");
console.log(Josh.fullName);

