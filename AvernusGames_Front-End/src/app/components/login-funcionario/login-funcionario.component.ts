import { Component, OnInit } from '@angular/core';
import { FormControl, FormGroup } from '@angular/forms';

import { Funcionario } from 'src/app/models/Funcionario';
import { FuncionariosService } from 'src/app/services/funcionarios.service';

import { ReactiveFormsModule } from '@angular/forms';
import { InteropObservable } from 'rxjs';

import { Router } from '@angular/router';
import { AuthService } from 'src/app/services/auth-service.service';


@Component({
  selector: 'app-login-funcionario',
  templateUrl: './login-funcionario.component.html',
  styleUrls: ['./login-funcionario.component.css']
})
export class LoginFuncionarioComponent {
  formulario : any
  tituloFormulario : string = '';

  constructor(private FuncionarioService : FuncionariosService, private router: Router, authService : AuthService){}

  ngOnInit() : void { 
    this.tituloFormulario = 'Login Funcionario'
    this.formulario = new FormGroup({
      cpf: new FormControl(null),
      senha : new FormControl(null)
    })
  }

  enviarFormulario(): void {
    const funcionario: Funcionario = this.formulario.value;
  
    this.FuncionarioService.buscarCpf(funcionario.cpf).subscribe({
      next: (value) => {
        var formulario = value;
        if (formulario.senha == funcionario.senha) {
          this.router.navigate(['/home']);
        } else {
          alert("Senha incorreta");
        }
      },
      error: (err) => {
        alert("Cpf não cadastrado");
      }
    });
  }
  
}
