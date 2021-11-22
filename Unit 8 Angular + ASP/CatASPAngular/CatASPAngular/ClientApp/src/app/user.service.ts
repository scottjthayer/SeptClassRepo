import { HttpClient } from '@angular/common/http';
import { Inject, Injectable } from '@angular/core';

@Injectable({
  providedIn: 'root'
})

export class UserService {
  constructor(private http: HttpClient, @Inject('BASE_URL') private baseUrl: string) {

  }

  addFav(catId:string):any {
    return this.http.post(this.baseUrl + `api/Fav/NewFav?_CatId=${catId}`, {});
  }

  getFavs(): any {
    return this.http.get(this.baseUrl + `api/Fav/GetFavs`);
  }

  deleteFav(id: string): any {
    return this.http.delete(this.baseUrl + `api/Fav/DeleteFav?id=${id}`);
  }
}
