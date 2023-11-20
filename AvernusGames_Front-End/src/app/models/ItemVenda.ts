import { Game } from "./Game";
import { Venda } from "./Venda";

export class ItemVenda {
    vendaId: number = 0;
    venda: Venda = new Venda();
    gameId: number = 0;
    game?: Game;
    qtd: number = 0;
  }
  