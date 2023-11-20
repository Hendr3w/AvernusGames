// lista-funcionarios.component.ts

import { Component, OnInit } from '@angular/core';
import { Router } from '@angular/router';
import { Funcionario } from 'src/app/models/Funcionario';
import { FuncionariosService } from 'src/app/services/funcionarios.service';

@Component({
  selector: 'app-funcionario-home',
  templateUrl: './funcionario-home.component.html',
  styleUrls: ['./funcionario-home.component.css']
})
export class FuncionarioHomeComponent implements OnInit {
  funcionarios: Funcionario[] = [];

  constructor(private router: Router, private funcionariosService: FuncionariosService) {}

  ngOnInit(): void {
    this.carregarFuncionarios();
  }

  carregarFuncionarios(): void {
    this.funcionariosService.listar().subscribe((funcionarios: Funcionario[]) => {
      this.funcionarios = funcionarios;
    });
  }

  adicionarFuncionario(): void {
    this.router.navigate(['/funcionarios']);
  }

  excluir(id: number): void {
    this.funcionariosService.excluir(id).subscribe(() => {
      this.carregarFuncionarios();
    })
  }
}
