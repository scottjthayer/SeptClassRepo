import { Component, OnInit } from '@angular/core';
import { HallOfFame } from '../hall-of-fame';
import { TechApiService } from '../tech-api.service';

@Component({
  selector: 'app-hall-of-fame',
  templateUrl: './hall-of-fame.component.html',
  styleUrls: ['./hall-of-fame.component.css']
})
export class HallOfFameComponent implements OnInit {

  HallOfFameList: HallOfFame[] = [];

  constructor(private TechService:TechApiService) { }

  ngOnInit(): void {
    this.TechService.getHallOfFame().subscribe((response:any) => {
      // console.log(response);
      this.HallOfFameList = response.complete;
      console.log(this.HallOfFameList);
    }, () => {
      console.log("Error loading");
    })
  }

}
