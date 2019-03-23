/*
1. generate component and ngInit
2. Template Syntax
*/

import { Component, OnInit } from '@angular/core';
import { User } from '../../models/User'; // call interface (manually create)
@Component({
  selector: 'app-thirdExample',
  templateUrl: './thirdExample.component.html',
  styleUrls: ['./thirdExample.component.css']
})
export class ThirdExampleComponent implements OnInit {  
  users:User[];
  showExtended : boolean = false;
  loaded:boolean = true; // mimi data loading
  
  enabledAdd:boolean = true; // property binding
  currentClasses = {}; // empty object
  currentStyles = {};
  // normally it is used with Dependency Injection
  constructor() { }

  // normally it is used with service call or initialization
  ngOnInit() {

    //setTimeout(() => {
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
          image: 'https://imgplaceholder.com/600x600/cccccc/757575/glyphicon-picture',
		  isActive: true,
		  balance:100,
		  registered:new Date('01/02/2018 08:30:00')
        },
        {
          firstName : "Kevin",
          lastName : "Johnson"   ,
          image: 'https://imgplaceholder.com/600x600/cccccc/757575/glyphicon-picture'   ,
		  isActive: false   ,
		  balance:200,
		  registered:new Date('03/11/2017 08:30:00') 
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
		  balance:50,
		  registered:new Date('11/25/2017 10:30:00')
        }
      ]; 

      // test
      this.showExtended = true;
    //}, 2000 );

    this.addUser({
      firstName : "David",
        lastName : "Jackson",
        age: 12,
        address : {
          street: "345 Mill ave",
          city: "Montreal",
          state: "QC"
        },
        image: 'https://imgplaceholder.com/600x600/cccccc/757575/glyphicon-picture'
    });

	this.setCurrentClasses();
	this.setcurrentStyles();
  }

  addUser(user:User){
    this.users.push(user);
  }

  setCurrentClasses(){
    this.currentClasses = {
      'btn-success': this.enabledAdd,
      'big-text' : this.showExtended
    }
  }
  setcurrentStyles(){
	  this.currentStyles = {
		  'padding-top': this.showExtended ?'0':'40px',
		  'font-size': this.showExtended ? '': '40px' 
	  }
  }
}
