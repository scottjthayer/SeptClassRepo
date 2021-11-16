import { Component, OnInit, Input } from '@angular/core';
import { Post } from '../post';

@Component({
  selector: 'app-post',
  templateUrl: './post.component.html',
  styleUrls: ['./post.component.css']
})
export class PostComponent implements OnInit {

  @Input() PostInfo:Post = {
    title: "",
    img: "",
    url: ""
  }

  constructor() { }

  ngOnInit(): void {
  }

}
