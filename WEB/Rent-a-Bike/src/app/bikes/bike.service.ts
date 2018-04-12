import { Injectable } from '@angular/core';
import { Bike } from '../bike';
import { BIKES } from '../mock-bikes';

@Injectable()
export class BikeService {

  constructor() { }

  getBikes(): Bike[] {
    return BIKES;
  }

}
