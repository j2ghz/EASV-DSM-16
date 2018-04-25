import { Injectable } from '@angular/core';
import { InMemoryDbService } from 'angular-in-memory-web-api';
import { Bike, BikeModel } from './model';

@Injectable()
export class InMemoryDataService implements InMemoryDbService {
  createDb() {
    const bikes: Bike[] = [
      { id: 11, name: 'TESTBIKE1', notes: '1', model: { id: 1, name: 'model1', size: 'normal' } },
      { id: 12, name: 'TESTBIKE2', notes: '2', model: { id: 1, name: 'model1', size: 'normal' } },
      { id: 31, name: 'TESTBIKE3', notes: '3', model: { id: 2, name: 'model2', size: 'normal' } },
      { id: 13, name: 'TESTBIKE4', notes: '4', model: { id: 2, name: 'model2', size: 'normal' } },
    ];
    return { bikes };
  }
}
