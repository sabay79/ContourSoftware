// Immediately Invoked Function Expression - IIFE //

// Named IIFE
(function iifeFunction() {
    console.log("IIFE");
})(); // semi-colon is must here

// Un-named IIFE
(() => {
    console.log("Arrow IIFE");

})();

// IIFE with Parameter
((name) => {
    console.log(`Arrow IIFE, ${name}`);

})('Saba');
