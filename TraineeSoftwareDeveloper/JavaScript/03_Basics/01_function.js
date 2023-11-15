function myName() {
    console.log("Saba");
}

function addTwoNumbers(num1, num2) {
    //console.log(num1 + num2);
    return num1 + num2;
}

myName();
console.log(addTwoNumbers(10, 20));
 
// function with object as param

// function with array as param

////////////////////////////// this Operator //////////////////////////////

const user = {
    username: 'saba',
    email: 'saba@gmail.com',

    welcomeMessage: function() {
        console.log(`${this.username}, Welcome to Website`);

        console.log(this);
        console.log(typeof this);
    }
}
user.welcomeMessage();

function func1(){
    let username = 'func 1';
    console.log(this);
    console.log(username);
    console.log(this.username);
}
func1();

const func2 = function() {
    let username = 'func 2';
    console.log(this);
    console.log(username);
    console.log(this.username);
}
func2();

function sumRestOperator(n1, n2, ...n) {
    return [n1+n2, n];
}
console.log(sumRestOperator(1, 2, 1, 1, 1, 1, 1));

///////////////////////////// Arrow Function /////////////////////////////

const func3 = () => {
    let username = 'func 3';
    console.log(this);
    console.log(username);
    console.log(this.username);
}
func3();

const sum = (num1, num2) => {
    return num1 + num2;
}
console.log(sum(10, 20));

const sumImplicit = (num1, num2) => num1 + num2;
console.log(sumImplicit(10, 20));
