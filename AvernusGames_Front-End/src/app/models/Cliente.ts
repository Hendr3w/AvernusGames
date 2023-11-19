import { Endereco } from "./Endereco";

export class Cliente {
    id: number = 0;
    nome: string ='';
    cpf: string = '';
    email: string ='';
    senha: string ='';
    telefone: string ='';
    endereco?: Endereco;
    enderecoId: number = 0;
}