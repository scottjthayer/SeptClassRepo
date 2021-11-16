import { Component, OnInit } from '@angular/core';
import { BlogService } from '../blog.service';
import { BlogResult, Child, Kind, Post } from '../post';

@Component({
  selector: 'app-blog',
  templateUrl: './blog.component.html',
  styleUrls: ['./blog.component.css']
})
export class BlogComponent implements OnInit {
  // title: string = "";
  // language: string = "";
  // posts:Post[] = [];
  result: BlogResult = {
    title :"",
    language: "",
    posts: []
  };

  post:Child= {} as Child;


  constructor(private blogservice:BlogService) { }

  ngOnInit(): void {
    this.blogservice.getBlogPosts().subscribe((response:any) => {
      console.log(response);
      // this.title = response.title;
      // this.language = response.language;
      // this.posts = response.posts;
      this.result = response;
    });

  }

}
