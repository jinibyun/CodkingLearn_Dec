// Two or more data types are combined using the pipe symbol (|) to denote a Union Type

// NOTE: confirm how it is changed to javascript

var val:string|number; 
val = 12; 
console.log("numeric value of val "+val);
val = "This is a string"; 
console.log("string value of val "+val);

// union type and function parameter
function disp7(name:string|string[]) { 
    if(typeof name == "string") { 
       console.log(name); 
    } else { 
       // var i;        
       for(var i = 0;i<name.length;i++) { 
          console.log(name[i]);
       } 
    } 
 } 
 disp7("mark"); 
 console.log("Printing names array....") ;
 disp7(["Mark","Tom","Mary","John"]);

 // union type and arrays
var arr7:number[]|string[]; 
var i:number; 
arr7 = [1,2,4]; 
console.log("**numeric array**");

for(i = 0;i<arr7.length;i++) { 
   console.log(arr7[i]); 
}  

arr7 = ["Mumbai","Pune","Delhi"]; 
console.log("**string array**");  

for(i = 0;i<arr7.length;i++) { 
   console.log(arr7[i]); 
} 