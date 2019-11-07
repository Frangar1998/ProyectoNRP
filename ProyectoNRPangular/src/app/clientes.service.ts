import { Injectable } from '@angular/core';

@Injectable({
  providedIn: 'root'
})
export class ClientesService {

  constructor() { }

  addProduct(NombreCliente, PesoCliente) {
    const obj = {
      NombreCliente,
      PesoCliente
    };
    
  }
}
