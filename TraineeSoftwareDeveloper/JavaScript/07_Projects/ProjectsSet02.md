## Projects Related To DOM 

### For Base Code [Click Here](https://stackblitz.com/edit/dom-project-chaiaurcode?file=index.html)

### Implementation [Here](https://stackblitz.com/edit/dom-project-chaiaurcode-mbuol7?file=index.html%3AL14)

### [YouTube Tutorial](https://www.youtube.com/watch?v=efrW5-IYoCU&list=PLu71SKxNbfoBuX3f4EOACle2y-tRC5Q37&index=39)

## Solution Code

### Project 05 - Get Key Info
```javascript
console.log('Get Key Info');

const insert = document.getElementById('insert');

window.addEventListener('keydown', (e) => {
  insert.innerHTML = `
    <table>
      <tr>
        <th>Key</th>
        <th>Code</th>
        <th>Key Code</th>
      </tr>
      <tr>
        <td>${e.key === ' ' ? 'Space' : e.key}</td>
        <td>${e.code}</td>
        <td>${e.keyCode}</td>
      </tr>
    </table>
  `;
});
```

### Project 06 - Change Background Color Randomly
```javascript
console.log('Randomly Change Background Color');

const randomColor = () => {
  const hex = '0123456789ABCDEF';
  let color = '#';
  for (let i = 0; i < 6; i++) {
    color += hex[Math.floor(Math.random() * 16)];
  }
  return color;
};

let intervalId;

const startChangingColor = () => {
  if (!intervalId) {
    intervalId = setInterval(changeBgColor, 500);

    function changeBgColor() {
      document.body.style.backgroundColor = randomColor();
    }
  }
};

const stopChangingColor = () => {
  clearInterval(intervalId);
  intervalId = null;
};

document.querySelector('#start').addEventListener('click', startChangingColor);
document.querySelector('#stop').addEventListener('click', stopChangingColor);
```
