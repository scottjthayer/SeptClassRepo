import { Component } from '@angular/core';
import { Animal } from './animal';

@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  styleUrls: ['./app.component.css']
})
export class AppComponent {
  title = 'exercises';

  animals: Animal[] = [
    {
      name:"Eagle2",
      classification:"Bird"
    },
    {
      name:"Dog",
      classification:"Mammal"
    },
    {
      name:"Goldfish",
      classification:"Fish"
    },
    {
      name:"Cat",
      classification:"Mammal"
    },
    {
      name:"Snake",
      classification:"Reptile"
    },
    {
      name:"Komodo Dragon",
      classification:"Reptile"
    },
    {
      name:"Eagle",
      classification:"Bird"
    }
  ];

  getAllUniqueClassifications():string[]{
    let result: string[] = [];
    this.animals.forEach((A:Animal) => {
      if(result.includes(A.classification) == false){
        result.push(A.classification);
      }
    })

    return result;
  }

  getAnimalsByClassifcation(classification:string):Animal[]{
    return this.animals.filter( (a:Animal) => a.classification == classification );
  }

  // getAnimalsByClassifcation(classification:string):Animal[]{
  //   return this.animals.filter( (a:Animal) => {
  //     return a.classification == classification
  //   } );
  // }
}
