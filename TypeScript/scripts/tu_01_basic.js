// basic
var message = "Hello World";
console.log(message);
// class
var Greeting = /** @class */ (function () {
    function Greeting() {
    }
    Greeting.prototype.greet = function () {
        console.log("This is test");
    };
    return Greeting;
}());
var obj = new Greeting();
obj.greet();
// type:
// 1. "any" data type is the supoer type of all types in TypeSecript. It denotes a dynamic type.
// 2. Built-in types
/*
    > number: Double precision 64-bit floating point values. It can be used to represent both, integers and fractions. (NOTE: no integer type)
    > string
    > boolean
    > void
    > null
    > undefined
*/
// variable
// The type syntax for declaring a variable in TypeScript is to include a colon(:) after the variable name, followed by its type. If it is omitted, then its type will be set to any
var name2 = "John";
var score1 = 50;
var score2 = 42.50;
var sum = score1 + score2;
console.log("name" + name2);
console.log("first score: " + score1);
console.log("second score: " + score2);
console.log("sum of the scores: " + sum);
// type assertion
var str = '1';
var str2 = str; //str is now of type number 
console.log(str2);
// inferred typing: build error
// var num = 2;    // data type inferred as  number 
// console.log("value of num "+num); 
// num = "12";
// console.log(num);
// variable scope
var global_num = 12; //global variable 
var Numbers = /** @class */ (function () {
    function Numbers() {
        this.num_val = 13; //class variable 
    }
    Numbers.prototype.storeNum = function () {
        var local_num = 14; //local variable 
    };
    Numbers.sval = 10; //static field 
    return Numbers;
}());
console.log("Global num: " + global_num);
console.log(Numbers.sval); //static variable  
var obj2 = new Numbers();
console.log("Global num: " + obj2.num_val);
//# sourceMappingURL=tu_01_basic.js.map