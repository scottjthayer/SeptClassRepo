import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';
import { HttpClientModule } from '@angular/common/http';
import { AppComponent } from './app.component';
import { HallOfFameComponent } from './hall-of-fame/hall-of-fame.component';
import { BlogComponent } from './blog/blog.component';

@NgModule({
  declarations: [
    AppComponent,
    HallOfFameComponent,
    BlogComponent
  ],
  imports: [
    BrowserModule,
    HttpClientModule
  ],
  providers: [],
  bootstrap: [AppComponent]
})
export class AppModule { }
