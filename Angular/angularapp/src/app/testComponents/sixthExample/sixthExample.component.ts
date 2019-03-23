import { Component, OnInit,ViewChild } from '@angular/core';
import { User3 } from '../../models/User'; // call interface (manually create)

@Component({
  selector: 'app-sixthExample',
  templateUrl: './sixthExample.component.html',
  styleUrls: ['./sixthExample.component.css']
})
export class SixthExampleComponent implements OnInit {
  user: User3 = {
    firstName : '',
    lastName : '',
    email: ''
  }

  users:User3[];
  showExtended : boolean = true;
  loaded:boolean = true; // mimi data loading
  
  enabledAdd:boolean = false; // property binding
  showUserForm: boolean = false;
  @ViewChild('userForm') form:any;

  constructor() { }

  ngOnInit() {
      this.users = [
        {
          firstName : "John",
          lastName : "Doe",
          email: 'John@gmail.com',
          isActive: true,
          registered:new Date('01/02/2018 08:30:00'),
          hide:true
        },
        {
          firstName : "Kevin",
          lastName : "Johnson"   ,  
          email: 'Kevin@gmail.com',        
		      isActive: true   ,
          registered:new Date('03/11/2017 08:30:00') ,
          hide:false
        },
        {
          firstName : "Caren",
          lastName : "Williams",
          email: 'Caren@gmail.com',
		      isActive:true,
          registered:new Date('11/25/2017 10:30:00'),
          hide:true
        }
      ]; 
  }

  // addUser(){
  //   // this.users.push(this.user);
  //   this.user.isActive = true;
  //   this.user.registered = new Date();
  //   this.users.unshift(this.user);
  //   this.user = {
  //     firstName : '',
  //     lastName : '',
  //     email: ''
  //   }
  // }  

  // toggleHide(user:User3){
  //   user.hide = !user.hide;
  // }
  onSubmit({value, valid}: {value:User3, valid:boolean}){
	  if(!valid){
      console.log('Forms is not vaild');

    }
    else{
      value.isActive = true;
      value.registered = new Date();
      value.hide = true;
      this.users.unshift(value);
      this.form.reset();
    }
  }

  fireEvent(e){
	  console.log(e.type);
	  console.log(e.target.value);
  }
}
