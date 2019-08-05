import { NgModule } from '@angular/core';
import { Routes, RouterModule } from '@angular/router';
import { SalasReuniaoComponent } from '../app/SalasDeReuniao/salas-reuniao.component';

const routes: Routes = [{ path: 'salas-reuniao', component: SalasReuniaoComponent, pathMatch: 'full' },];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
