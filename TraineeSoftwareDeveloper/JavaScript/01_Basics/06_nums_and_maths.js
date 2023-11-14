// ++++++++++++++++++++++++++++ Numbers ++++++++++++++++++++++++++++
const score = 300;
console.log(score);

const balance = new Number(100);
console.log(balance);

console.log(balance.toString().length);

console.log(balance.toFixed(2));

const anotherNumber = 1230.456789
console.log(anotherNumber.toPrecision(6));
console.log(anotherNumber.toPrecision(5));
console.log(anotherNumber.toPrecision(4));
console.log(anotherNumber.toPrecision(3));
console.log(anotherNumber.toPrecision(2));
console.log(anotherNumber.toPrecision(1));

const hundreds = 1000000
console.log(hundreds.toLocaleString());

// +++++++++++++++++++++++++++++ Maths +++++++++++++++++++++++++++++

console.log(Math.abs(-4));

console.log(Math.sqrt(49));
console.log(Math.pow(2, 3));

console.log(Math.round(4.6));
console.log(Math.ceil(4.2));
console.log(Math.floor(4.9));

console.log(Math.min(43, 23, 36, 58));
console.log(Math.max(43, 23, 36, 58));

console.log(Math.random());
console.log((Math.random()*10) + 1);
console.log(Math.floor(Math.random()*10) + 1);

const min = 1
const max = 6

console.log(Math.floor(Math.random() * (max - min + 1)) + min)  // To Generate Random number b/w min & max
