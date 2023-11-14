//Declaration
const accountId = 10
let accountEmail = "saba@gmail.com"
var accountPassword = "12345"
accountCity = "Islamabad" // Not Recommended
let accountState;

// Updation
//accountId = 2 // Not Allowed
accountEmail = 'saba_y@gmail.com'
accountPassword = 54321
accountCity = "Rawalpindi"

// Display
console.log(accountId);
console.table([accountId, accountEmail, accountPassword, accountCity, accountState])
 
/*
Prefer not to use var
bcz of issue in block scope & functional scope
*/
