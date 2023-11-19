import { Component, OnInit } from '@angular/core';
import { FormControl, FormGroup } from '@angular/forms';

import { Cliente } from 'src/app/models/Cliente';
import { ClientesService } from 'src/app/clientes.service';

import { ReactiveFormsModule } from '@angular/forms';
import { InteropObservable } from 'rxjs';

import { Router } from '@angular/router';
import { AuthService } from 'src/app/auth-service.service';

@Component({
  selector: 'app-login-cliente',
  templateUrl: './login-cliente.component.html',
  styleUrls: ['./login-cliente.component.css']
})
export class LoginClienteComponent {
  formulario : any
  tituloFormulario : string = ''; 

    constructor(private clienteService : ClientesService, private router: Router, authService : AuthService){}

    ngOnInit() : void { 
      this.tituloFormulario = 'Login Cliente'
      this.formulario = new FormGroup({
        cpf: new FormControl(null),
        senha : new FormControl(null)
      })
    }

    enviarFormulario(): void { 
      const cliente : Cliente = this.formulario.value;

      this.clienteService.buscarCpf(cliente.cpf).subscribe({
        next : (value) => {
          var clienteTemp = value;
          if(clienteTemp.cpf == this.formulario.cpf){
            this.router.navigate(['/home']);
          } else{
            alert("Senha incorreta");
          }

        },
        error : err => {
            alert("Cpf não cadastrado");
        }
      })

    }


  }
  

