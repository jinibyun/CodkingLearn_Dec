type Message = { message: string };

class Subject {
  private _observers: Observer[] = [];
  protected _state: Message = { message: '' };

  // Observer(Subscriber) Registration
  add(observer: Observer) {
    this._observers = [...this._observers, observer];
    console.log('Subsriber Registration', observer);
    console.log('Current List of Subscribers', this._observers);
  }

  // Observer(Subscriber) Deregistration
  remove(observer: Observer) {
    this._observers 
      = this._observers.filter(o => o !== observer);
    console.log('Subscriber Deregistration', observer);
    console.log('Current List of Subscribers', this._observers);
  }

  // call all Observer's update method to send messages
  protected notify(state: Message) {
    this._observers.forEach(o => {
      console.log(`Data is received on ${o.constructor.toString()}`, state);
      o.update(state);
    });
  }
}

class MySubject extends Subject {
  // broadcasting data to all registered subscriber (observer)
  setMessage(message: string) {
    this._state.message = message;
    this.notify(this._state);
  }
}

abstract class Observer {
  // receive message
  abstract update(message: Message): void;
}

class Observer1 extends Observer { 

  update(message: Message) {
    console.log(`Data is received on ${this.constructor.toString() }`, message);
  }
}
class Observer2 extends Observer {
  update(message: Message) {
    console.log(`Data is received on ${this.constructor.toString()}`, message);
  }
}

const subject = new MySubject();
console.log(subject);
const o1 = new Observer1();
const o2 = new Observer2();

// registration
subject.add(o1);
subject.add(o2);

// data will be sent out
subject.setMessage('This is a data');

// deregistration
subject.remove(o2);

// data will be sent out
subject.setMessage('The data will be sent out');
