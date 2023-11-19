import { Endereco } from "./Endereco";

export class Funcionario {
    id: number = 0;
    nome: string = '';
    cpf: string = '';
    email: string = '';
    senha: string = '';
    telefone: string = '';
    endereco?: Endereco;
    enderecoId: number = 0;
    valorHora: number = 0;
    nHoras: number = 0;
  }
  