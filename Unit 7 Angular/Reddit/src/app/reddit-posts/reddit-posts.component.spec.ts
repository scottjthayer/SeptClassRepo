import { ComponentFixture, TestBed } from '@angular/core/testing';

import { RedditPostsComponent } from './reddit-posts.component';

describe('RedditPostsComponent', () => {
  let component: RedditPostsComponent;
  let fixture: ComponentFixture<RedditPostsComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ RedditPostsComponent ]
    })
    .compileComponents();
  });

  beforeEach(() => {
    fixture = TestBed.createComponent(RedditPostsComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
