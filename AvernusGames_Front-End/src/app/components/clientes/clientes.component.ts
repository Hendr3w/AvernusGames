import { Component, OnInit } from '@angular/core';
import { FormControl, FormGroup } from '@angular/forms';
import { Cliente } from 'src/app/models/Cliente';
import { ClientesService } from 'src/app/services/clientes.service';
import { ReactiveFormsModule } from '@angular/forms';

@Component({
  selector: 'app-clientes',
  templateUrl: './clientes.component.html',
  styleUrls: ['./clientes.component.css']
})
export class ClientesComponent implements OnInit {
  formulario : any 
  tituloFormulario : string = '';
  constructor(private clientesService : ClientesService){ } 
  ngOnInit(): void {
    this.tituloFormulario = 'Novo Cliente'
    this.formulario = new FormGroup({
      nome: new FormControl(null),
      cpf: new FormControl(null),
      email: new FormControl(null),
      senha : new FormControl(null),
      telefone: new FormControl(null),
      endereco : new FormGroup({
        pais : new FormControl(null),
        estado : new FormControl(null),
        cidade : new FormControl(null),
        rua : new FormControl(null),
        num : new FormControl(null)
      })
    })
  }

  enviarFormulario(): void {
    const cliente : Cliente = this.formulario.value;
    this.clientesService.cadastrar(cliente).subscribe(result => {
      alert('Cliente inserido com sucesso.');
    })
  } 

}
