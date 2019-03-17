/*
Interfaces are not to be converted to JavaScript. It’s just part of TypeScript. If you see the screen shot of TS Playground tool there is no java script emitted when you declare an interface unlike a class. So interfaces have zero runtime JavaScript impact.
*/
// implementation and anonymous object
var customer = {
    firstName: "Tom",
    lastName: "Hanks",
    sayHi: function () {
        return "Hi there";
    } // anonymous method
};
console.log("Customer Object ");
console.log(customer.firstName);
console.log(customer.lastName);
console.log(customer.sayHi());
//commandline as string
var options = {
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
    commandline: function () {
        return "**Hello World**";
    } // implement "Method"
};
var fn = options.commandline;
console.log(fn());
var drummer = {
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
var Iobj = {
    v1: 12,
    v2: 23
};
console.log("value 1: " + Iobj.v1 + " value 2: " + Iobj.v2);
//# sourceMappingURL=tu_08_interface.js.map