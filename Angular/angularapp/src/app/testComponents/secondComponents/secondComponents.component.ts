/*
Explanation:
	1. define object in interface
*/

import { Component } from '@angular/core';
import { User } from '../../models/User'; // call interface (manually create)

@Component({
  selector: 'app-second',
  templateUrl: './secondComponents.component.html',
  styleUrls: ['./secondComponents.component.css']
})
export class SecondComponentsComponent {

  // property as object
  user: User;

  constructor() { 
    this.user = {
      firstName : "John",
      lastName : "Doe",
      age: 30,
      address : {
        street: "120 King St",
        city: "Toronto",
        state: "ON"
      }
    }
  }
}
