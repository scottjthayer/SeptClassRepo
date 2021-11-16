import { Component, OnInit } from '@angular/core';
import { NgForm } from '@angular/forms';
import { ToDo } from '../to-do';

@Component({
  selector: 'app-task-list',
  templateUrl: './task-list.component.html',
  styleUrls: ['./task-list.component.css']
})
export class TaskListComponent implements OnInit {

  Tasks:ToDo[] = [
    {
      task:"Wake up",
      completed:true
    },
    {
      task:"Brush teeth",
      completed:true
    },
    {
      task:"Eat Breakfast",
      completed:false
    },
    {
      task:"Make Bed",
      completed:false
    },
  ];

  filteredTasks:ToDo[] = this.Tasks;

  constructor() { }

  ngOnInit(): void {
  }

  setComplete(Index:number):void{
    this.Tasks[Index].completed = true;
  }

  AddTodo(form:NgForm):void{
    let newTodo:ToDo = {
      task: form.form.value.task,
      completed: false
    };

    this.Tasks.push(newTodo);
  }

  isComplete():boolean{
    //empty array
    if(this.Tasks.length == 0){
      return true;
    }
    //all are completed
    else if(this.Tasks.filter(t => t.completed == false).length ==0 ){
      return true;
    }
    //not complete
    else{
      return false;
    }
  }

  filterTasks(input:string):void{
    this.filteredTasks = this.Tasks.filter(T => T.task.includes(input));
  }

  deleteTask(index:number):void{
    let resultTask:ToDo = this.filteredTasks[index];
    this.filteredTasks.splice(index,1);

    let i:number = this.Tasks.indexOf(resultTask);
    this.Tasks.splice(i,1);
  }

  editTask(form:NgForm, index:number):void{
    let resultTask:ToDo = this.filteredTasks[index];
    let i:number = this.Tasks.indexOf(resultTask);
    this.Tasks[i].task = form.form.value.msg;
    this.filteredTasks[index].task = form.form.value.msg;
  }
}
