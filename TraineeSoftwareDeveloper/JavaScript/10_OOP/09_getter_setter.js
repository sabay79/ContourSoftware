//////////////////////////////////////// Class Based Syntax ////////////////////////////////////////

class UserClass {
    constructor(email, password){
        this.email = email;
        this.password = password;
    }

    get email() {
        return this._email.toUpperCase();
    }

    set email(value) {
        this._email = value;
    }

    get password() {
        return `SABA${this._password.toUpperCase()}CLASS`;
    }

    set password(value)                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                   {
        this._password = value;
    }

}

console.log('\nClass Based Syntax');
const sabaC = new UserClass('saba@email.com', 'fdf123');
console.log(sabaC.email);
console.log(sabaC.password);

////////////////////////////////////// Function Based Syntax ///////////////////////////////////////

function UserFunction(email, password) {
    this._email = email;
    this._password = password;

    Object.defineProperty(this, 'email', {
        get: function() {
            return this._email.toUpperCase();
        },
        set: function(value) {
            this._email = value;
        }
    })

    Object.defineProperty(this, 'password', {
        get: function() {
            return `SABA${this._password.toUpperCase()}FUNCTION`;
        },
        set: function(value) {
            this._password = value;
        }
    })
}

console.log('\nFunction Based Syntax');
const sabaF = new UserFunction('saba@email.com', 'dhf123');
console.log(sabaF.email);
console.log(sabaF.password);

//////////////////////////////////////// Object Based Syntax ///////////////////////////////////////

const UserObject = {
    _email: 'saba@email.com',
    _password: 'adx123',

    get email() {
        return this._email.toUpperCase();
    },

    set email(value) {
        this._email = value;
    },

    get password() {
        return this._password.toUpperCase();
    },

    set password(value) {
        this._password = value;
    }
}

console.log('\nObject Based Syntax');
const sabaO = new UserFunction('saba@email.com', 'dhf123');
console.log(sabaO.email);
console.log(sabaO.password, '\n');
