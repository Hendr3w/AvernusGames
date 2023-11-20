import { Component, OnInit } from '@angular/core';
import { FormControl, FormGroup } from '@angular/forms';
import { Venda } from 'src/app/models/Venda';
import { ItemVenda } from 'src/app/models/ItemVenda';
import { Game } from 'src/app/models/Game';
import { ClientesService } from 'src/app/services/clientes.service';
import { VendasService } from 'src/app/services/vendas.service';
import { GamesService } from 'src/app/services/games.service';
import { Observable, isObservable } from 'rxjs';

@Component({
  selector: 'app-venda',
  templateUrl: './vendas.component.html',
  styleUrls: ['./vendas.component.css']
})
export class VendasComponent implements OnInit {
  formulario: any;
  tituloFormulario: string = '';
  itens : ItemVenda[] = [];
  games : Game[] = [];

  constructor(
    private gameService : GamesService,
    private vendasService : VendasService
  ) {}

  ngOnInit(): void {
    this.tituloFormulario = 'Nova Venda';
    
    this.gameService.listar().subscribe((games: Game[]) => {
      this.games = games;
    });

    this.formulario = new FormGroup({
      clienteCpf: new FormControl(null),
      nf: new FormControl(null),
      produtoSelecionado: new FormControl(null),
      quantidade: new FormControl(1), // Pode inicializar com 1 ou o valor desejado
    });
  }

  adicionarItem(): void {
    const produtoSelecionado: Game | null = this.formulario.get('produtoSelecionado').value;
    const quantidade: number = this.formulario.get('quantidade').value;

    if (produtoSelecionado && quantidade > 0) {
      const novoItem: ItemVenda = {
        vendaId: 0,
        venda: new Venda(),
        gameId: produtoSelecionado.id,
        game: produtoSelecionado,
        qtd: quantidade,
      };

      this.itens.push(novoItem);

      // Limpar os campos do formulário após adicionar o item
      this.formulario.patchValue({
        produtoSelecionado: null,
        quantidade: 1,
      });
    }
  }

  enviarFormulario(): void {
    const venda: Venda = this.formulario.value;
    venda.itens = this.itens;

    // Lógica para processar a venda, como chamar um serviço
    this.vendasService.cadastrar(venda).subscribe(result => {
      alert('Venda confirmada com sucesso.');
      // Limpar a lista de itens após confirmar a venda
      this.itens = [];
    });
  }
}
