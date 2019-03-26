import { Component, OnInit, OnDestroy } from '@angular/core';
import { Observable, Subscription, from } from 'rxjs';
import { map, filter, tap } from 'rxjs/operators';

@Component({
  selector: 'app-rx-js-example3',
  templateUrl: './rx-js-example3.component.html',
  styleUrls: ['./rx-js-example3.component.css']
})
export class RxJsExample3Component implements OnInit, OnDestroy {

  constructor() { }

  myArray = [1, 2, 3, 4, 5];
  subscription: Subscription;
  values: number[] = [];

  ngOnInit() {
    // "from" operator create obserbable from iterable data such as array
    const observable = from(this.myArray);

    this.subscription = observable
    // transforming and filtering
      .pipe(
        // observable data conversion by pipe and follwoing method
        map(item => item * 2), // 2, 4, 6, 8, 10
        filter(item => item > 5), // 6, 8, 10
        tap(item => console.log(item)) // 6, 8, 10
      )
      // subscription
      .subscribe(
        // next
        value => this.values.push(value),
        // error
        error => console.log(error),
        // complete
        () => console.log('Streaming finished')
      );
  }

  // save memory
  ngOnDestroy() {
    this.subscription.unsubscribe();
  }
}
