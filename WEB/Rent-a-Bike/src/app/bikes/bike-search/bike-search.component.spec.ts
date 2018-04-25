import { async, ComponentFixture, TestBed } from '@angular/core/testing';

import { BikeSearchComponent } from './bike-search.component';
import { RouterLinkDirectiveStub } from '../../../testing/router-link-directive-stub';
import { BikeService } from '../bike.service';
import { Bike } from '../../bike';
import { Observable } from 'rxjs/Observable';
import { of } from 'rxjs/observable/of';

describe('BikeSearchComponent', () => {
  let component: BikeSearchComponent;
  let fixture: ComponentFixture<BikeSearchComponent>;
  let bikeServiceStub: Partial<BikeService>;
  let bikes: Bike[] = [{ id: 0, name: "Test" }];

  beforeEach(async(() => {
    bikeServiceStub = {
      searchBikes: (term: string) => {
        return of(bikes)
      }
    }

    TestBed.configureTestingModule({
      declarations: [
        BikeSearchComponent,
        RouterLinkDirectiveStub
      ],
      providers: [
        { provide: BikeService, useValue: bikeServiceStub }
      ]
    })
      .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(BikeSearchComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });

  it('should return a test bike', () => {
    let element: HTMLElement = fixture.nativeElement
    const hostElement = fixture.nativeElement;
    const nameInput: HTMLInputElement = hostElement.querySelector('input');
    nameInput.value = 'T';
    nameInput.dispatchEvent(new Event('input'));
    fixture.detectChanges();
    expect(element.textContent).toContain(bikes[0].name)

  })
});
