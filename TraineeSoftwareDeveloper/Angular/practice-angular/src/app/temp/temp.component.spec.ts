import { ComponentFixture, TestBed } from '@angular/core/testing';

import { TempComponent } from './temp.component';

describe('TempComponent', () => {
  let component: TempComponent;
  let fixture: ComponentFixture<TempComponent>;

  beforeEach(() => {
    TestBed.configureTestingModule({
      declarations: [TempComponent]
    });
    fixture = TestBed.createComponent(TempComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
