import { async, ComponentFixture, TestBed } from '@angular/core/testing';

import { BikeRowComponent } from './bike-row.component';

describe('BikeRowComponent', () => {
  let component: BikeRowComponent;
  let fixture: ComponentFixture<BikeRowComponent>;

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      declarations: [ BikeRowComponent ]
    })
    .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(BikeRowComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
