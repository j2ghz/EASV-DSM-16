import { Component, OnInit } from '@angular/core';
import { Bike } from '../bike';

@Component({
  selector: 'app-bikes',
  templateUrl: './bikes.component.html',
  styleUrls: ['./bikes.component.css']
})
export class BikesComponent implements OnInit {

  bike: Bike = {
    id: 1,
    name: 'Generic'
  };

  constructor() { }

  ngOnInit() {
  }

}
