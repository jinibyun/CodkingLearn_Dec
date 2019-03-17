define(["require", "exports"], function (require, exports) {
    "use strict";
    exports.__esModule = true;
    var Circle = /** @class */ (function () {
        function Circle() {
        }
        Circle.prototype.draw = function () {
            console.log("Circle is drawn (external module");
        };
        return Circle;
    }());
    exports.Circle = Circle;
});
