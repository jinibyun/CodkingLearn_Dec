// tuple
// tuples enable storing multiple fields of different types
var mytuple = [10,"Hello"];
console.log(mytuple[0]);
console.log(mytuple[1]);

var mytuple2 = []; 
mytuple2[0] = "abcde";
mytuple2[1] = true;
console.log(mytuple2[0]); 
console.log(mytuple2[1]);

// tuple operation
var mytuple3 = [10,"Hello","World","typeScript"]; 
console.log("Items before push "+mytuple3.length);    // returns the tuple size 

mytuple3.push(12);                                    // append value to the tuple 
console.log("Items after push "+mytuple3.length); 
console.log("Items before pop "+mytuple3.length); 
console.log(mytuple3.pop()+" popped from the tuple"); // removes and returns the last item
  
console.log("Items after pop "+mytuple3.length);

// updating tuples
var mytuple4 = [10,"Hello","World","typeScript"]; //create a  tuple 
console.log("Tuple value at index 0 "+ mytuple4[0]);

//update a tuple element 
mytuple[0] = 1214     
console.log("Tuple value at index 0 changed to   "+mytuple[0]);