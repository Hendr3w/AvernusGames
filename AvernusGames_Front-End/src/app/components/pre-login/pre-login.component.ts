// pré-login.component.ts

import { Component } from '@angular/core';
import { Router } from '@angular/router';

@Component({
  selector: 'app-pre-login',
  templateUrl: './pre-login.component.html',
  styleUrls: ['./pre-login.component.css']
})
export class PreLoginComponent {

  constructor(private router: Router) { }

  irParaLoginCliente(): void {
    // Navegar para a tela de login do cliente
    this.router.navigate(['/login-cliente']);
  }

  irParaLoginGerenciador(): void {
    // Navegar para a tela de login do gerenciador
    this.router.navigate(['/login-gerenciador']);
  }
}
