import { Component, OnInit, ViewChild } from '@angular/core';
import { User3 } from '../../models/User'; // call interface 
import { DataService } from '../../services/data.service';
@Component({
  selector: 'app-seventhExample',
  templateUrl: './seventhExample.component.html',
  styleUrls: ['./seventhExample.component.css']
})
export class SeventhExampleComponent implements OnInit {
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
  data:any;
  // dependency injection
  constructor(private dataService:DataService) { 

  }

  ngOnInit() {
    this.dataService.getData().subscribe(data => {
      console.log(data);
    });
    this.dataService.getUsers().subscribe(users => {
      this.users = users;
      this.loaded = true;
    }
      );
}

onSubmit({value, valid}: {value:User3, valid:boolean}){
  if(!valid){
    console.log('Forms is not vaild');

  }
  else{
    value.isActive = true;
    value.registered = new Date();
    value.hide = true;

    this.dataService.addUser(value);
    this.form.reset();
  }
}

}
