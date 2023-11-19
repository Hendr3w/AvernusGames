import { Endereco } from "./Endereco";

export class Fornecedor {
    id: number = 0;
    cnpj: string = '';
    nome: string = '';
    email: string = '';
    telefone: string = '';
    endereco: Endereco = new Endereco();
    enderecoId: number = 0;
  }
  