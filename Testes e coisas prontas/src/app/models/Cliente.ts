import { Endereco } from "./Endereco";

export class Cliente {
    id: number = 0;
    nome: string | null = null;
    cpf: string | null = null;
    email: string | null = null;
    senha: string | null = null;
    telefone: string | null = null;
    endereco: Endereco | null = null;
    enderecoId: number = 0;
}