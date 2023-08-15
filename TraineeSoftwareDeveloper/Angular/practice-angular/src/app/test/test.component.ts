import { Component, Input } from '@angular/core';

@Component({
  selector: 'app-test',
  templateUrl: './test.component.html',
  styleUrls: ['./test.component.css']
})

export class TestComponent 
{
  //Properties
  username = 'Saba';
  placeholder = 'Username';
  isDisabled = true;
  greeting = '';

  successClass = "success";
  dangerClass = 'danger';
  
  @Input() myCountry: any;
  // Methods
  Welcome()
  {
    return 'Welcome ' + this.username; 
  }

  Greet()
  {
    this.greeting = 'Hello ' + this.username;
    console.log(this.greeting);
  }
  
}
