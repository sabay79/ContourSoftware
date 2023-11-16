const isLoggedIn = true;

if(isLoggedIn){
    console.log("User is logged in.");
}

if(2 == "2"){
    console.log("Equal Values.");
}

if(2 === "2"){
    console.log("Data Type Equal.");
} else {
    console.log("Data Type Not Equal.");
}

const userLoggedIn = true
const debitCard = true
const loggedInFromGoogle = false
const loggedInFromEmail = true

if (userLoggedIn && debitCard && 2 == 3) {
    console.log("Allow to buy course");
}

if (loggedInFromGoogle || loggedInFromEmail) {
    console.log("User logged in");
}

// Terniary Operator
// condition ? true : false

const a = false;
const b = true;
const c = a > b ? a : b;
console.log(c);

// Nullish Coalescing Operator (??): null undefined

let val1;
// val1 = 5 ?? 10
// val1 = null ?? 10
// val1 = undefined ?? 15
val1 = null ?? 10 ?? 20

console.log(val1);
