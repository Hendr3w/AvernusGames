import { Component, OnInit } from '@angular/core';
import { FormControl, FormGroup } from '@angular/forms';
import { Fornecedor } from 'src/app/models/Fornecedor';
import { FornecedoresService } from 'src/app/services/fornecedores.service';
import { ReactiveFormsModule } from '@angular/forms';

@Component({
  selector: 'app-fornecedores',
  templateUrl: './fornecedores.component.html',
  styleUrls: ['./fornecedores.component.css']
})
export class FornecedoresComponent implements OnInit {
  formulario: any;
  tituloFormulario: string = '';

  constructor(private fornecedorService : FornecedoresService) {} 

  ngOnInit(): void {
    this .tituloFormulario = 'Novo Fornecedor';
    this.formulario = new FormGroup({
      cnpj: new FormControl(null),
      nome: new FormControl(null),
      email: new FormControl(null),
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
    const fornecedor : Fornecedor = this.formulario.value;
    this.fornecedorService.cadastrar(fornecedor).subscribe(result => {
      alert('Fornecedor Cadastrado');
    })
  } 
}