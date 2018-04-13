import { Injectable } from '@angular/core';
import { Bike } from '../bike';
import { Observable } from 'rxjs/Observable';
import { of } from 'rxjs/observable/of';
import { MessageService } from '../messages/message.service';
import { HttpClient, HttpHeaders } from '@angular/common/http';
import { catchError, map, tap } from 'rxjs/operators';

@Injectable()
export class BikeService {
  private bikesUrl = 'api/heroes';  // URL to web api

  constructor(private http: HttpClient, private messageService: MessageService) { }

  getBikes(): Observable<Bike[]> {
    return this.http.get<Bike[]>(this.bikesUrl)
      .pipe(
        tap(bikes => this.log('fetched bikes')),
        catchError(this.handleError('getHeroes', []))
      );
  }

  getBike(id: number): Observable<Bike> {
    const url = `${this.bikesUrl}/${id}`;
    return this.http.get<Bike>(url).pipe(
      tap(_ => this.log(`fetched bike id=${id}`)),
      catchError(this.handleError<Bike>(`getBike id=${id}`))
    );
  }

  /**
 * Handle Http operation that failed.
 * Let the app continue.
 * @param operation - name of the operation that failed
 * @param result - optional value to return as the observable result
 */
  private handleError<T>(operation = 'operation', result?: T) {
    return (error: any): Observable<T> => {

      // TODO: send the error to remote logging infrastructure
      console.error(error); // log to console instead

      // TODO: better job of transforming error for user consumption
      this.log(`${operation} failed: ${error.message}`);

      // Let the app keep running by returning an empty result.
      return of(result as T);
    };
  }

  private log(message: string) {
    this.messageService.add('BikeService: ' + message);
  }

}
