import { Component } from '@angular/core';
import { Router } from '@angular/router';

@Component({
  selector: 'app-home',
  templateUrl: './home.component.html',
  styleUrls: ['./home.component.css']
})
export class HomeComponent {
  constructor(private router: Router) {}

  irParaFuncionarioHome(): void {
    // Navegar para a tela de login de funcionários
    this.router.navigate(['/funcionario_home']);
  }
  irParaFornecedorHome(): void {
    // Navegar para a tela de pré-login
    this.router.navigate(['/fornecedor_home']);
  }
  irParaGameHome(): void {
    // Navegar para a tela de login de cliente
    this.router.navigate(['/game_home']);
  }
}
