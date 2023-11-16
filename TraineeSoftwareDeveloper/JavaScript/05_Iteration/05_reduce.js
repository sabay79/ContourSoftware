const myNums = [1, 2, 3]

/*
const sumWithInitial = myNums.reduce((accumulator, currentValue) => 
    accumulator + currentValue, initialValue
);
 */

const myTotal = myNums.reduce(function (acc, currval) {
    console.log(`acc: ${acc} and currval: ${currval}`);
    return acc + currval
}, 0)
console.log(myTotal);

const myTotal1 = myNums.reduce( (acc, curr) => acc+curr, 0)
console.log(myTotal1);


const shoppingCart = [
    {
        itemName: "JS course",
        price: 2999
    },
    {
        itemName: "Python course",
        price: 999
    },
    {
        itemName: "Andriod course",
        price: 4999
    },
    {
        itemName: "Data Science course",
        price: 9999
    },
]

const priceToPay = shoppingCart.reduce((acc, item) => acc + item.price, 0)
console.log(priceToPay);
