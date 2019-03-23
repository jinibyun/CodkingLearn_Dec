import { Injectable } from '@angular/core';
import { User3 } from '../models/User';

// Observable
import { Observable, of } from 'rxjs';

@Injectable({
  providedIn: 'root'
})
export class DataService {

users: User3[];
data: Observable<any>;
constructor() { 

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

  getUsers(): Observable<User3[]> {
    return of(this.users);
  }
    
  addUser(user:User3){
    this.users.unshift(user);
  }

  getData(){
    this.data = new Observable(observer => {
      setTimeout(() => {
        observer.next(1);
      }, 1000);

      setTimeout(() => {
        observer.next(2);
      }, 2000);

      setTimeout(() => {
        observer.next(3);
      }, 3000);

      setTimeout(() => {
        observer.next({name: 'jini'});
      }, 4000);
      
    });

    return this.data;
  }

  
}
