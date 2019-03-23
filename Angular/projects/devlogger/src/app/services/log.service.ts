import { Injectable } from '@angular/core';
import { Log } from '../models/log';
import { BehaviorSubject } from 'rxjs';
import { Observable, of } from  'rxjs';
import { ThrowStmt } from '@angular/compiler';

@Injectable({
  providedIn: 'root'
})
export class LogService {
  logs : Log[];
  private logSource = new BehaviorSubject<Log>({
    id:null, text:null, date:null
  });
  selectedLog = this.logSource.asObservable();

  private stateSouce = new BehaviorSubject<boolean>(true);
  stateClear = this.stateSouce.asObservable();

  constructor() { 
    // this.logs = [
    //   {id: '1', text: 'Generated components', date: new Date('12/26/2017 12:12:45')},
    //   {id: '2', text: 'Added bootstrap', date: new Date('12/22/2017 10:12:45')},
    //   {id: '3', text: 'Added logs component', date: new Date('12/21/2017 1:12:45')},
    // ]
    this.logs = [];
  }

  getLogs(): Observable<Log[]>{
    // local storage can be checked chrome developer tool (F12) > Application tab
    if(localStorage.getItem('logs') === null){
      this.logs = [];
    } else {
      this.logs = JSON.parse(localStorage.getItem('logs'));
    }

    return of(this.logs.sort((a,b) => {
      return b.date = a.date;
    }));
  }

  setFormLog(log: Log){
    this.logSource.next(log);
  }

  addLog(log: Log){
    this.logs.unshift(log);

    // local storage: only string
    // add to local storage
    localStorage.setItem('logs', JSON.stringify(this.logs));
  }

  updateLog(log:Log){
    this.logs.forEach((cur, index)=>{
      if(log.id === cur.id)
      {
        this.logs.splice(index, 1);
      }
    });
    this.logs.unshift(log);

    // update localStorage
    localStorage.setItem('logs', JSON.stringify(this.logs));
  }

  deleteLog(log:Log){
    this.logs.forEach((cur, index)=>{
      if(log.id === cur.id)
      {
        this.logs.splice(index, 1);
      }
    });

    // delete local storage
    localStorage.setItem('logs', JSON.stringify(this.logs));
  }

  clearState(){
    this.stateSouce.next(true);
  }
}
