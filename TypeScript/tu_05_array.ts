// array

// var array_name : datatype[];        //declaration 
// array_name = [val1,val2,valn..]   //initialization
// e.g var numlist:number[] = [2,4,6,8];

var alphas:string[]; 
alphas = ["1","2","3","4"] 
console.log(alphas[0]); 
console.log(alphas[1]);

var nums:number[] = [1,2,3,3] 
console.log(nums[0]); 
console.log(nums[1]); 
console.log(nums[2]); 
console.log(nums[3]);

// Array Object
// An array can also be created using the Array object. The Array constructor can be passed.
console.log("Array Object");
var arr_names:number[] = new Array(4)  

for(var i = 0; i< arr_names.length;i++) { 
   arr_names[i] = i * 2 
   console.log(arr_names[i]) 
}

var names:string[] = new Array("Mary","Tom","Jack","Jill") 

for(var i = 0;i<names.length;i++) { 
   console.log(names[i]) 
}

// array traverse
var j:any; 
var nums:number[] = [1001,1002,1003,1004] 

for(j in nums) { 
   console.log(nums[j]) 
} 

// Array object method

// Two-Dimensional Array
var multi:number[][] = [[1,2,3],[23,24,25]];  
console.log(multi[0][0]); 
console.log(multi[0][1]) ;
console.log(multi[0][2]) ;
console.log(multi[1][0]) ;
console.log(multi[1][1]) ;
console.log(multi[1][2]);

// passing array to function
var names:string[] = new Array("Mary","Tom","Jack","Jill");  

function disp2(arr_names:string[]) {
   for(var i = 0;i<arr_names.length;i++) { 
      console.log(names[i]); 
   }  
}  
disp2(names);

// return array from function
function disp3():string[] { 
    return new Array("Jack", "Queen", "King");
 } 
  
 var nums3:string[] = disp3();
 for(var i2 in nums3) { 
    console.log(nums3[i2]); 
 }