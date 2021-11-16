import { Injectable } from '@angular/core';
import { Hero } from './hero';

@Injectable({
  providedIn: 'root'
})
export class HeroService {

  constructor() { }
  Heros:Hero[] = [
    {
      name:"Peter Parker",
      power:"Spider Senses",
      alterEgo:"Spiderman"
    },
    {
      name:"Lyra",
    power:"Super indifference",
    alterEgo:"Captain Feline"
  },
  {
    name: "Al Simmons",
     power: "Hellspawn",
      alterEgo: "Spawn"
    },
  {
    name: "Dave Montana", 
    power: "Mountain Goat Hooves", 
    alterEgo: "Mountain Man"
    },
    {
      name: "Jon Stewart",
      power: "Green Lantern Ring",
      alterEgo: "Green Lantern"
    },
    {
      name:"Saitama",
      power:"God",
      alterEgo:"One-Punch Man"
    },
    {
      name:"Clark Kent",
      power:"Super powers",
      alterEgo:"Superman"
    },
    {name: "James Logan Howlett",
power: "regenerative ability",
alterEgo: "wolverine"
},
  ];

  getHeros():Hero[]{
    return this.Heros;
  }

  addHero(newHero:Hero):void{
   this.Heros.push(newHero); 
  }

}
