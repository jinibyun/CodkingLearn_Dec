/* tslint:disable:no-unused-variable */
import { async, ComponentFixture, TestBed } from '@angular/core/testing';
import { By } from '@angular/platform-browser';
import { DebugElement } from '@angular/core';

import { FourthExampleComponent } from './fourthExample.component';

describe('FourthExampleComponent', () => {
  let component: FourthExampleComponent;
  let fixture: ComponentFixture<FourthExampleComponent>;

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      declarations: [ FourthExampleComponent ]
    })
    .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(FourthExampleComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
