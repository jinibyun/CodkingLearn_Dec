var __extends = (this && this.__extends) || (function () {
    var extendStatics = function (d, b) {
        extendStatics = Object.setPrototypeOf ||
            ({ __proto__: [] } instanceof Array && function (d, b) { d.__proto__ = b; }) ||
            function (d, b) { for (var p in b) if (b.hasOwnProperty(p)) d[p] = b[p]; };
        return extendStatics(d, b);
    };
    return function (d, b) {
        extendStatics(d, b);
        function __() { this.constructor = d; }
        d.prototype = b === null ? Object.create(b) : (__.prototype = b.prototype, new __());
    };
})();
var Subject = /** @class */ (function () {
    function Subject() {
        this._observers = [];
        this._state = { message: '' };
    }
    // Observer(Subscriber) Registration
    Subject.prototype.add = function (observer) {
        this._observers = this._observers.concat([observer]);
        console.log('Subsriber Registration', observer);
        console.log('Current List of Subscribers', this._observers);
    };
    // Observer(Subscriber) Deregistration
    Subject.prototype.remove = function (observer) {
        this._observers
            = this._observers.filter(function (o) { return o !== observer; });
        console.log('Subscriber Deregistration', observer);
        console.log('Current List of Subscribers', this._observers);
    };
    // call all Observer's update method to send messages
    Subject.prototype.notify = function (state) {
        this._observers.forEach(function (o) {
            console.log("Data is received on " + o.constructor.toString(), state);
            o.update(state);
        });
    };
    return Subject;
}());
var MySubject = /** @class */ (function (_super) {
    __extends(MySubject, _super);
    function MySubject() {
        return _super !== null && _super.apply(this, arguments) || this;
    }
    // broadcasting data to all registered subscriber (observer)
    MySubject.prototype.setMessage = function (message) {
        this._state.message = message;
        this.notify(this._state);
    };
    return MySubject;
}(Subject));
var Observer = /** @class */ (function () {
    function Observer() {
    }
    return Observer;
}());
var Observer1 = /** @class */ (function (_super) {
    __extends(Observer1, _super);
    function Observer1() {
        return _super !== null && _super.apply(this, arguments) || this;
    }
    Observer1.prototype.update = function (message) {
        console.log("Data is received on " + this.constructor.toString(), message);
    };
    return Observer1;
}(Observer));
var Observer2 = /** @class */ (function (_super) {
    __extends(Observer2, _super);
    function Observer2() {
        return _super !== null && _super.apply(this, arguments) || this;
    }
    Observer2.prototype.update = function (message) {
        console.log("Data is received on " + this.constructor.toString(), message);
    };
    return Observer2;
}(Observer));
var subject = new MySubject();
console.log(subject);
var o1 = new Observer1();
var o2 = new Observer2();
// registration
subject.add(o1);
subject.add(o2);
// data will be sent out
subject.setMessage('This is a data');
// deregistration
subject.remove(o2);
// data will be sent out
subject.setMessage('The data will be sent out');
