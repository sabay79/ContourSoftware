let alpha = ['A', 'B', 'C'];
let aplhaValue = {
    A: 1,
    B: 2,
    C: 3,

    getAValue: function(){
        console.log(`A is ${this.A}`);
    }
}

Object.prototype.saba = function(){
    console.log('Saba - Object Prototype');
}

Array.prototype.heySaba = function(){
    console.log('Hey, Saba - Array Prototype');
}

alpha.saba();
aplhaValue.saba();

alpha.heySaba();
//aplhaValue.heySaba();
