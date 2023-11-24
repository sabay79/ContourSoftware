const user = {
    username: 'saba',
    loginCount: 5,
    signedIn: true,

    getUserDetails: function() {
        console.log('Got User Details from DB');
        console.log(`Username: ${this.username}`);
        console.log(this);
    }
}

console.log(user.username);
console.log(user.getUserDetails());
console.log(this);

// Constructor Function //
function User(username, loginCount, isLoggedIn) {
    this.username = username;
    this.loginCount = loginCount;
    this.isLoggedIn = isLoggedIn;

    this.greeting = () => console.log(`Welcome ${this.username}`);

    return this;
}

const user01 = new User('saba', 10, true);
const user02 = new User('ayesha', 5, false);

console.log(user01);
console.log(user01.constructor);
console.log(user02);
