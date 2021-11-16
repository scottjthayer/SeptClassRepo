import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';
import { HttpClientModule } from '@angular/common/http'
import { AppComponent } from './app.component';
import { ShowPostComponent } from './show-post/show-post.component';
import { RedditPostsComponent } from './reddit-posts/reddit-posts.component';

@NgModule({
  declarations: [
    AppComponent,
    ShowPostComponent,
    RedditPostsComponent
  ],
  imports: [
    BrowserModule,
    HttpClientModule,
  ],
  providers: [],
  bootstrap: [AppComponent]
})
export class AppModule { }
