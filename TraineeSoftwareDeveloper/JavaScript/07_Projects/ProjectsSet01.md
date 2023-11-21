## Projects Related To DOM 

### For Base Code [Click Here](https://stackblitz.com/edit/dom-project-chaiaurcode?file=index.html)

### Implementation [Here](https://stackblitz.com/edit/dom-project-chaiaurcode-mbuol7?file=index.html%3AL14)

### [YouTube Tutorial](https://www.youtube.com/watch?v=EGqHVjU-fas&list=PLu71SKxNbfoBuX3f4EOACle2y-tRC5Q37&index=43)

## Solution Code

### Project 01 - Background Color Change on Click

```javascript
console.log('Change Background Color on Click');

const body = document.querySelector('body');
const buttons = document.querySelectorAll('.button');

buttons.forEach((button) => {
  console.log(button);

  button.addEventListener('click', (e) => {
    console.log(e);
    console.log(e.target);

    body.style.backgroundColor = e.target.id;
  });
});
```

### Project 02 - BMI Calculator

```javascript
console.log('BMI Calculator');

const form = document.querySelector('form');

// const height = parseInt(document.querySelector('#height').value) // this usecase will give you empty value

form.addEventListener('submit', (e) => {
  e.preventDefault();

  const height = parseInt(document.querySelector('#height').value);
  const weight = parseInt(document.querySelector('#weight').value);
  const results = document.querySelector('#results');

  if (height === '' || height < 0 || isNaN(height)) {
    results.innerHTML = `Please enter a valid Height ${height}`;
  } 
  else if (weight === '' || weight < 0 || isNaN(weight)) {
    results.innerHTML = `Please enter a valid Weight ${weight}`;
  } 
  else {
    const bmi = (weight / ((height * height) / 10000)).toFixed(2);

    // BMI Status
    let bmiStatus = 0;
    if (bmi < 18.6) {
      bmiStatus = 'Under Weight';
    } 
    else if (bmi >= 18.6 && bmi <= 24.9) {
      bmiStatus = 'Normal';
    } 
    else if (bmi > 24.9) {
      bmiStatus = 'Over Weight';
    }

    // Show Results
    results.innerHTML = `<span>${bmi}</span><br/><span>${bmiStatus}</span>`;
  }
});
```

### Project 03 - Digital Clock

```javascript
console.log('Digital Clock');

const clock = document.querySelector('#clock');
let date;

//Syntax => setInterval(function () {}, 1000);

setInterval(() => {
  date = new Date();
  clock.innerHTML = date.toLocaleTimeString();
}, 1000);
```

### Project 04 - Guess a Number

```javascript
const randomNumber = parseInt(Math.random() * 100);

const submit = document.querySelector('#subt');
const userInput = document.querySelector('#guessField');
const guessSlot = document.querySelector('.guesses');
const remaining = document.querySelector('.lastResult');
const lowOrHi = document.querySelector('.lowOrHi');
const startOver = document.querySelector('.resultParas');

const p = document.createElement('p');

let prevGuess = [];
let numGuess = 1;

let playGame = true;

if (playGame) {
  submit.addEventListener('click', (e) => {
    e.preventDefault();

    const guess = parseInt(userInput.value);
    validateGuess(guess);
  });
}

function validateGuess(guess) {
  if (isNaN(guess)) {
    alert('Please enter a valid number');
  } else if (guess < 1) {
    alert('Please enter a number greater than 0');
  } else if (guess > 100) {
    alert('Please enter a number less than 100');
  } else {
    prevGuess.push(guess);
    displayGuess(guess);

    if (numGuess === 11) {
      displayMessage(`Game Over. Number: ${randomNumber}`);
      endGame();
    } else {
      checkGuess(guess);
    }
  }
}

function checkGuess(guess) {
  if (guess === randomNumber) {
    displayMessage('You guessed it RIGHT!');
    endGame();
  } else if (guess < randomNumber) {
    displayMessage('Number is too LOW');
  } else if (guess > randomNumber) {
    displayMessage('Number is too HIGH');
  }
}

function displayGuess(guess) {
  userInput.value = '';
  guessSlot.innerHTML += `${guess}  `;
  numGuess++;
  remaining.innerHTML = `${11 - numGuess}`;
}

function displayMessage(message) {
  lowOrHi.innerHTML = `<h2>${message}</h2>`;
}

function endGame() {
  userInput.value = '';
  userInput.setAttribute('disabled', '');
  p.classList.add('button');
  p.innerHTML = `<button id="newGame">Start New Game</button>`;
  startOver.appendChild(p);
  playGame = false;
  newGame();
}

function newGame() {
  const newGameButton = document.querySelector('#newGame');
  newGameButton.addEventListener('click', function (e) {
    randomNumber = parseInt(Math.random() * 100);
    prevGuess = [];
    numGuess = 1;
    guessSlot.innerHTML = '';
    remaining.innerHTML = `${11 - numGuess} `;
    userInput.removeAttribute('disabled');
    startOver.removeChild(p);

    playGame = true;
  });
}
```
