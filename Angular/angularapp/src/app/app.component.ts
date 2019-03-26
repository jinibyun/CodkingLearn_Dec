import { Component } from '@angular/core';

@Component({
  selector: 'app-root',
  // testing without router
  templateUrl: './app.component.html',

  // testing with router
  // templateUrl: './app.for_router_component.html',
  styleUrls: ['./app.component.css']
})
export class AppComponent {
  title = 'angularapp';
}
