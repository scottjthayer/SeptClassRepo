import { Injectable } from '@angular/core';
import { Employee } from './employee';

@Injectable({
  providedIn: 'root'
})
export class EmployeeService {

  Employees:Employee[] = [
    {
      ID: 30114928,
      Name: "Chase Alexander",
      Role: "Assistant Manager",
      Salary: 60000,
      Age: 39
    },
    {
      ID: 1020304,
      Name: "Miranda Wright",
      Role: "Manager",
      Salary: 72000,
      Age: 34
    },
    {
      ID: 90903312,
      Name: "Chrys Anthemum",
      Role: "Employee",
      Salary: 42000,
      Age: 42
    },
  ]

  getAll():Employee[] {
    return this.Employees;
  }

  getById(id:number):Employee{
    let result:Employee = {} as Employee;
    this.Employees.forEach((E:Employee) =>{
      if(E.ID == id){
        result = E;
      }
    });

    return result;
  }

  constructor() { }
}
