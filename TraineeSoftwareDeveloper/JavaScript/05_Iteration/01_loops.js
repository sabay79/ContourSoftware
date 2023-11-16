// For
const array = [1, 2, 3, 4, 5];
for (let index = 0; index <= array.length; index++) {
    const element = array[index];
    console.log(element);
}

// Nested For
for (let i = 0; i <= 3; i++) {
    console.log(`Outer Loop ${i}`);
    for (let j = 0; j <= 5; j++) {
        console.log(`Inner Loop Value ${j} & Inner Loop ${i}`);
    }   
}

// break and continue

for (let index = 1; index <= 20; index++) {
    if (index == 5) {
        console.log(`Detected 5`);
        break
    }
   console.log(`Value of i is ${index}`);   
}

for (let index = 1; index <= 20; index++) {
    if (index == 5) {
        console.log(`Detected 5`);
        continue
    }
   console.log(`Value of i is ${index}`);
    
}

// https://www.youtube.com/watch?v=Y1cpFsXrEgY&list=PLu71SKxNbfoBuX3f4EOACle2y-tRC5Q37&index=27&pp=iAQB

// While
let index = 0
while (index <= 5) {
    console.log(`Value of index is ${index}`);
    index = index + 2
}

let myArray = ['flash', "batman", "superman"]

let arr = 0
while (arr < myArray.length) {
    //console.log(`Value is ${myArray[arr]}`);
    arr = arr + 1
}

// Do While
let score = 15

do {
    console.log(`Score is ${score}`);
    score++
} while (score <= 10);

// https://www.youtube.com/watch?v=w3Q55-l47P0&list=PLu71SKxNbfoBuX3f4EOACle2y-tRC5Q37&index=28
