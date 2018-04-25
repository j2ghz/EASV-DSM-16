import { Component, OnInit } from '@angular/core';
import { Bike } from '../model';
import { BikeService } from './bike.service';
import { BikeDetailComponent } from './bike-detail/bike-detail.component';

@Component({
  selector: 'app-bikes',
  templateUrl: './bikes.component.html',
  styleUrls: ['./bikes.component.css']
})
export class BikesComponent implements OnInit {

  bikes: Bike[];

  constructor(private bikeService: BikeService) { }

  getBikes(): void {
    this.bikeService.getBikes().subscribe(bikes => this.bikes = bikes);
  }

  ngOnInit() {
    this.getBikes();
  }

  add(name: string): void {
    name = name.trim();
    if (!name) { return; }
    this.bikeService.addBike({ name } as Bike)
      .subscribe(bike => {
        this.bikes.push(bike);
      });
  }

  delete(bike: Bike): void {
    this.bikes = this.bikes.filter(h => h !== bike);
    this.bikeService.deleteBike(bike).subscribe();
  }

}
