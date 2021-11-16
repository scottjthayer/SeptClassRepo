import { Component, OnInit } from '@angular/core';
import { NgForm } from '@angular/forms';
import { Hero } from '../hero';
import { HeroService } from '../hero.service';

@Component({
  selector: 'app-hero-list',
  templateUrl: './hero-list.component.html',
  styleUrls: ['./hero-list.component.css']
})
export class HeroListComponent implements OnInit {

  constructor(private hero_service:HeroService) { }

  ngOnInit(): void {
  }

  displayHeros():Hero[] {
    return this.hero_service.getHeros();
  }

  AddHero(form:NgForm):void{
    let newHero:Hero = {
      name: form.form.value.Name,
      power: form.form.value.Power,
      alterEgo: form.form.value.AlterEgo
    }

    this.hero_service.addHero(newHero);
  }

}
