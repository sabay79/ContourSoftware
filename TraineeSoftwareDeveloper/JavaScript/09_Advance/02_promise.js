//////////////////////////////////////////////////////////////////////

const promise01 = new Promise(function(resolve, reject){
    //Do an async task
    // DB calls, cryptography, network

    setTimeout(function() {
        console.log('Async Task 1 Completed...');
        resolve();
    }, 1000);
});

promise01.then(function() {
    console.log('Promise 1 Completed...');
})

//////////////////////////////////////////////////////////////////////

new Promise((resolve, reject) => {
    setTimeout(() => {
        console.log('Async Task 2 Completed...');
        resolve();
    }, 1000);
}).then(() => {
    console.log('Promise 2 Completed...');
})

//////////////////////////////////////////////////////////////////////

const promise03 = new Promise((resolve, reject) => {
    setTimeout(() => {
        // resolve with params
        resolve({username: 'saba', email: 'saba@email.com'});
    }, 1000);
});

promise03.then((user) => {
    console.log(user);
})

//////////////////////////////////////////////////////////////////////

const promise04 = new Promise((resolve, reject) => {
    setTimeout(() => {
        let error = true;

        if(!error){
            resolve({username: 'saba', password: 123});
        }else{
            reject('ERROR: Something went wrong!');
        }
    }, 1000);
});

promise04.then((user) => {
    console.log(user);
    return user.username;
}).then((username) => {
    console.log(username);
}).catch((error) => {
    console.log(error);
}).finally(() => 
    console.log('The Promise is either resolved or rejected...'));

//////////////////////////////////////////////////////////////////////

const promise05 = new Promise((resolve, reject) => {
    setTimeout(() => {
        let error = false;
        if(!error) {
            resolve({username: 'saba', password: 123});
        } else{
            reject('ERROR: JS went wrong...');
        }
    });
});

async function consumePromise05(){
    try {
        const response = await promise05;
        console.log('Consume Response in Async Function', response);
    } catch (error) {
        console.log(error);
    }
}

consumePromise05();

//////////////////////////////////////////////////////////////////////
