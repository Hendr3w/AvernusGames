import { Produto } from "./Produto";

export class Vestimenta extends Produto {
    
    public CalcValorVenda(ValorCompra: number, Markup: number): number {
        const ValorVenda: number = ValorCompra * (1 + Markup);
        const taxaImposto: number = 0.19; // 19% de imposto
        const ValorTotal: number = ValorVenda * (1 + taxaImposto);
        return ValorTotal;
      }

}