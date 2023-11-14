import { Endereco } from "./Endereco";

export class Funcionario {
    id: number = 0;
    nome: string | null = null;
    cpf: string | null = null;
    email: string | null = null;
    senha: string | null = null;
    phone: string | null = null;
    endereco: Endereco | null = null;
    enderecoId: number = 0;
    valorHora: number = 0;
    nHoras: number = 0;
  }
  