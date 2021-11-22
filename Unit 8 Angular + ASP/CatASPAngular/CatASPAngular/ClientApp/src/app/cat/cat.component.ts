import { Component, Input, Output, EventEmitter } from '@angular/core';
import { Observable } from 'rxjs';
import { AuthorizeService } from '../../api-authorization/authorize.service';
import { Cat } from '../Cat';
import { UserService } from '../user.service';

@Component({
    selector: 'app-cat',
    templateUrl: './cat.component.html',
    styleUrls: ['./cat.component.css']
})
/** Cat component*/
export class CatComponent {
    /** Cat ctor */
  constructor(private authorizeService: AuthorizeService, private userService: UserService) {

  }

  @Input() cat: Cat = {} as Cat;
  @Output() removeFromFav = new EventEmitter<string>();
  public isAuthenticated: Observable<boolean>;

  ngOnInit(): void {
    this.isAuthenticated = this.authorizeService.isAuthenticated();
  }

  AddFavorite(): void {
    
    this.userService.addFav(this.cat.id).subscribe((response: any) => {
      console.log(response);
    });
  }

  DeleteFav(): void {
    this.userService.deleteFav(this.cat.id).subscribe((response: any) => {
      console.log(response);
    });
    this.removeFromFav.emit(this.cat.id);
  }
}
