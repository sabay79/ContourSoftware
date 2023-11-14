const name = 'Saba'
const repoCount = 20

// String Concatenation
console.log(name + " " + repoCount);

// String Interpolation
console.log(`Hi, my name is ${name} & my repo count is ${repoCount}`);

/* Interpolation is more mature than concatenation */

const myName = new String(' Saba - Yashfeen ')
console.log(myName[0]);

console.log(myName.length)

console.log(myName.toUpperCase());
console.log(myName.toLowerCase());

console.log(myName.charAt(2));
console.log(myName.indexOf('b'));

console.log(myName.substring(0,4));
console.log(myName.slice(0, 4));
console.log(myName.slice(-8, 4));

console.log(myName.trim()); //Saba - Yashfeen//

console.log(myName.replace('-', '')); // Saba  Yashfeen //

console.log(myName.includes('ab')); //true

console.log(myName.split('-'));

// https://developer.mozilla.org/en-US/docs/Web/JavaScript/Reference/Global_Objects/String
