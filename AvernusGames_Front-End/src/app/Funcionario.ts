// Modelo Cliente
export class Cliente {
    ClienteId: number = 0;
    Nome: string = '';
    CPF: string = '';
    Email: string = '';
    Senha: string = '';
    Telefone: string = '';
}

// Modelo Funcionario
export class Funcionario {
    FuncionarioId: number = 0;
    Nome: string = '';
    Cargo: string = '';
    Email: string = '';
    Senha: string = '';
    Telefone: string = '';
}

export class FuncionarioController {
    // Exemplo de método que interage com um cliente
    cadastrarCliente(novoCliente: Cliente): void {
        // Lógica de cadastro de cliente aqui
        console.log('Cliente cadastrado:', novoCliente);
    }

    // Exemplo de método que interage com um funcionário
    cadastrarFuncionario(novoFuncionario: Funcionario): void {
        // Lógica de cadastro de funcionário aqui
        console.log('Funcionário cadastrado:', novoFuncionario);
    }
}

const controller = new FuncionarioController();

// Criando um novo cliente e funcionário
const novoCliente = new Cliente();
novoCliente.Nome = 'João';
novoCliente.Email = 'joao@email.com';
novoCliente.CPF = '123.456.789-00';

const novoFuncionario = new Funcionario();
novoFuncionario.Nome = 'Maria';
novoFuncionario.Email = 'maria@email.com';
novoFuncionario.Cargo = 'Desenvolvedor';

// Chamando os métodos do controlador
controller.cadastrarCliente(novoCliente);
controller.cadastrarFuncionario(novoFuncionario);
