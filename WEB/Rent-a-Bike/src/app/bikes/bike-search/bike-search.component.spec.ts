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

  beforeEach(async(() => {
    bikeServiceStub = {
      searchBikes: (term: string) => {
        return of([{ id: 0, name: "Test" }])
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
});
