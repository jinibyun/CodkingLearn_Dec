type Message = { message: string };
export class Subject {
  private _observers: Observer[] = [];
  protected _state: Message = { message: '' };

  // Observer Registration
  add(observer: Observer) {
    this._observers = [...this._observers, observer];
    console.log('Subscription', observer);
    console.log('A list of subscribers', this._observers);
  }

  // Observer Deregistration
  remove(observer: Observer) {
    this._observers
      = this._observers.filter(o => o !== observer);
    console.log('Subscription Deregistration', observer);
    console.log('A list of subscribers', this._observers);
  }

  // Call all Observer'update method to broadcast messsage
  protected notify(state: Message) {
    this._observers.forEach(o => {
      console.log(`Data is being sent to ${o.constructor.name}`, state);
      o.update(state);
    });
  }
}

export class MySubject extends Subject {
  // Send out to message to registered Observer
  setMessage(message: string) {
    this._state.message = message;
    this.notify(this._state);
  }
}

export abstract class Observer {
  // Called by Subject to receive message
  abstract update(message: Message): void;
}

export class Observer1 extends Observer {
  update(message: Message) {
    console.log(`Data was sent out to ${this.constructor.name}`, message);
  }
}
export class Observer2 extends Observer {
  update(message: Message) {
    console.log(`Data was sent out to ${this.constructor.name}`, message);
  }
}
