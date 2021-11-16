import { Injectable } from '@angular/core';
import { Person } from './person';

@Injectable({
  providedIn: 'root'
})
export class PeopleService {

  Classroom:Person[] = [
    {
      id:0,
      name:"Justin",
      favFood:"Baja Blast"
    },
    {
      id: 1,
      name:"Bustin",
      favFood:"Tacos"
    },
    {
      id: 2,
      name:"Dustin",
      favFood:"Burritos"
    }
  ];

  constructor() { }

  getClassroom():Person[]{
    return this.Classroom;
  }
  getById(id:number):Person{
    let result:Person = {} as Person;
    this.Classroom.forEach((P:Person) =>{
      if(P.id == id){
        result = P;
      }
    })
    return result;
  }

}
