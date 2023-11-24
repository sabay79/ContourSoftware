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
