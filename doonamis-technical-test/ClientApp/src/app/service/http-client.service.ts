import { Inject } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Mars, Rover } from '../model/mars.model';
import { Observable } from 'rxjs';

@Injectable({
  providedIn: 'root'
})
export class HttpClientService {
  MarsResponse!: Mars;
  BASE_URL: string;
  SET_MARS_BOUNDARIES: string = "Mars/SetMarsBoundaries";
  GET_MARS: string = "Mars/GetMars";
  HANDLE_MOVEMENT: string = "Rover/HandleRoverMovement"

  constructor(private http: HttpClient, @Inject('BASE_URL') baseUrl: string) {
    this.BASE_URL = baseUrl;
  }

  SetMarsBoundaries(x: string, y: string): Observable<Mars> {
    let url = new URL(this.BASE_URL + this.SET_MARS_BOUNDARIES)
    url.searchParams.append('x', x);
    url.searchParams.append('y', y);
    return this.http.get<Mars>(url.toString())
  };

  GetMars(): Observable<Mars> {
    let url = new URL(this.BASE_URL + this.GET_MARS).toString();
    return this.http.get<Mars>(url);
  }

  HandleMovement(name: string, movements: string): Observable<Rover> {
    let url = new URL(this.BASE_URL + this.HANDLE_MOVEMENT)
    url.searchParams.append('name', name);
    url.searchParams.append('movements', movements);
    return this.http.get<Rover>(url.toString());
  }
}
