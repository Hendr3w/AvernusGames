import { Component, OnInit } from '@angular/core';
import { FormControl, FormGroup } from '@angular/forms';
import { Game } from 'src/app/models/Game';
import { GamesService } from 'src/app/games.service';
import { Observer } from 'rxjs';
import { ReactiveFormsModule } from '@angular/forms';

@Component({
  selector: 'app-games',
  templateUrl: './games.component.html',
  styleUrls: ['./games.component.css']
})

export class GamesComponent {
  formulario : any 
  tituloFormulario : string = '';
  constructor(private gamesService : GamesService){ } 
  ngOnInit(): void {
    this.tituloFormulario = 'Novo Game'
    this.formulario = new FormGroup({
      nome: new FormControl(null),
      valorcompra: new FormControl(null),
      markup: new FormControl(null),
      descricao: new FormControl(null),
      categoria: new FormGroup({
        categoria: new FormControl(null),
        desc: new FormControl(null)
      }),
      fornecedor: new FormGroup({
        nome: new FormControl(null),
        cnpf: new FormControl(null),
        email: new FormControl(null),
        telefone: new FormControl(null),
        endereco : new FormGroup({
          pais : new FormControl(null),
          estado : new FormControl(null),
          cidade : new FormControl(null),
          rua : new FormControl(null),
          num : new FormControl(null)
        })
      }),
      genero: new FormGroup({
        nome: new FormControl(null),
        desc: new FormControl(null)
      }),
      desenvolvedor: new FormGroup({
        estudio: new FormControl(null),
        nomedev: new FormControl(null)
      }),
      plataforma: new FormGroup({
        nome: new FormGroup(null),
        desc: new FormGroup(null)
      })
    })
  }


  
  enviarFormulario(): void {
    const game : Game = this.formulario.value;
    const observer: Observer<Game> = {
      next(_result): void {
        alert('Game salvo com sucesso.');
      },
      error(_error): void {
        alert('Erro ao salvar!');
      },
      complete(): void {
      },
    };
    this.gamesService.cadastrar(game).subscribe(observer);
    /*this.gamesService.cadastrar(game).subscribe(result => {
      alert('Game inserido com sucesso.');
    })*/
  } 
}
