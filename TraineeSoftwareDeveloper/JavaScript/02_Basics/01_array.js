const arr1 = [1, 2, 3, 4, 5]
console.log(arr1);

arr1.push(6);
console.log(arr1);

arr1.pop();
console.log(arr1);

arr1.unshift(0);
console.log(arr1);

arr1.shift();
console.log(arr1);

const arr2 = new Array(1, 2, 3, 4, 5)

console.log(arr2.includes(3));
console.log(arr2.indexOf(3));
console.log(arr2[3]);

const arr3 = arr2.join(); // convert to string
console.log(arr2);
console.log(typeof arr2);
console.log(arr3);
console.log(typeof arr3);

// SLICE vs SPLICE //

console.log("A", arr1);

const sliceArr = arr1.slice(1, 3);
console.log(sliceArr, "slice");
console.log("B", arr1);

const spliceArr = arr1.splice(1, 3);
console.log(spliceArr, "splice");
console.log("C", arr1);

const marvel_heros = ["thor", "Ironman", "spiderman"]
const dc_heros = ["superman", "flash", "batman"]

marvel_heros.push(dc_heros)
console.log(marvel_heros);

// CONCAT vs SPREAD //

const allHeros_Concat = marvel_heros.concat(dc_heros)
console.log(allHeros_Concat);

const allHeros_Spread = [...marvel_heros, ...dc_heros]
console.log(allHeros_Spread);

const another_array = [1, 2, 3, [4, 5, 6], 7, [6, 7, [4, 5]]]

const real_another_array = another_array.flat(Infinity)
console.log(real_another_array);

console.log(Array.isArray("Saba"))
console.log(Array.from("Saba"))
console.log(Array.from({name: "Saba"})) // interesting

let score1 = 100
let score2 = 200
let score3 = 300

console.log(Array.of(score1, score2, score3));
