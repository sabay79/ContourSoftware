let score = "33";
console.log(typeof(score));

let scoreInNumber = Number(score);
console.log(typeof(scoreInNumber));

// "33" => 33
// "33abc" => NaN
//  true => 1; false => 0

let isLoggedIn = 0;
console.log(typeof isLoggedIn);

let booleanIsLoggedIn = Boolean(isLoggedIn);
console.log(booleanIsLoggedIn);
console.log(typeof booleanIsLoggedIn);

// 1 => true; 0 => false
// "" => false
// "Saba" => true

// *********************** Operations ***********************

let value = 7;
let negValue = -value;
console.log(negValue);

console.log(3+2);
console.log(3-2);
console.log(3*2);
console.log(3**2);
console.log(3/2);
console.log(3%2);

let str1 = "Hello"
let str2 = "Saba"
let str3 = str1 + ', ' + str2
console.log(str3);

// MOT RECOMMENDED //

console.log("1" + 2);
console.log(1 + "2");
console.log("1" + 2 + 2);
console.log(1 + 2 + "2");

console.log( (3 + 4) * 5 % 3);

console.log(+true);
console.log(+"");

let num1, num2, num3
num1 = num2 = num3 = 2 + 2

// MOT RECOMMENDED //

let gameCounter = 100
++gameCounter;
console.log(gameCounter);

// link to study
// https://tc39.es/ecma262/multipage/abstract-operations.html#sec-type-conversion
