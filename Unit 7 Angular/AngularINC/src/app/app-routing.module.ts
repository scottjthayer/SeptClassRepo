import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { AboutComponent } from './about/about.component';
import { EmployeeDetailsComponent } from './employee-details/employee-details.component';
import { EmployeesComponent } from './employees/employees.component';

const routes: Routes = [
  {path: 'Employees', component: EmployeesComponent },
  {path: 'Employees/:id', component: EmployeeDetailsComponent },
  {path: 'About', component: AboutComponent },
  { path: '', redirectTo:'/Employees', pathMatch: 'full'},
  { path:'**', component:EmployeesComponent}
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
