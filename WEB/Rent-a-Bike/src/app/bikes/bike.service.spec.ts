import { TestBed, inject, async } from '@angular/core/testing';

import { BikeService } from './bike.service';

describe('BikeService', () => {
  beforeEach(() => {
    TestBed.configureTestingModule({
      providers: [BikeService]
    });
  });

  it('should be created', inject([BikeService], (service: BikeService) => {
    expect(service).toBeTruthy();
  }));

  it('should return a list of bikes', async(inject( [BikeService], ( bikeService ) => {
    bikeService.getBikes().subscribe(result => expect(result.length).toBeGreaterThan(0));
  })));
});
