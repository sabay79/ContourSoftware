let myDate = new Date()
console.log(typeof myDate);

console.log(myDate.toString());
console.log(myDate.toDateString());
console.log(myDate.toLocaleString());

let date1 = new Date(2023, 0, 23)
console.log(date1.toLocaleString());

let date2 = new Date(2023, 0, 23, 5, 3)
console.log(date2.toLocaleString());

let date3 = new Date("2023-01-14")
console.log(date3.toLocaleString());

let date4 = new Date("01-14-2023")
console.log(date4.toLocaleString());

let myTimeStamp = Date.now()

console.log(myTimeStamp);
console.log(date4.getTime());
console.log(Math.floor(Date.now()/1000));

let newDate = new Date()
console.log(newDate);
console.log(newDate.getMonth() + 1);
console.log(newDate.getDay());

newDate.toLocaleString('default', {
    weekday: "long",
    
})
