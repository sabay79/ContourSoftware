const User = {
    name: 'saba',
    email: 'saba@gmail.com'
};

const Teacher = {
    isPresent: true
}

const TeachingSupport = {
    isAvailable: false
}

const TASupport = {
    makeAssignment: 'JS assignment',
    fullTime: true,
    __proto__: TeachingSupport
}

Teacher.__proto__ = User;

// Modern Syntax
Object.setPrototypeOf(TeachingSupport, Teacher);

//////////////////////////////////////////////////////////////////////

class UserClass{
    constructor(username){
        this.username = username;
    }

    logMe(){
        console.log(`Username is ${this.username}`);
    }
}

class TeacherClass extends UserClass{
    constructor(username, email, password){
        super(username);
        this.email = email;
        this.password = password;
    }

    addCourse(){
        console.log(`A new course was added by ${this.username}`);
    }
}
const user = new UserClass('saba');
user.logMe();

const teacher = new TeacherClass('ayesha', 'ayesha@gmail.com', 12345);
teacher.logMe();

console.log(user instanceof UserClass);
console.log(user instanceof TeacherClass);

console.log(teacher instanceof UserClass);
console.log(teacher instanceof TeacherClass);
