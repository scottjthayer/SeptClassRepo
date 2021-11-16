import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Observable } from 'rxjs';
import { RedditSub } from './reddit-sub';


@Injectable({
  providedIn: 'root'
})
export class RedditAwwService {

  apiURL: string = "https://www.reddit.com/r/aww/.json";
  constructor( private http: HttpClient) {}
  
  getRedditSub():Observable<RedditSub> {
    return this.http.get<RedditSub>(this.apiURL);
  }
}
