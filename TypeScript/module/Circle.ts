import shape = require("./IShape"); // no file extension
export class Circle implements shape.IShape{
    public draw(){
        console.log("Circle is drawn (external module");
    }
}