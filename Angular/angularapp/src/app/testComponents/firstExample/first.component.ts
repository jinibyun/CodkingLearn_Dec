/*
Explanation:
    0. Environment Setup
    1. Angular File Structure (Module, Service and Component)
    2. Component
    3. TypeScript Data Type and basic structure overview
*/

import { Component } from '@angular/core';

@Component({
    selector: 'app-first',
    templateUrl: './first.component.html',
    styleUrls: ['./first.component.css']
})
export class FirstComponent{
    
    // property
    // no type definition: it defauls to any
    firstName = "John"; // type infer
    lastName:string ="Doe";
    age = 30; // similar to age:number
    status; // any type
    hasKids;// any type    
    numberArray : number[]; // array
    stringArray : string[];
    mixedArray: any[];
    myTuple: [string, number, boolean];
    unusable : void;
    u:undefined;
    n:null;

    address = {
        street: '50 main st',
        city: 'Toronto'
    };
    
    // method
    // NOTE: contrctor is normally used for dependency injection. 
    // contructor called before output
    constructor(){
        // this.sayHello();
        console.log(this.age);
        this.hasBirthday();
        console.log(this.age);

        // error
        // this.firstName = 4;

        this.status = "Permanent Resident";
        this.hasKids = true;
        this.numberArray = [1,2,3];
        this.stringArray = ['hello', 'world'];
        this.mixedArray = [true, undefined, 'hello'];
        this.myTuple =['hello', 1, true];
        this.unusable = undefined;
        this.u = undefined;
        this.n = null;

        console.log(this.addNumber(2,3));
    }

    sayHello(){
        console.log(`Hello ${this.firstName}`); // NOTE:  this format is supported with ` (back quote)
    }

    hasBirthday(){
        this.age += 1;
    }

    showAge()
    {
        return this.age + 10;
    }

    addNumber(num1:number, num2:number):number{
        return num1 = num2;
    }

}