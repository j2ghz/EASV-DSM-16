import { BrowserModule } from '@angular/platform-browser';
import { NgModule } from '@angular/core';
import { FormsModule } from '@angular/forms';
import { HttpClientModule } from '@angular/common/http';
import { HttpClientInMemoryWebApiModule } from 'angular-in-memory-web-api';
import { ReactiveFormsModule } from '@angular/forms';


import { AppComponent } from './app.component';
import { BikesComponent } from './bikes/bikes.component';
import { BikeDetailComponent } from './bikes/bike-detail/bike-detail.component';
import { BikeService } from './bikes/bike.service';
import { MessagesComponent } from './messages/messages.component';
import { MessageService } from './messages/message.service';
import { AppRoutingModule } from './/app-routing.module';
import { DashboardComponent } from './dashboard/dashboard.component';
import { InMemoryDataService } from './in-memory-data.service';
import { BikeSearchComponent } from './bikes/bike-search/bike-search.component';
import { BikeNewComponent } from './bikes/bike-new/bike-new.component';


@NgModule({
  declarations: [
    AppComponent,
    BikesComponent,
    BikeDetailComponent,
    MessagesComponent,
    DashboardComponent,
    BikeSearchComponent,
    BikeNewComponent
  ],
  imports: [
    BrowserModule,
    FormsModule,
    AppRoutingModule,
    ReactiveFormsModule,
    HttpClientModule,
    // The HttpClientInMemoryWebApiModule module intercepts HTTP requests
    // and returns simulated server responses.
    // Remove it when a real server is ready to receive requests.
    HttpClientInMemoryWebApiModule.forRoot(
      InMemoryDataService, { dataEncapsulation: false }
    )
  ],
  providers: [
    BikeService,
    MessageService
  ],
  bootstrap: [AppComponent]
})
export class AppModule { }
