import { Injectable } from '@angular/core';
import { Bike } from '../bike';
import { BIKES } from '../mock-bikes';
import { Observable } from 'rxjs/Observable';
import { of } from 'rxjs/observable/of';

@Injectable()
export class BikeService {

  constructor() { }

  getBikes(): Observable<Bike[]> {
    return of(BIKES);
  }

}
