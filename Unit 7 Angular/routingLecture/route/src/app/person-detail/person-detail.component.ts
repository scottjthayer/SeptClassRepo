import { Component, OnInit } from '@angular/core';
import { ActivatedRoute } from '@angular/router';
import { PeopleService } from '../people.service';
import { Person } from '../person';

@Component({
  selector: 'app-person-detail',
  templateUrl: './person-detail.component.html',
  styleUrls: ['./person-detail.component.css']
})
export class PersonDetailComponent implements OnInit {

  person:Person = {} as Person;

  constructor(private route:ActivatedRoute, private peopleservice:PeopleService) { }

  ngOnInit(): void {
    const routeParams = this.route.snapshot.paramMap;
    let id:number = Number(routeParams.get("id"));

    this.person = this.peopleservice.getById(id);
  }

}
