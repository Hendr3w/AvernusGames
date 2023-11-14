import { Component, OnInit } from '@angular/core';
import { FormControl, FormGroup } from '@angular/forms';
import { CarrosService } from 'src/app/carros.service';
import { Carro } from 'src/app/Carro';

@Component({
  selector: 'app-carros',
  templateUrl: './carros.component.html',
  styleUrls: ['./carros.component.css']
})
export class CarrosComponent implements OnInit {
  formulario: any;
  tituloFormulario: string = '';
  
  constructor(private carrosService : CarrosService) { }

  ngOnInit(): void {
    this.tituloFormulario = 'Novo Carro';
    this.formulario = new FormGroup({
      placa: new FormControl(null),
      descricao: new FormControl(null)
    })
  }
  enviarFormulario(): void {
    const carro : Carro = this.formulario.value;
    this.carrosService.cadastrar(carro).subscribe(result => {
      alert('Carro inserido com sucesso.');
    })
  } 
}
