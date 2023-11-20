// fornecedores-list.component.ts

import { Component, OnInit } from '@angular/core';
import { Router } from '@angular/router';
import { Fornecedor } from 'src/app/models/Fornecedor';
import { FornecedoresService } from 'src/app/services/fornecedores.service';

@Component({
  selector: 'app-fonecedor-home',
  templateUrl: './fornecedor-home.component.html',
  styleUrls: ['./fornecedor-home.component.css']
})
export class FornecedorHomeComponent implements OnInit {
  fornecedores: Fornecedor[] = [];

  constructor(
    private fornecedoresService: FornecedoresService,
    private router: Router
  ) { }

  ngOnInit(): void {
    this.carregarFornecedores();
  }

  carregarFornecedores(): void {
    this.fornecedoresService.listar().subscribe((fornecedores: Fornecedor[]) => {
      this.fornecedores = fornecedores;
    });
  }

  adicionarFornecedor(): void {
    this.router.navigate(['/fornecedores']);
  }


  excluirFornecedor(id: number): void {
    if (confirm('Deseja realmente excluir este fornecedor?')) {
      this.fornecedoresService.excluir(id).subscribe(() => {
        // Recarregar a lista após a exclusão
        this.carregarFornecedores();
      });
    }
  }
}
