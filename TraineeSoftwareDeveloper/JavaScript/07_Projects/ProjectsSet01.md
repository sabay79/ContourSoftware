## Projects Related To DOM 

### For Base Code [Click Here](https://stackblitz.com/edit/dom-project-chaiaurcode?file=index.html)

### Implementation [Here](https://stackblitz.com/edit/dom-project-chaiaurcode-mbuol7?file=index.html%3AL14)

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
