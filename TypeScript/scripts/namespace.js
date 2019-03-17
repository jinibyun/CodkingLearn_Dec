// for testing, go to tu_13_namespace.ts
/// <reference path = "tu_10_namespace.ts" /> 
var Drawing;
(function (Drawing) {
    var Circle = /** @class */ (function () {
        function Circle() {
        }
        Circle.prototype.draw = function () {
            console.log("Circle is drawn");
        };
        return Circle;
    }());
    Drawing.Circle = Circle;
})(Drawing || (Drawing = {}));
/// <reference path = "tu_10_namespace.ts" /> 
var Drawing;
(function (Drawing) {
    var Triangle = /** @class */ (function () {
        function Triangle() {
        }
        Triangle.prototype.draw = function () {
            console.log("Triangle is drawn");
        };
        return Triangle;
    }());
    Drawing.Triangle = Triangle;
})(Drawing || (Drawing = {}));
/// <reference path = "tu_10_namespace.ts" />
/// <reference path = "tu_11_namespace.ts" />
/// <reference path = "tu_12_namespace.ts" />
var Drawing;
(function (Drawing) {
    function drawAllShapes(shape) {
        shape.draw();
    }
    drawAllShapes(new Drawing.Circle());
    drawAllShapes(new Drawing.Triangle());
})(Drawing || (Drawing = {}));
