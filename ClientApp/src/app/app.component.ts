import { Component } from '@angular/core';

@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  styleUrls: ['./app.component.css']
})
export class AppComponent {
  title = 'app';
  log=false;
  nombre:string;
  cambiar(event:boolean ){
    console.log("entre a la segunda funcion", event);
    this.log=event;

  }
  resnombre(event2:string ){
    console.log("el nombre que llego...........",event2);
    this.nombre=event2;
    
  }
}
