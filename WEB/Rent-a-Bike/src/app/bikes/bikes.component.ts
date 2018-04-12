import { Component, OnInit } from '@angular/core';
import { Bike } from '../bike';
import { BikeService } from './bike.service';
import { BikeDetailComponent } from './bike-detail/bike-detail.component';

@Component({
  selector: 'app-bikes',
  templateUrl: './bikes.component.html',
  styleUrls: ['./bikes.component.css']
})
export class BikesComponent implements OnInit {

  bikes: Bike[];

  selectedBike: Bike;

  constructor(private bikeService: BikeService) { }

  getBikes(): void {
    this.bikeService.getBikes().subscribe(bikes => this.bikes = bikes);
  }

  onSelect(bike: Bike): void {
    this.selectedBike = bike;
  }

  ngOnInit() {
    this.getBikes();
  }

}
