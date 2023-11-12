import { Desenvolvedor } from "./Desenvolvedor";
import { Genero } from "./Genero";
import { Plataforma } from "./Plataforma";
import { Produto } from "./Produto";

export class Game extends Produto {
    genero: Genero | null = null;
    generoId: number = 0;
    releaseDate: Date | null = null;
    desenvolvedor: Desenvolvedor | null = null;
    desenvolvedorId: number = 0;
    plataforma: Plataforma | null = null;
    plataformaId: number = 0;
  
    CalcValorVenda(ValorCompra: number, Markup: number): number {
      const ValorVenda: number = ValorCompra * (1 + Markup);
      const taxaImposto: number = 0.15; // 15% de imposto
      const ValorTotal: number = ValorVenda * (1 + taxaImposto);
      return ValorTotal;
    }
  }
  