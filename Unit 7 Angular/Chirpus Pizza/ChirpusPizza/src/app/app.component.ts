import { Component } from '@angular/core';
import { MenuItem } from './menu-item';

@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  styleUrls: ['./app.component.css']
})
export class AppComponent {
  title = 'ChirpusPizza';
  Menu: MenuItem[] = [
    {
      name: "chicken Fingers",
      category: "dinner",
      price: 11.99
    },
    {
      name: "pizza",
      category: "dinner",
      price: 11.99
    },
    {
      name: "wings",
      category: "side",
      price: 8.99
    },
    {
      name: "breadsticks",
      category: "side",
      price: 4.99
    },
    {
      name: "ceasar salad",
      category: "salad",
      price: 5.99
    },
    {
      name: "cinnamon roll",
      category: "dessert",
      price: 8.99
    },
    {
      name: "burger",
      category:"dinner",
      price: 7.99
    }
  ];

  getItemsByCategory(cat:string):MenuItem[]{
    return this.Menu.filter((item:MenuItem) => item.category == cat);
  }

}
