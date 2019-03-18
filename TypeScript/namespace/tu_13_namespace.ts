/// <reference path = "tu_10_namespace.ts" />
/// <reference path = "tu_11_namespace.ts" />
/// <reference path = "tu_12_namespace.ts" />
namespace Drawing{
    function drawAllShapes(shape: IShape) {
    shape.draw();
    }
    drawAllShapes(new Drawing.Circle());
    drawAllShapes(new Drawing.Triangle());
}

// NOTE: to compile, we can use concatenated output using the --outFile flag to compile all of the input files into a single JavaScript output file:
// The compiler will automatically order the output file based on the reference tags present in the files. You can also specify each file individually:

// NOTE: use below
// tsc --out scripts/namespace.js tu_13_namespace.ts

// Alternatively, we can use per-file compilation (the default) to emit one JavaScript file for each input file. If multiple JS files get produced, we’ll need to use <script> tags on our webpage to load each emitted file in the appropriate order
