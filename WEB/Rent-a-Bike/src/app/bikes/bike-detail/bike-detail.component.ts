import { Component, OnInit, Input } from '@angular/core';
import { Bike } from '../../bike';
import { ActivatedRoute } from '@angular/router';
import { Location } from '@angular/common';

import { BikeService } from '../bike.service';

@Component({
  selector: 'app-bike-detail',
  templateUrl: './bike-detail.component.html',
  styleUrls: ['./bike-detail.component.css']
})
export class BikeDetailComponent implements OnInit {
  @Input() bike: Bike;

  getBike(): void {
    const id = + this.route.snapshot.paramMap.get('id');
    this.bikeService.getBike(id).subscribe(bike => this.bike = bike);
  }

  constructor(
    private route: ActivatedRoute,
    private bikeService: BikeService,
    private location: Location
  ) { }

  save(): void {
    this.bikeService.updateBike(this.bike)
      .subscribe(() => this.goBack());
  }

  goBack(): void {
    this.location.back();
  }

  ngOnInit() {
    this.getBike();
  }

}
