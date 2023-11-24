// ES6

class User {
    constructor(username, email, password){
        this.username = username;
        this.email = email;
        this.password = password;
    }

    encryptPassword(){
        return `01010${this.password}AB123CD`;
    }

    changeUsername(){
        return `${this.username.toUpperCase()}`;
    }
}

const user1 = new User('saba', 'saba@email.com', 123);

console.log(user1.encryptPassword());
console.log(user1.changeUsername());

// BEHIND THE SCENE //

function UserByFunc(username, email, password){
    this.username = username;
    this.email = email;
    this.password = password;
}

UserByFunc.prototype.encryptPassword = function(){
    return `01010${this.password}AB123CD`;
}

UserByFunc.prototype.changeUsername = function(){
    return `${this.username.toUpperCase()}`;
}

const user2 = new UserByFunc('saba', 'saba@email.com', 101);
console.log(user2.encryptPassword());
console.log(user2.changeUsername());
