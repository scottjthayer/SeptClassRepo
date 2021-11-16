import { Component, OnInit } from '@angular/core';
import { RedditAwwService } from '../reddit-aww.service';
import {Child, RedditSub} from '../reddit-sub';

@Component({
  selector: 'app-reddit-posts',
  templateUrl: './reddit-posts.component.html',
  styleUrls: ['./reddit-posts.component.css'],
  providers: [RedditAwwService]
})
export class RedditPostsComponent implements OnInit {

posts:Child[] = [];

  constructor(private redditService: RedditAwwService) { 
  }

  ngOnInit(): void {
    this.getPosts();
  }

  getPosts():void {
    this.redditService.getRedditSub().subscribe((result:RedditSub) => {
      console.log(result.data.children);
      this.posts = result.data.children;
    })
  }

}
