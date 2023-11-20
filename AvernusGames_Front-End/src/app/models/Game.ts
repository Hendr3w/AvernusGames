import { Desenvolvedor } from "./Desenvolvedor";
import { Fornecedor } from "./Fornecedor";
import { Genero } from "./Genero";
import { Plataforma } from "./Plataforma";
export class Game {
    id: number = 0;
    nome: string = '';
    descricao: string = '';
    valorCompra: number = 0;
    markup: number = 0;
    fornecedor: Fornecedor = new Fornecedor();
    fornecedorId: number = 0;
    genero: Genero = new Genero;
    generoId: number = 0;
    desenvolvedor: Desenvolvedor = new Desenvolvedor();
    desenvolvedorId: number = 0;
    plataforma: Plataforma = new Plataforma();
    plataformaId: number = 0;
    
  }
  