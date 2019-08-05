import { BrowserModule } from '@angular/platform-browser';
import { NgModule } from '@angular/core';
import { FormsModule } from '@angular/forms';
import { HttpClientModule } from '@angular/common/http';
import { RouterModule } from '@angular/router';


import { AppComponent } from '../app/app.component';
import { NavMenuComponent } from '../app/nav-menu/nav-menu.component';
import { SalasReuniaoComponent } from '../app/SalasDeReuniao/salas-reuniao.component';
import { NgbModule } from '@ng-bootstrap/ng-bootstrap';
import { LoginComponent } from './login/login.component';
import { AuthService } from './login/auth.service';

@NgModule({
  declarations: [
    AppComponent,
    NavMenuComponent,
    SalasReuniaoComponent,
    LoginComponent,
  ],
  imports: [
    BrowserModule.withServerTransition({ appId: 'ng-cli-universal' }),
    HttpClientModule,
    FormsModule,
    NgbModule,
    RouterModule.forRoot([
      { path: '', component: LoginComponent, pathMatch: 'full' },
      { path: 'salas-reuniao', component: SalasReuniaoComponent },
    ])
  ],
  providers: [AuthService],
  bootstrap: [AppComponent]
})
export class AppModule { }
