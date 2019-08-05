import { Component, Inject, ViewChild, ElementRef, Input} from '@angular/core';
import { HttpClient, HttpHeaders } from '@angular/common/http';
import { NgbModal, ModalDismissReasons } from '@ng-bootstrap/ng-bootstrap';
import { AuthService } from '../login/auth.service';
import { Injectable } from '@angular/core';
import { Observable } from 'rxjs';
import { map } from 'rxjs/operators';
import { FormsModule } from '@angular/forms'
fetch("http://localhost:4200", { mode: "no-cors" });

@Injectable({
  providedIn: "root"
})


@Component({
  selector: 'app-salas-reuniao',
  templateUrl: './salas-reuniao.component.html'
})

export class SalasReuniaoComponent {
  mostrarMenu: boolean = this.authService.usuarioAutenticado;
  public adminUsernameText: string;
  private url = "https://localhost:44373/api/salareuniao";


  closeResult: string;
  public salaDisponivel: SalaReuniao[];
  public salaReservada: SalaReuniao[];

  constructor(private http: HttpClient, @Inject('BASE_URL') baseUrl: string, private modalService: NgbModal, private authService: AuthService,) {
    http.get<SalaReuniao[]>(this.url + '/saladisponivel').subscribe(result => {
      this.salaDisponivel = result;
    }, error => console.error(error));
    http.get<SalaReuniao[]>(this.url + '/salareservada').subscribe(result => {
      this.salaReservada = result;
    }, error => console.error(error));

  }

  open(content) {
    this.modalService.open(content, { ariaLabelledBy: 'modal-basic-title' }).result.then((result) => {
      this.closeResult = `Closed with: ${result}`;
    }, (reason) => {
      this.closeResult = `Dismissed ${this.getDismissReason(reason)}`;
    });
  }
  
  public reservarSala(sala: string, id: string, clienteId) {
    console.log("teste" + this.adminUsernameText);
    const headers = new HttpHeaders()
    headers.append("Roles", "Administrator");
    const date = new Date();
    var body = {
      Sala: sala,
      DataEntrega: date.toLocaleDateString(),
      Id: id,
      ClienteId: clienteId,
    }


    this.modalService.dismissAll();
    return this.http.post(this.url, body, { headers }).subscribe(
      data => console.log(data),
      error => {
        console.log(error);
      },
      () => {
        // function to execute after successfull api call
      }
    );
  }

  private getDismissReason(reason: any): string {
    if (reason === ModalDismissReasons.ESC) {
      return 'by pressing ESC';
    } else if (reason === ModalDismissReasons.BACKDROP_CLICK) {
      return 'by clicking on a backdrop';
    } else {
      return `with: ${reason}`;
    }
  }
}

interface SalaReuniao {
  sala: string;
  dataLocacao: string;
  dataEntrega: string;
  clientes: string;
  id: number;
  clienteId: number;
}
