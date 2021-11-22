import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';

@Injectable({
  providedIn: 'root'
})

export class CatService {
  constructor(private http: HttpClient) {

  }

  getRandomCat(count:number): any {
    return this.http.get(`https://api.thecatapi.com/v1/images/search?api_key=2977834c-d0fd-4c1d-a447-4cdb1cc5620c&limit=${count}`);
  }

  getCatById(Id: string): any {
    return this.http.get(`https://api.thecatapi.com/v1/images/${Id}?api_key=2977834c-d0fd-4c1d-a447-4cdb1cc5620c`);
  }
}
