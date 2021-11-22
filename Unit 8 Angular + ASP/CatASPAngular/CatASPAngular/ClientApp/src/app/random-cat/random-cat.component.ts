import { Component } from '@angular/core';
import { NgForm } from '@angular/forms';
import { Observable } from 'rxjs';
import { AuthorizeService } from '../../api-authorization/authorize.service';
import { Cat } from '../Cat';
import { CatService } from '../cat.service';
import { UserService } from '../user.service';

@Component({
    selector: 'app-random-cat',
    templateUrl: './random-cat.component.html',
    styleUrls: ['./random-cat.component.css']
})
/** RandomCat component*/
export class RandomCatComponent {
    /** RandomCat ctor */
  constructor( private catService:CatService) {

  }
  
  DisplayCat: Cat[] =[];

  ngOnInit(): void {
    this.searchCats(1);
  }

  searchCats(count: number): void {
    this.catService.getRandomCat(count).subscribe((response: any) => {
      console.log(response);
      this.DisplayCat = response;
    });
  }

  submitForm(form: NgForm): void {
    console.log(form.form.value.count);
    this.searchCats(form.form.value.count);
  }
}
