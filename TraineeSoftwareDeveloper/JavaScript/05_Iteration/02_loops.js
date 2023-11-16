// for of
const array = [1, 2, 3, 4, 5]
for (const num of array) {
    console.log(num);
}

const intro = 'My name is Saba';
for (const ch of intro) {
    console.log(`Each char is ${ch}`);
}

// Maps Iteration
const map = new Map();
map.set('PK', 'Pakistan');
map.set('UK', 'United Kingdom');

console.log(map);

for (const kvp of map) {
    console.log(kvp);
}
for (const [key, value] of map) {
    console.log(key, ':', value);
}

// for in
const myObj = {
    csharp: "C#",
    dotnet: ".NET",
    react: "React"
}

for(const key in myObj){
    console.log(key, ":", myObj[key]);
}

const alphabets = ["A", 'B', 'C', 'D', 'E'];
for (const key in alphabets) {
    console.log(key);
    console.log(alphabets[key]);
}

// foreach
alphabets.forEach(function (item) {
    console.log(item);
})

alphabets.forEach((item) => {
    console.log(item);
})

alphabets.forEach((item, index, arr) => {
    console.log(item, index, arr);
})
