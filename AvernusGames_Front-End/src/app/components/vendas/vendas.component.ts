import { Component, OnInit } from '@angular/core';
import { FormControl, FormGroup } from '@angular/forms';
import { Venda } from 'src/app/models/Venda';
import { VendasService } from 'src/app/vendas.service';
import { ReactiveFormsModule } from '@angular/forms';

@Component({
  selector: 'app-vendas',
  templateUrl: './vendas.component.html',
  styleUrls: ['./vendas.component.css']
})
export class VendasComponent implements OnInit {
  formulario : any
  tituloFormulario : string = " ";
  constructor(private vendasService : VendasService){ }
  ngOnInit(): void {
    this.tituloFormulario = "Nova Venda"
    this.formulario = new FormGroup({
      clienteCpf : new FormControl(null),
      

    })
  }

}
