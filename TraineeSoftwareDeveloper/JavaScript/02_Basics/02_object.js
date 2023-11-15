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

const JsUser2 = new Object(); // Singleton Object
const JsUser3 = {} // Non-Singleton Object

JsUser2.id = 1;
JsUser2.name= 'Saba';
JsUser2.email= 'saba@gmail.com'

console.log(JsUser2);

const regularUser = {
    email: 'saba@gmail.com',
    fullName: {
        userFullName: {
            firstName: 'Saba',
            lastName: 'Yashfeen'
        }
    }
}

console.log(regularUser);
console.log(regularUser.fullName.userFullName.firstName);

const obj1 = {1: 'a', 2: 'b'}
const obj2 = {3: 'c', 4: 'd'}

const obj3 = {obj1, obj2}
console.log(obj3);

const obj4 = Object.assign({}, obj1, obj2);
console.log(obj4);

const obj5 = {...obj1, ...obj4}
console.log(obj5);

// Get Object Keys in form of an Array
console.log(Object.keys(regularUser));

// Get Object Values in form of an Array
console.log(Object.values(regularUser));

// Get Object in form of an Array
console.log(Object.entries(regularUser));

console.log(regularUser.hasOwnProperty('fullName'));
console.log(regularUser.hasOwnProperty('myName'));

///////////////////////////// Object De-structure /////////////////////////////

const course = {
    courseName: 'JS',
    price: 1000
}

//course.courseName
const {courseName} = course
console.log(courseName);

const {courseName: courseN} = course
console.log(courseN);
