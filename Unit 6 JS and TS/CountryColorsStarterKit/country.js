class Country {
    constructor(name, lang, greeting, colors, img) {
        this.name = name;
        this.lang = lang;
        this.greeting = greeting;
        this.colors = colors;
        this.img = img;
    }
    Display(){
        document.getElementById("CountryName").innerText = this.name;
        document.getElementById("OfficialLanguage").innerText = this.lang;
        document.getElementById("HelloWorld").innerText = this.greeting;
        //colors
        document.getElementById("Color1").style.backgroundColor = this.colors[0];
        document.getElementById("Color2").style.backgroundColor = this.colors[1];
        document.getElementById("Color3").style.backgroundColor = this.colors[2];
        //flag
        document.getElementById("flag").src = this.img;
    }
}
let usa = new Country("USA", "Murican", "Why Hello there world! Have some McDonalds", ["red", "white", "blue"],"https://upload.wikimedia.org/wikipedia/en/thumb/a/a4/Flag_of_the_United_States.svg/125px-Flag_of_the_United_States.svg.png");
let mexico = new Country("Mexico", "Spanish", "Hola mundo!", ["red", "white", "green"],"https://upload.wikimedia.org/wikipedia/commons/thumb/f/fc/Flag_of_Mexico.svg/125px-Flag_of_Mexico.svg.png");
let algeria = new Country("Algeria", "Arabic and Berber", "Sup", ["blue", "yellow", "red"], "https://upload.wikimedia.org/wikipedia/commons/thumb/7/77/Flag_of_Algeria.svg/125px-Flag_of_Algeria.svg.png")
let brazil = new Country("Brazil", "Portuguese", "Olá Mundo", ["green", "yellow", "white"], "https://upload.wikimedia.org/wikipedia/en/thumb/0/05/Flag_of_Brazil.svg/125px-Flag_of_Brazil.svg.png")
let germany = new Country("Germany", "German", "Hallo Welt", ["black", "red", "gold"], "https://upload.wikimedia.org/wikipedia/en/thumb/b/ba/Flag_of_Germany.svg/125px-Flag_of_Germany.svg.png")

function SwitchCountry() {
    let input = document.getElementById("CountryList").value;
    console.log(input);
    let country;

    if (input === "USA") {
        //set country to usa 
        country = usa;
    }
    else if (input === "Mexico") {
        country = mexico;
    }
    else if (input === "Algeria") {
        country = algeria;
    }
    else if (input === "Brazil") {
        country = brazil;
    }
    else if (input === "Germany") {
        country = germany;
    }

    country.Display();
}
