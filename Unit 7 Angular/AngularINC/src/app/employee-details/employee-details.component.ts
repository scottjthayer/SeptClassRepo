import { Component, OnInit } from '@angular/core';
import { ActivatedRoute } from '@angular/router';
import { Employee } from '../employee';
import { EmployeeService } from '../employee.service';

@Component({
  selector: 'app-employee-details',
  templateUrl: './employee-details.component.html',
  styleUrls: ['./employee-details.component.css']
})
export class EmployeeDetailsComponent implements OnInit {

  employee:Employee = {} as Employee;

  constructor(private router:ActivatedRoute, private service:EmployeeService) { }

  ngOnInit(): void {
    const routeParams = this.router.snapshot.paramMap;
    let id:number = Number(routeParams.get("id"));
    this.employee = this.service.getById(id);
  }

}
