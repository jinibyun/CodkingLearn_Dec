import { Component, OnInit } from '@angular/core';
import { MySubject, Observer1, Observer2 } from 'src/app/code/publisher_subscriber';
import { Observable } from 'rxjs';

@Component({
  selector: 'app-rx-js-example',
  templateUrl: './rx-js-example.component.html',
  styleUrls: ['./rx-js-example.component.css']
})
export class RxJsExampleComponent implements OnInit {

  constructor() { }

  subject = new MySubject();
  o1 = new Observer1();
  o2 = new Observer2();

  ngOnInit() {
    // 1. no rxJs yet. simple publishing and subscription model
    this.showPublishingSubscription();

    // 2. with rxJs
    this.showRxJs();
  }

  showPublishingSubscription() {
    console.log('========== rx-js-example (no rxJs yet) start =========== ');
    console.log(this.subject);

    // subscription
    this.subject.add(this.o1);
    this.subject.add(this.o2);

    // data broadcasting
    this.subject.setMessage('👋');

    // unsubscription of second subscriber
    this.subject.remove(this.o2);

    // data broadcasting
    this.subject.setMessage('😀');
    console.log('========== rx-js-example end =========== ');
  }

  showRxJs() {
    // When "Obserbable" is subscribed, following "call-back" function is called.
    const subscriber = (observer) => {
      try {
        // next : emit notification
        observer.next(1);
        observer.next(2);

        // throw new Error('Something wrong!');

        // complete : a : Number = 23;
        observer.complete();
      } catch (e) {
        // error : a : Number = 23;
        observer.error(e);
      } finally {
        // on deregistraiton, following method is called
        return () => console.log('Unsubscribed!')
      }
    }

    // Create Observable
    const observable = new Observable(subscriber);

    // When subscribed, then subscriber method (call-back function) is executed

    observable.subscribe(
      value => {
        console.log('========== rx-js-example (with rxJs) start =========== ');
        console.log(value);
      },
      error => console.error(error),
      () => {
        console.log('Complete');
        console.log('========== rx-js-example (with rxJs) end =========== ');
      }
    );

  }
}


