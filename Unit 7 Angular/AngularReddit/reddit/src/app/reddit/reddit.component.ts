import { Component, OnInit } from '@angular/core';
import { NgForm } from '@angular/forms';
import { Post } from '../post';
import { RedditService } from '../reddit.service';

@Component({
  selector: 'app-reddit',
  templateUrl: './reddit.component.html',
  styleUrls: ['./reddit.component.css']
})
export class RedditComponent implements OnInit {

  postList:Post[] = [];

  constructor(private apiService: RedditService) { }

  ngOnInit(): void {
    this.getRedditInfo("aww");
  }

  SearchReddit(form:NgForm){
    let searchResult:string = form.form.value.SubReddit;
    this.getRedditInfo(searchResult);
  }

  getRedditInfo(subreddit:string):void{
    this.postList = [];

    this.apiService.getReddit(subreddit).subscribe(
      (response:any)=> {
        console.log(response);
        response.data.children.forEach((element:any) => {
          let newPost:Post = {
            title: element.data.title,
            url: "https://reddit.com" + element.data.permalink,
            img: element.data.thumbnail
          };
          this.postList.push(newPost);
        });
        this.postList.splice(10);
        console.log(this.postList);

      }
    );
  }

}
