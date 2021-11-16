import { Component, OnInit } from '@angular/core';
import { PeopleService } from '../people.service';
import { Person } from '../person';

@Component({
  selector: 'app-people',
  templateUrl: './people.component.html',
  styleUrls: ['./people.component.css']
})
export class PeopleComponent implements OnInit {

  constructor(private peopleservice:PeopleService) { }

  peopleList:Person[] = [];

  ngOnInit(): void {
    this.peopleList = this.peopleservice.getClassroom();
  }

}
