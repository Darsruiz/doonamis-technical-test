import { Component, Inject, OnInit } from '@angular/core';
import { Mars, Rover } from '../model/mars.model';
import { HttpClientService } from '../service/http-client.service';

@Component({
  selector: 'app-mars',
  templateUrl: './mars.component.html'
})
export class MarsComponent implements OnInit {
  Mars!: Mars;
  FirstRover!: Rover;
  MarsBoundaries = {
    x: 0,
    y: 0
  }
  constructor(private http: HttpClientService) { }

  ngOnInit(): void {

  }

  GetMars(): void {
    this.http.GetMars().subscribe(data => {
      this.Mars = data;
    });
  }

  SetMarsBoundaries(): void {
    let x: string = this.MarsBoundaries.x.toString();
    let y: string = this.MarsBoundaries.x.toString();

    this.http.SetMarsBoundaries(x, y)
    .subscribe(data => {
      this.Mars = data;
    })
  }

  HandleMovement(name: string, movements: string): void {
    if (movements.length > 50){
      return alert("No se aceptan mas de 50 Movimientos")
    }
    this.http.HandleMovement(name, movements).subscribe(data => {
      this.FirstRover = data
    })
  }
}
