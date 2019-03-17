/*
Interfaces are not to be converted to JavaScript. It’s just part of TypeScript. If you see the screen shot of TS Playground tool there is no java script emitted when you declare an interface unlike a class. So interfaces have zero runtime JavaScript impact.
*/

// only defintion
interface IPerson {
  firstName: string;
  lastName: string;
  sayHi: () => string; // lambda expression
}

// implementation and anonymous object
var customer: IPerson = {
  firstName: "Tom",
  lastName: "Hanks",
  sayHi: (): string => {
    return "Hi there";
  } // anonymous method
};

console.log("Customer Object ");
console.log(customer.firstName);
console.log(customer.lastName);
console.log(customer.sayHi());

// union type and interface
interface RunOptions {
  program: string;
  commandline: string[] | string | (() => string); // It could be property or method (That is Union Type)
}

//commandline as string
var options: RunOptions = {
  program: "test1",
  commandline: "Hello" // implement "Property" as "string"
};
console.log(options.commandline);

//commandline as a string array
options = {
  program: "test1",
  commandline: ["Hello", "World"] // implement "Property" as "string array"
};
console.log(options.commandline[0]);
console.log(options.commandline[1]);

//commandline as a function expression
options = {
  program: "test1",
  commandline: () => {
    return "**Hello World**";
  } // implement "Method"
};

var fn: any = options.commandline;
console.log(fn());

// interface and inheritance
interface Person {
  age: number;
}

// Note: inheritance keyword is "extends"
interface Musician extends Person {
  instrument: string;
}

var drummer: Musician = {
  age: 27,
  instrument: "Drums"
};

/*
Same expression 
var drummer = <Musician>{}; 
drummer.age = 27 
drummer.instrument = "Drums" 
*/

console.log("Age:  " + drummer.age);
console.log("Instrument:  " + drummer.instrument);

// multiple interface inheritance
interface IParent1 {
  v1: number;
}

interface IParent2 {
  v2: number;
}

interface Child2 extends IParent1, IParent2 {

}
var Iobj: Child2 = 
{ 
      v1: 12
    , v2: 23 
};

console.log("value 1: " + Iobj.v1 + " value 2: " + Iobj.v2);
