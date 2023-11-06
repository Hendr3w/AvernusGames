import { CatProduto } from './CatProduto';
import { Fornecedor } from './Fornecedor';

export abstract class Produto {
  id: number = 0;
  nome: string | null = null;
  valorCompra: number = 0;
  markup: number = 0;
  descricao: string | null = null;
  categoria: CatProduto | null = null;
  categoriaId: number = 0;
  fornecedor: Fornecedor | null = null;
  fornecedorId: number = 0;

  abstract CalcValorVenda(ValorCompra: number, Markup: number): number;
}





