// function with return type
function greet(): string{
    return "Hello World";
}

function caller(){
    var msg = greet();
    console.log(msg);
}

caller();

// function with parameters
// if data type is omitted, then it will be set to "any"
function test_param(n1:number,s1:string) { 
    console.log(n1);
    console.log(s1);
 } 
 test_param(123,"this is a string");

 // optional parameters
 function disp_details(id:number, name:string , mail_id? : string){
     console.log("ID ", id);
     console.log("Name", name);
     if(mail_id != undefined){
        console.log("Email Id",mail_id); 
     }
 }
 disp_details(123,"John");
 disp_details(111,"mary","mary@xyz.com");

// default parameters
function calculate_discount(price:number,rate:number = 0.50) { 
    var discount = price * rate; 
    console.log("Discount Amount: ",discount); 
 } 
 calculate_discount(1000);
 calculate_discount(1000,0.30);

 // rest parameters: 
 // don't restirct the number of values that you can pass to a function. 
 // NOTE: the values passed must all be of the same type.
 // HOW: the parmeter name is prefixed with threee periods.
 function addNumbers(...nums:number[]) {  
    var i;   
    var sum:number = 0; 
    
    for(i = 0;i<nums.length;i++) { 
       sum = sum + nums[i]; 
    } 
    console.log("sum of the numbers",sum);
 } 
 addNumbers(1,2,3);
 addNumbers(10,10,10,10,10);

 // anonymous function
 // It is dynamically declared at runtime
 // Variables can be assigned an anonymous function. Such an expressin is called a function expression.
var msg = function(){
    return "hello world";
};
console.log(msg());

var res = function(a:number,b:number) { 
    return a*b;  
 }; 
 console.log(res(12,2)); 

// NOTE
/*
The fundamental difference between the two is that, function declarations are parsed before their execution. On the other hand, function expressions are parsed only when the script engine encounters it during execution.

When the JavaScript parser sees a function in the main code flow, it assumes Function Declaration. When a function comes as a part of a statement, it is a Function Expression.
*/

// Function Constructor: built-in JavaScript contructor called Function()
var myFunction = new Function("a", "b", "return a * b");
var x = myFunction(4,3);
console.log(x);

// Recursion
function factorial(number){
    if(number <= 0){ // termination case
        return 1;
    }else{
        return (number * factorial(number -1));
    }
}

console.log(factorial(6));

// Anonymous recursive function
(function(){
    var x = "Hello";
    console.log(x);
})(); // the function invokes itself using a pair of parentheses();

// Lambda function
// Lambda refers to anonymous function in programming. Lambda functions are a concise mechanism to represent anonymous functions. 
// Three parts: parameters, => (goes to operator), statement

var foo = (x:number) => 10 + x;
console.log(foo(100));

var foo2 = (x:number) =>{
    x = x + 10;
    console.log(x);
}
foo2(100);

// Syntactic Variations
// It is not mandatory to specify the data type of a parameter. In such a case, the data type of the parameter is "any".
var func = (x) => {
    if(typeof x=="number") { 
        console.log(x+" is numeric") 
     } else if(typeof x=="string") { 
        console.log(x+" is a string") 
     }  
}
func(12);
func("Jini");

// optional parentheses for a single parameter and no parameter
var display = x=> { 
    console.log("The function got "+x);
 } 
 display(12);

 var disp =()=> { 
    console.log("Function invoked"); 
 } 
 disp();

 // Function Overload
 function disp5(s1:string):void; 
 function disp5(n1:number,s1:string):void; 
 
 function disp5(x:any,y?:any):void { 
    console.log(x); 
    console.log(y); 
 } 
 disp5("abc"); 
 disp5(1,"xyz");

