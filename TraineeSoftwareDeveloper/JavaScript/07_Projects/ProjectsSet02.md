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
