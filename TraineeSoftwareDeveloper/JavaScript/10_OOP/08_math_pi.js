const piDescripter = Object.getOwnPropertyDescriptor(Math, 'PI');
console.log(piDescripter); // can't override PI value bcx "writable: false,"

const chai = {
     name: 'ginger chai',
     price: 250,
     isAvailable: true,

     orderChai: function(){
        console.log('No Chai');
     }
}

console.log(Object.getOwnPropertyDescriptor(chai, 'name'));

Object.defineProperty(chai, 'name', {
    writable: false,
    enumerable: false,
});

console.log(Object.getOwnPropertyDescriptor(chai, 'name'));

for(let [key, value] of Object.entries(chai)){
    if(typeof value !== 'function'){
        console.log(`${key} : ${value}`);
    }
}
