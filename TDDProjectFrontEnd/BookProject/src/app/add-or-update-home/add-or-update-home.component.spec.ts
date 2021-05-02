import { async, ComponentFixture, TestBed } from '@angular/core/testing';

import { AddOrUpdateHomeComponent } from './add-or-update-home.component';

describe('AddOrUpdateHomeComponent', () => {
  let component: AddOrUpdateHomeComponent;
  let fixture: ComponentFixture<AddOrUpdateHomeComponent>;

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      declarations: [ AddOrUpdateHomeComponent ]
    })
    .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(AddOrUpdateHomeComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
