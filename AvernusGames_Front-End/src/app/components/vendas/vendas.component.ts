import { Component, OnInit } from '@angular/core';
import { FormControl, FormGroup } from '@angular/forms';
import { Venda } from 'src/app/models/Venda';
import { ItemVenda } from 'src/app/models/ItemVenda';
import { Game } from 'src/app/models/Game';
import { Cliente } from 'src/app/models/Cliente'; 
import { VendasService } from 'src/app/services/vendas.service';
import { GamesService } from 'src/app/services/games.service';
import { ClientesService } from 'src/app/services/clientes.service'; 
@Component({
  selector: 'app-venda',
  templateUrl: './vendas.component.html',
  styleUrls: ['./vendas.component.css']
})
export class VendasComponent implements OnInit {
  formulario: any;
  tituloFormulario: string = '';
  itens: ItemVenda[] = [];
  games: Game[] = [];
  clientes: Cliente[] = []; // Adicione a lista de clientes
  valorTotal: number = 0;

  constructor(
    private gameService: GamesService,
    private vendasService: VendasService,
    private clientesService: ClientesService // Injete o serviço de clientes
  ) {}

  ngOnInit(): void {
    this.tituloFormulario = 'Nova Venda';

    this.gameService.listar().subscribe((games: Game[]) => {
      this.games = games;
    });

    this.clientesService.listar().subscribe((clientes: Cliente[]) => { // Obtenha a lista de clientes
      this.clientes = clientes;
    });

    this.formulario = new FormGroup({
      clienteSelecionado: new FormControl(null),
      nf: new FormControl(null),
      produtoSelecionado: new FormControl(null),
      quantidade: new FormControl(1),
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
      this.atualizarValorTotal();

      this.formulario.patchValue({
        produtoSelecionado: null,
        quantidade: 1,
      });
    }
  }

  enviarFormulario(): void {
    const venda: Venda = this.formulario.value;
    venda.cliente = this.formulario.get('clienteSelecionado').value; // Obtenha o cliente selecionado
    venda.itens = this.itens;

    this.vendasService.cadastrar(venda).subscribe(result => {
      this.atualizarValorTotal();
      alert('Venda confirmada com sucesso.');
      this.itens = [];
    });
  }

  private atualizarValorTotal(): void {
    this.valorTotal = this.itens.reduce((total, item) => total + this.calcTotalGame(item), 0);
  }

  private calcTotalGame(item: any): number {
    return this.calcValorVenda(item.game?.valorcompra, item.game?.markup) * item.qtd;
  }

  calcValorVenda(valorCompra: number, markup: number): number {
    const valorVenda: number = valorCompra * (1 + markup);
    const taxaImposto: number = 0.15;
    const valorTotal: number = valorVenda * (1 + taxaImposto);
    return valorTotal;
  }
}
