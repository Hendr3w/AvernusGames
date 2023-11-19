import { Produto } from "./Produto";
import { Venda } from "./Venda";

export class ItemVenda {
    vendaId: number = 0;
    venda: Venda = new Venda();
    produtoId: number = 0;
    produto?: Produto;
    qtd: number = 0;
  }
  