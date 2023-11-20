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
