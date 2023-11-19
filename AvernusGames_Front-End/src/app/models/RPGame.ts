import { Editora } from "./Editora";
import { Produto } from "./Produto";
import { Sistema } from "./Sistema";

export class RPGame extends Produto {
    editora: Editora = new Editora();
    editoraId: number = 0;
    releaseDate?: Date;
    sistema: Sistema = new Sistema();
    sistemaId: number = 0;
  
    CalcValorVenda(ValorCompra: number, Markup: number): number {
      const ValorVenda: number = ValorCompra * (1 + Markup);
      const taxaImposto: number = 0.15; // 15% de imposto
      const ValorTotal: number = ValorVenda * (1 + taxaImposto);
      return ValorTotal;
    }
  }
  