import { Editora } from "./Editora";
import { Produto } from "./Produto";
import { Sistema } from "./Sistema";

export class RPGame extends Produto {
    editora: Editora | null = null;
    editoraId: number = 0;
    releaseDate: Date | null = null;
    sistema: Sistema | null = null;
    sistemaId: number = 0;
  
    CalcValorVenda(ValorCompra: number, Markup: number): number {
      const ValorVenda: number = ValorCompra * (1 + Markup);
      const taxaImposto: number = 0.15; // 15% de imposto
      const ValorTotal: number = ValorVenda * (1 + taxaImposto);
      return ValorTotal;
    }
  }
  