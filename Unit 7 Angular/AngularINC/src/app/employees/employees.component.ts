import { Component, OnInit } from '@angular/core';
import { Employee } from '../employee';
import { EmployeeService } from '../employee.service';

@Component({
  selector: 'app-employees',
  templateUrl: './employees.component.html',
  styleUrls: ['./employees.component.css']
})
export class EmployeesComponent implements OnInit {

  employeeList: Employee[] = [];
  constructor(private employeeservice: EmployeeService) { }

  ngOnInit(): void {
    this.employeeList = this.employeeservice.getAll();
  }

}
