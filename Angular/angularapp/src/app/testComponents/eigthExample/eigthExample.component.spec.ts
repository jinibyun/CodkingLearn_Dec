/* tslint:disable:no-unused-variable */
import { async, ComponentFixture, TestBed } from '@angular/core/testing';
import { By } from '@angular/platform-browser';
import { DebugElement } from '@angular/core';

import { EigthExampleComponent } from './eigthExample.component';

describe('EigthExampleComponent', () => {
  let component: EigthExampleComponent;
  let fixture: ComponentFixture<EigthExampleComponent>;

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      declarations: [ EigthExampleComponent ]
    })
    .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(EigthExampleComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
