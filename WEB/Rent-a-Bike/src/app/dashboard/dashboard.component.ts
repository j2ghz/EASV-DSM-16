import { Component, OnInit } from '@angular/core';
import { Bike } from '../bike';
import { BikeService } from '../bikes/bike.service';

@Component({
  selector: 'app-dashboard',
  templateUrl: './dashboard.component.html',
  styleUrls: [ './dashboard.component.css' ]
})
export class DashboardComponent implements OnInit {
  bikes: Bike[] = [];

  constructor(private bikeService: BikeService) { }

  ngOnInit() {
    this.getHeroes();
  }

  getHeroes(): void {
    this.bikeService.getBikes()
      .subscribe(bikes => this.bikes = bikes.slice(1, 5));
  }
}