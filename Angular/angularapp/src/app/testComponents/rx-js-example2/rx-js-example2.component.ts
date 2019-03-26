import { Component, OnInit } from '@angular/core';
import { Observable, fromEvent } from 'rxjs';

@Component({
  selector: 'app-rx-js-example2',
  templateUrl: './rx-js-example2.component.html',
  styleUrls: ['./rx-js-example2.component.css']
})
export class RxJsExample2Component implements OnInit {

  constructor() { }
  mousePositon: Observable<Event>;
  posX = 0;
  posY = 0;

  ngOnInit() {
    // create observable
    // chnage mousemove event to obserable
    // "Any kind of data (in this case event) can be changed to obserable"
    // fromEvent : change event to event stream data and put it in notification.
    // Then it emits only when "subscrition" happens
    this.mousePositon = fromEvent(document, 'mousemove');

    // subscription
    this.mousePositon.subscribe(
      (event: MouseEvent) => {
        this.posX = event.clientX;
        this.posY = event.clientY;
      },
      error => console.log(error),
      () => console.log('complete!')
    );
  }

}
