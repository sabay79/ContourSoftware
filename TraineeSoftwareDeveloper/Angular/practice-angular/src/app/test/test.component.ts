import { Component } from '@angular/core';

@Component({
  selector: 'app-test',

  template: `<div>Inline Template</div>`,
  templateUrl: './test.component.html',

  styles: [`div{ color: red; }`],
  styleUrls: ['./test.component.css']
})
export class TestComponent {

}
