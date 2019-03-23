import { Component, OnInit } from '@angular/core';
import { User2 } from '../../models/User'; // call interface (manually create)

@Component({
  selector: 'app-fifthExample',
  templateUrl: './fifthExample.component.html',
  styleUrls: ['./fifthExample.component.css']
})
export class FifthExampleComponent implements OnInit {
  user: User2 = {
    firstName : '',
    lastName : '',
    age: null,
    address : {
      street : '',
      city: '',
      state: ''
    }
  }

  users:User2[];
  showExtended : boolean = true;
  loaded:boolean = true; // mimi data loading
  
  enabledAdd:boolean = false; // property binding
  showUserForm: boolean = false;
  constructor() { }

  ngOnInit() {
      this.users = [
        {
          firstName : "John",
          lastName : "Doe",
          age: 30,
          address : {
            street: "120 King St",
            city: "Toronto",
            state: "ON"
          },
          isActive: true,
          registered:new Date('01/02/2018 08:30:00'),
          hide:true
        },
        {
          firstName : "Kevin",
          lastName : "Johnson"   ,          
		      isActive: true   ,
          registered:new Date('03/11/2017 08:30:00') ,
          hide:false
        },
        {
          firstName : "Caren",
          lastName : "Williams",
          age: 26,
          address : {
            street: "123 yonge ave",
            city: "Manitoba",
            state: "MB"
          },
		      isActive:true,
          registered:new Date('11/25/2017 10:30:00'),
          hide:true
        }
      ]; 
  }

  addUser(){
    // this.users.push(this.user);
    this.user.isActive = true;
    this.user.registered = new Date();
    this.users.unshift(this.user);
    this.user = {
      firstName : '',
      lastName : '',
      age: null,
      address : {
        street : '',
        city: '',
        state: ''
      }
    }
  }  

  // toggleHide(user:User2){
  //   user.hide = !user.hide;
  // }
  onSubmit(e){
	  console.log(123);
	  e.preventDefault();
  }

  fireEvent(e){
	  console.log(e.type);
	  console.log(e.target.value);
  }
}
