import { Produto } from "./Produto";
import { Venda } from "./Venda";

export class ItemVenda {
    vendaId: number = 0;
    venda: Venda | null = null;
    produtoId: number = 0;
    produto: Produto | null = null;
    qtd: number = 0;
  }
  