import { Component, OnInit } from '@angular/core';
import { FormControl, FormGroup } from '@angular/forms';
import { Venda } from 'src/app/models/Venda';
import { ItemVenda } from 'src/app/models/ItemVenda';
import { Game } from 'src/app/models/Game';
import { Vestimenta } from 'src/app/models/Vestimenta';
import { RPGame } from 'src/app/models/RPGame';
//import { ProdutosService } from 'src/app/services/produtos.service'; // Substitua pelo caminho correto
import { ClientesService } from 'src/app/services/clientes.service'; // Substitua pelo caminho correto
import { VendasService } from 'src/app/services/vendas.service';

@Component({
  selector: 'app-venda',
  templateUrl: './venda.component.html',
  styleUrls: ['./venda.component.css']
})
export class VendaComponent implements OnInit {
  formulario: any;
  tituloFormulario: string = '';
  //listaProdutos: Produto[] = [];
  itens: ItemVenda[] = [];

  constructor(
    //private produtosService: ProdutosService,
    private vendasService : VendasService
  ) {}

  ngOnInit(): void {
    this.tituloFormulario = 'Nova Venda';

    // Carregar a lista de produtos
    this.listaProdutos = this.produtosService.getProdutos();

    this.formulario = new FormGroup({
      clienteCpf: new FormControl(null),
      nf: new FormControl(null),
      produtoSelecionado: new FormControl(null),
      quantidade: new FormControl(1), // Pode inicializar com 1 ou o valor desejado
    });
  }

  adicionarItem(): void {
    const produtoSelecionado: Produto | null = this.formulario.get('produtoSelecionado').value;
    const quantidade: number = this.formulario.get('quantidade').value;

    if (produtoSelecionado && quantidade > 0) {
      const novoItem: ItemVenda = {
        vendaId: 0,
        venda: new Venda(),
        produtoId: produtoSelecionado.id,
        produto: produtoSelecionado,
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
    this.clientesService.processarVenda(venda).subscribe(result => {
      alert('Venda confirmada com sucesso.');
      // Limpar a lista de itens após confirmar a venda
      this.itens = [];
    });
  }
}
