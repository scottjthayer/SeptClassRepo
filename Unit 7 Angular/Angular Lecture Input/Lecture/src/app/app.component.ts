import { Component } from '@angular/core';
import { NgForm } from '@angular/forms';

@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  styleUrls: ['./app.component.css']
})
export class AppComponent {
  title = 'Lecture';
  names:string[] = [
    'Justin', 'Rustin', 'Bustin', 'Dustin', 'Steve'
  ]
  age:number = 0;

  changeTitle(newTitle:string):void {
    this.title = newTitle;
  }

  addName(form:NgForm):void{
    let newName = form.form.value.name;
    this.names.push(newName);
  }

  setAge(form:NgForm):void{
    this.age = form.form.value.age;
  }
}
