import { Injectable } from '@angular/core';
import { Bike } from '../bike';
import { BIKES } from '../mock-bikes';
import { Observable } from 'rxjs/Observable';
import { of } from 'rxjs/observable/of';
import { MessageService } from '../messages/message.service';

@Injectable()
export class BikeService {

  constructor(private messageService: MessageService) { }

  getBikes(): Observable<Bike[]> {
    this.messageService.add('BikeService: fetched bikes at ' + new Date().toLocaleString());
    return of(BIKES);
  }

}
