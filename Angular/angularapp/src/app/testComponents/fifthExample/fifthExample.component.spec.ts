/* tslint:disable:no-unused-variable */
import { async, ComponentFixture, TestBed } from '@angular/core/testing';
import { By } from '@angular/platform-browser';
import { DebugElement } from '@angular/core';

import { FifthExampleComponent } from './fifthExample.component';

describe('FifthExampleComponent', () => {
  let component: FifthExampleComponent;
  let fixture: ComponentFixture<FifthExampleComponent>;

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      declarations: [ FifthExampleComponent ]
    })
    .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(FifthExampleComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
