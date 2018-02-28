import { BrowserModule } from '@angular/platform-browser';
import { NgModule } from '@angular/core';


import { AppComponent } from './app.component';
import { BikesComponent } from './bikes/bikes.component';
import { BikeListComponent } from './bikes/bike-list/bike-list.component';
import { BikeRowComponent } from './bikes/bike-list/bike-row/bike-row.component';
import { BikeComponent } from './bikes/bike-list/bike-row/bike/bike.component';


@NgModule({
  declarations: [
    AppComponent,
    BikesComponent,
    BikeListComponent,
    BikeRowComponent,
    BikeComponent
  ],
  imports: [
    BrowserModule
  ],
  providers: [],
  bootstrap: [AppComponent]
})
export class AppModule { }
