import { BrowserModule } from '@angular/platform-browser';
import { NgModule } from '@angular/core';

import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
import { AddClienteComponent } from './add-cliente/add-cliente.component';
import { AddRequisitoComponent } from './add-requisito/add-requisito.component';
import { MostrarTablaComponent } from './mostrar-tabla/mostrar-tabla.component';
import { SlimLoadingBarModule } from 'ng2-slim-loading-bar';
import { ReactiveFormsModule } from '@angular/forms';
import { ClientesService } from './clientes.service';

@NgModule({
  declarations: [
    AppComponent,
    AddClienteComponent,
    AddRequisitoComponent,
    MostrarTablaComponent
  ],
  imports: [
    BrowserModule,
    AppRoutingModule,
    SlimLoadingBarModule,
    ReactiveFormsModule
  ],
  providers: [ClientesService],
  bootstrap: [AppComponent]
})
export class AppModule { }
