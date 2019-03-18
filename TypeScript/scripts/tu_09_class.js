// Class
var __extends = (this && this.__extends) || (function () {
    var extendStatics = function (d, b) {
        extendStatics = Object.setPrototypeOf ||
            ({ __proto__: [] } instanceof Array && function (d, b) { d.__proto__ = b; }) ||
            function (d, b) { for (var p in b) if (b.hasOwnProperty(p)) d[p] = b[p]; };
        return extendStatics(d, b);
    }
    return function (d, b) {
        extendStatics(d, b);
        function __() { this.constructor = d; }
        d.prototype = b === null ? Object.create(b) : (__.prototype = b.prototype, new __());
    };
})();
// see how it is transpiled into javascript
var Person = /** @class */ (function () {
    function Person() {
    }
    return Person;
}());
// NOTE: Do not put "public" access modifier
var Car = /** @class */ (function () {
    // constructor // NOTE: use "constructor" keyword
    function Car(engine) {
        this.engine = engine; // "this" keyword refers to the current instance of the class
    }
    //function
    Car.prototype.disp = function () {
        console.log("Engine is  :   " + this.engine);
    };
    return Car;
}());
// create "object (instance)" using "class"
var objCar = new Car("Hyundai");
console.log("Reading attribute value Engine as :  " + objCar.engine);
objCar.disp();
// Class Inheritance
var Shape = /** @class */ (function () {
    function Shape(a) {
        this.Area = a;
    }
    return Shape;
}());
var Circle = /** @class */ (function (_super) {
    __extends(Circle, _super);
    function Circle() {
        return _super !== null && _super.apply(this, arguments) || this;
    }
    Circle.prototype.disp = function () {
        console.log("Area of the circle:  " + this.Area);
    };
    return Circle;
}(Shape));
var objCircle = new Circle(223);
objCircle.disp();
var Root = /** @class */ (function () {
    function Root() {
    }
    return Root;
}());
var Child = /** @class */ (function (_super) {
    __extends(Child, _super);
    function Child() {
        return _super !== null && _super.apply(this, arguments) || this;
    }
    return Child;
}(Root));
var Leaf = /** @class */ (function (_super) {
    __extends(Leaf, _super);
    function Leaf() {
        return _super !== null && _super.apply(this, arguments) || this;
    }
    return Leaf;
}(Child)); //indirectly inherits from Root by virtue of inheritance
var objLeaf = new Leaf();
objLeaf.str = "hello";
console.log(objLeaf.str);
// Class inheritance and method overriding
var PrinterClass = /** @class */ (function () {
    function PrinterClass() {
    }
    PrinterClass.prototype.doPrint = function () {
        console.log("doPrint() from Parent called…");
    };
    return PrinterClass;
}());
var StringPrinter = /** @class */ (function (_super) {
    __extends(StringPrinter, _super);
    function StringPrinter() {
        return _super !== null && _super.apply(this, arguments) || this;
    }
    StringPrinter.prototype.doPrint = function () {
        _super.prototype.doPrint.call(this);
        console.log("doPrint() is printing a string…");
    };
    return StringPrinter;
}(PrinterClass));
var objStringPrinter = new StringPrinter();
objStringPrinter.doPrint();
// static keyword
var StaticMem = /** @class */ (function () {
    function StaticMem() {
    }
    StaticMem.disp = function () {
        console.log("The value of num is" + StaticMem.num);
    };
    return StaticMem;
}());
StaticMem.num = 12; // initialize the static variable
StaticMem.disp(); // invoke the static method
// instancof operator
var Person2 = /** @class */ (function () {
    function Person2() {
    }
    return Person2;
}());
var objPerson2 = new Person2();
var isPerson = objPerson2 instanceof Person2;
console.log(" obj is an instance of Person " + isPerson);
var AgriLoan = /** @class */ (function () {
    function AgriLoan(interest, rebate) {
        this.interest = interest;
        this.rebate = rebate;
    }
    return AgriLoan;
}());
var objLoan = new AgriLoan(10, 1);
console.log("Interest is : " + objLoan.interest + " Rebate is : " + objLoan.rebate);
// COMPARE above
//  var objLoan : ILoan = new AgriLoan(10,1); 
//  console.log("Interest is : " + objLoan.interest + " Rebate is : "+ objLoan.rebate ); // compile error
// object leteral (similar to object from new keyword)
// An object is an instance which contains set of key value pairs. The values can be // scalar values or functions or even array of other objects. The syntax is given below −
// ref: https://stackoverflow.com/questions/4597926/what-is-the-difference-between-new-object-and-object-literal-notationfu
// ref: https://www.phpied.com/3-ways-to-define-a-javascript-class/
// syntax
// var object_name = { 
//     key1: “value1”, //scalar value 
//     key2: “value”,  
//     key3: function() {
//        //functions 
//     }, 
//     key4:[“content1”, “content2”] //collection  
//  };
var teacher = {
    firstname: "Jini",
    lastname: "Byun"
};
//access the object values 
console.log(teacher.firstname);
console.log(teacher.lastname);
// teacher.sayHello = function(){ return "hello";} // compile error (not compile error in javascript)
// to resolve issue above
var student = {
    firstName: "Tom",
    lastName: "Hanks",
    sayHello: function () { } //Type template 
};
student.sayHello = function () {
    console.log("hello " + student.firstName);
};
student.sayHello();
// object as function parameters
var professor = {
    firstname: "Tom",
    lastname: "Hanks"
};
var invokeperson = function (obj) {
    console.log("first name :" + obj.firstname);
    console.log("last name :" + obj.lastname);
};
invokeperson(professor);
// anonymous object
var invokeperson2 = function (obj) {
    console.log("first name :" + obj.firstname);
    console.log("last name :" + obj.lastname);
};
invokeperson2({ firstname: "Sachin", lastname: "Tendulkar" });
function addPoints(p1, p2) {
    var x = p1.x + p2.x;
    var y = p1.y + p2.y;
    return { x: x, y: y };
}
//Valid 
var newPoint = addPoints({ x: 3, y: 4 }, { x: 5, y: 1 });
//Error 
// var newPoint2 = addPoints({x:1},{x:4,y:3}); // compile error
//# sourceMappingURL=tu_09_class.js.map