import { CatProduto } from './CatProduto';
import { Fornecedor } from './Fornecedor';

export abstract class Produto {
  id: number = 0;
  nome: string = '';
  valorCompra: number = 0;
  markup: number = 0;
  descricao: string = '';
  categoria: CatProduto = new CatProduto();
  categoriaId: number = 0;
  fornecedor: Fornecedor = new Fornecedor();
  fornecedorId: number = 0;

  abstract CalcValorVenda(ValorCompra: number, Markup: number): number;
}





