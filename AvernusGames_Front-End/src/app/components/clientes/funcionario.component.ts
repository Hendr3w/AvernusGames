import { Component, OnInit } from '@angular/core';
import { FormControl, FormGroup } from '@angular/forms';
import { Funcionario } from 'src/app/models/funcionario.model';
import { FuncionarioService } from 'src/app/services/funcionario.service';

@Component({
  selector: 'app-funcionarios',
  templateUrl: './funcionarios.component.html',
  styleUrls: ['./funcionarios.component.css']
})
export class FuncionariosComponent implements OnInit {
  formulario: FormGroup;
  tituloFormulario: string = '';

  constructor(private funcionarioService: FuncionarioService) {}

  ngOnInit(): void {
    this.tituloFormulario = 'Novo Funcionário';
    this.formulario = new FormGroup({
      nome: new FormControl(null),
      cpf: new FormControl(null),
      email: new FormControl(null),
      senha: new FormControl(null),
      telefone: new FormControl(null),
      endereco: new FormGroup({
      }),
      enderecoId: new FormControl(null),
      valorHora: new FormControl(null),
      nHoras: new FormControl(null)
    });
  }

  enviarFormulario(): void {
    const funcionario: Funcionario = this.formulario.value;
    this.funcionarioService.cadastrarFuncionario(funcionario).subscribe(result => {
      alert('Funcionário cadastrado com sucesso.');
    });
  }
}