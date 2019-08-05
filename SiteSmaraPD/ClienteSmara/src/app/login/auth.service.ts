import { Injectable,EventEmitter } from '@angular/core';
import { Usuario } from './usuario';
import { Route, Router } from '@angular/router';


@Injectable({
  providedIn: 'root'
})
export class AuthService {

  public usuarioAutenticado: boolean = false;

  mostrarMenuEmitter = new EventEmitter<boolean>();

  constructor(private router: Router) { }

  fazerLogin(usuario: Usuario) {
    if (usuario.email === 'admin@gmail.com' && usuario.senha === '1234') {
      this.usuarioAutenticado = true;
      this.mostrarMenuEmitter.emit(true);
      this.router.navigate(['/salas-reuniao']);
    } else {
      this.usuarioAutenticado = false;
      this.mostrarMenuEmitter.emit(false);
    }
  }
}
