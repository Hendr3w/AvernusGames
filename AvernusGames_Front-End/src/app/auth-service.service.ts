// auth.service.ts

import { Injectable } from '@angular/core';
import { Cliente } from './models/Cliente';

@Injectable({
  providedIn: 'root'
})
export class AuthService {
  private clienteAutenticado: Cliente | null = null;

  getClienteAutenticado(): Cliente | null {
    return this.clienteAutenticado;
  }

  setClienteAutenticado(cliente: Cliente): void {
    this.clienteAutenticado = cliente;
  }

  logout(): void {
    this.clienteAutenticado = null;
  }
}
