import { Component, Input, OnInit } from '@angular/core';
import { Child } from '../reddit-sub';

@Component({
  selector: 'app-show-post',
  templateUrl: './show-post.component.html',
  styleUrls: ['./show-post.component.css']
})
export class ShowPostComponent implements OnInit {

  @Input() postInfo:Child = {} as Child;

  constructor() { }

  ngOnInit(): void {
  }

}
