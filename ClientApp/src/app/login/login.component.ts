import { Component, OnInit, EventEmitter, Output } from '@angular/core';

@Component({
  selector: 'app-login',
  templateUrl: './login.component.html',
  styleUrls: ['./login.component.css']
})
export class LoginComponent {
  nombreUsuario:string;
  
  @Output() visible: EventEmitter<boolean> = new EventEmitter<boolean>();
  @Output() nombre: EventEmitter<string> = new EventEmitter<string>();
  log = false;
  cambiar() :void{
    console.log("entro a la primera funcion");
    this.log= true;
    
    this.visible.emit(this.log);
  }
  enombre(): void{
    this.nombreUsuario="lll";
    console.log("nombreUsuario..", this.nombreUsuario);
    this.nombre.emit(this.nombreUsuario);
   /* this.log= true;
    
    this.visible.emit(this.log);*/
  }

  constructor() { }


  

}
