// Class

// see how it is transpiled into javascript
class Person {}

// NOTE: Do not put "public" access modifier
class Car {
  // NOTE: The var keyword is not used while declaring a field

  // NOTE: by default, it set to "Public"
  // field
  engine: string;

  // constructor // NOTE: use "constructor" keyword
  constructor(engine: string) {
    this.engine = engine; // "this" keyword refers to the current instance of the class
  }

  //function
  disp(): void {
    console.log("Engine is  :   " + this.engine);
  }
}

// create "object (instance)" using "class"
var objCar = new Car("Hyundai");
console.log("Reading attribute value Engine as :  " + objCar.engine);
objCar.disp();

// Class Inheritance
class Shape {
  Area: number;

  constructor(a: number) {
    this.Area = a;
  }
}

class Circle extends Shape {
  disp(): void {
    console.log("Area of the circle:  " + this.Area);
  }
}
var objCircle = new Circle(223);
objCircle.disp();

class Root {
  str: string;
}

class Child extends Root {}
class Leaf extends Child {} //indirectly inherits from Root by virtue of inheritance

var objLeaf = new Leaf();
objLeaf.str = "hello";
console.log(objLeaf.str);

// Class inheritance and method overriding
class PrinterClass {
  doPrint(): void {
    console.log("doPrint() from Parent called…");
  }
}

class StringPrinter extends PrinterClass {
  doPrint(): void {
    super.doPrint();
    console.log("doPrint() is printing a string…");
  }
}

var objStringPrinter = new StringPrinter();
objStringPrinter.doPrint();

// static keyword
class StaticMem {
  static num: number;

  static disp(): void {
    console.log("The value of num is" + StaticMem.num);
  }
}

StaticMem.num = 12; // initialize the static variable
StaticMem.disp(); // invoke the static method

// instancof operator
class Person2 {}
var objPerson2 = new Person2();
var isPerson = objPerson2 instanceof Person2;
console.log(" obj is an instance of Person " + isPerson);

// Access Modifier

// Class and interfaces
interface ILoan { 
    interest:number; 
 } 
 
 class AgriLoan implements ILoan { 
    interest:number ;
    rebate:number ;
    
    constructor(interest:number,rebate:number) { 
       this.interest = interest; 
       this.rebate = rebate; 
    } 
 } 
 
 var objLoan = new AgriLoan(10,1); 
 console.log("Interest is : " + objLoan.interest + " Rebate is : "+ objLoan.rebate );
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
    firstname:"Jini", 
    lastname:"Byun" 
 }; 
 //access the object values 
 console.log(teacher.firstname);
 console.log(teacher.lastname);
 // teacher.sayHello = function(){ return "hello";} // compile error (not compile error in javascript)

 // to resolve issue above
 var student = {
    firstName:"Tom", 
    lastName:"Hanks", 
    sayHello:function() {  }  //Type template 
 } 
 student.sayHello = function() {  
    console.log("hello "+ student.firstName);
 }  
 student.sayHello();

 // object as function parameters
 var professor = { 
    firstname:"Tom", 
    lastname:"Hanks" 
 }; 
 var invokeperson = function(obj: { firstname:string, lastname :string }) { 
    console.log("first name :"+obj.firstname) 
    console.log("last name :"+obj.lastname) 
 } 
 invokeperson(professor);

 // anonymous object
 var invokeperson2 = function(obj:{ firstname:string, lastname :string}) { 
    console.log("first name :"+obj.firstname) 
    console.log("last name :"+obj.lastname) 
 } 
 invokeperson2({firstname:"Sachin",lastname:"Tendulkar"});

 // Duck-typing -->> infer
 // The following example shows how we can pass objects that don’t explicitly implement an interface but contain all of the required members to a function.

 interface IPoint { 
    x:number; 
    y:number;
 } 
 function addPoints(p1:IPoint,p2:IPoint):IPoint { 
    var x = p1.x + p2.x ;
    var y = p1.y + p2.y ;
    return {x:x,y:y} 
 } 
 
 //Valid 
 var newPoint = addPoints({x:3,y:4},{x:5,y:1})  ;
 
 //Error 
 // var newPoint2 = addPoints({x:1},{x:4,y:3}); // compile error