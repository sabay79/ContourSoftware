const mySym = Symbol("key1");
const mySym1 = Symbol("key2");

// object literals
const JsUser = {
    name: "Saba",
    "full name": "Saba Y",
    age: 23,
    location: 'Rwp',
    email: 'saba@contour.com',
    mySym: 'key1',  //taken as string not symbol
    [mySym1]: 'key2' // right way
}

console.log(JsUser.email);
console.log(JsUser["email"]);

console.log(JsUser["full name"]); // only this way

console.log(JsUser.mySym);
console.log(typeof JsUser.mySym);

console.log(JsUser[mySym1]);
console.log(typeof JsUser[mySym1]);

console.log(JsUser); // chk Output to see diff b/w mySym & [mySym1]

//Object.freeze(JsUser) // won't entertain changes

JsUser.greeting = function(){
    console.log("Hello, JS User");
}

JsUser.greeting2 = function(){
    console.log(`Hello, JS User, ${this.name}`);
}

console.log(JsUser.greeting());
console.log(JsUser.greeting2());
