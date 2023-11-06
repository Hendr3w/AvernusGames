import { Endereco } from "./Endereco";

export class Fornecedor {
    id: number = 0;
    cnpj: string | null = null;
    nome: string | null = null;
    email: string | null = null;
    telefone: string | null = null;
    endereco: Endereco | null = null;
    enderecoId: number = 0;
  }
  