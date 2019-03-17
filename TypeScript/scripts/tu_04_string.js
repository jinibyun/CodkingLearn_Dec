// constructor
var str5 = new String("This is string");
console.log("str.constructor is:" + str5.constructor);
console.log("Length: " + str5.length);
// The prototype property allows you to add properties and methods to an object.
function employee2(id, name) {
    this.id = id;
    this.name = name;
}
var emp = new employee2(123, "Smith");
employee2.prototype.email = "smith@abc.com";
console.log("Employee 's Id: " + emp.id);
console.log("Employee's name: " + emp.name);
console.log("Employee's Email ID: " + emp.email);
// String method
// charAt(), charCodeAt(), concat(), indexOf(), lastIndexOf(), localeCompare(), match(), replace(), search(), slice(), split(), substr()....
//# sourceMappingURL=tu_04_string.js.map