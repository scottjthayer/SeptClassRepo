import { Component } from '@angular/core';
import { Cat } from '../Cat';
import { CatService } from '../cat.service';
import { Fav } from '../Fav';
import { UserService } from '../user.service';

@Component({
    selector: 'app-favorites',
    templateUrl: './favorites.component.html',
    styleUrls: ['./favorites.component.css']
})
/** Favorites component*/
export class FavoritesComponent {
    /** Favorites ctor */
  constructor(private catService: CatService, private userService: UserService) {

  }
  resultCats: Cat[] = [];
  ngOnInit(): void {
    this.userService.getFavs().subscribe((response: any) => {
      console.log(response);
      let MyFavs: Fav[] = response;
      MyFavs.forEach((F: Fav) => {
        this.catService.getCatById(F.catId).subscribe((catResponse: any) => {
          let result: Cat = catResponse;
          this.resultCats.push(result);
        });
      })
    });
  }

  removeFromFav(id: string) {
    let index:number = this.resultCats.findIndex((C: Cat) => C.id == id);
    this.resultCats.splice(index,1);
  }
}
