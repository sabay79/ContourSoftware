/* JavaScript was designed to be easy to learn and allows certain mistakes to be made by the developer. 
For example, JavaScript does not throw an error when you use a misspelled variable, and instead creates a new global one. 
While having fewer errors is tempting when you start learning JavaScript, it can lead to writing code that is harder for browsers to optimize and harder for you to debug.

Switch to strict mode to get more useful errors when you make mistakes. */
'use strict';

const switcher = document.querySelector('.btn');
switcher.addEventListener('click', function()
{
    document.body.classList.toggle('light-theme');
    document.body.classList.toggle('dark-theme');

    const className = document.body.className;
    if(className == "light-theme")
    {
        this.textContent = "Dark";
    }
    else
    {
        this.textContent = "Light";
    }

    /* As a web developer, you can create hidden messages that won't appear on your webpage, 
    but that you can read in the Developer Tools, in the Console tab. 
    Using console messages is helpful for seeing the result of your code.
    */
   console.log("Current class name: " + className);
   console.log("Reference: https://learn.microsoft.com/en-gb/training/modules/get-started-with-web-development/7-summary");
});