import { NgModule } from '@angular/core';
import { Routes, RouterModule } from '@angular/router';
import { AddClienteComponent } from './add-cliente/add-cliente.component';
import { AddRequisitoComponent } from './add-requisito/add-requisito.component';
import { MostrarTablaComponent } from './mostrar-tabla/mostrar-tabla.component';


const routes: Routes = [
  {
    path: 'add-clientes',
    component: AddClienteComponent
  },
  {
    path: 'add-requisitos',
    component: AddRequisitoComponent
  },
  {
    path: 'tabla-requisitos',
    component: MostrarTablaComponent
  }
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
