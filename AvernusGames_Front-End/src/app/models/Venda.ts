import { Cliente } from "./Cliente";

export class Venda {
    id: number = 0;
    cliente: Cliente = new Cliente();
    clienteId: number = 0;
    nf?: string;
  }
  