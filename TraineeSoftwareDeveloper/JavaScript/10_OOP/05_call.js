function SetUsername(username) {
    // Complex DB Calls
    this.username = username;
    console.log('Called');
}

function createUser(username, email, password) {
    SetUsername.call(this, username);
    this.email = email;
    this.password = password;
}

const user1 = new createUser('saba', 'saba@gmail.com', 123);
console.log(user1);
