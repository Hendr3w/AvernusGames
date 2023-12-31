import { Component, OnInit, importProvidersFrom } from '@angular/core';
import { FormControl, FormGroup } from '@angular/forms';
import { Funcionario } from 'src/app/models/Funcionario';
import { FuncionariosService } from 'src/app/services/funcionarios.service';
import { ReactiveFormsModule } from '@angular/forms'; 

@Component({
  selector: 'app-funcionarios',
  templateUrl: './funcionarios.component.html',
  styleUrls: ['./funcionarios.component.css']
})
export class FuncionariosComponent implements OnInit {
  formulario: any;
  tituloFormulario: string = '';

  constructor(private funcionarioService: FuncionariosService) {}

  ngOnInit(): void {
    this.tituloFormulario = 'Novo Funcionário';
    this.formulario = new FormGroup({
      nome: new FormControl(null),
      cpf: new FormControl(null),
      email: new FormControl(null),
      senha: new FormControl(null),
      telefone: new FormControl(null),
      valorHora: new FormControl(null),
      nHoras: new FormControl(null),
      endereco : new FormGroup({
        pais : new FormControl(null),
        estado : new FormControl(null),
        cidade : new FormControl(null),
        rua : new FormControl(null),
        num : new FormControl(null)
      }),
    });
  }

  enviarFormulario(): void {
    const funcionario: Funcionario = this.formulario.value;
    this.funcionarioService.cadastrar(funcionario).subscribe(result => {
      alert('Funcionário inserido com sucesso.')
    })
  }
}
