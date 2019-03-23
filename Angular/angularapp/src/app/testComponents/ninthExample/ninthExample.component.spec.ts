/* tslint:disable:no-unused-variable */
import { async, ComponentFixture, TestBed } from '@angular/core/testing';
import { By } from '@angular/platform-browser';
import { DebugElement } from '@angular/core';

import { NinthExampleComponent } from './ninthExample.component';

describe('NinthExampleComponent', () => {
  let component: NinthExampleComponent;
  let fixture: ComponentFixture<NinthExampleComponent>;

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      declarations: [ NinthExampleComponent ]
    })
    .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(NinthExampleComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
