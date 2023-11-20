import { Component, OnInit } from '@angular/core';
import { FormControl, FormGroup } from '@angular/forms';

import { Game } from 'src/app/models/Game';
import { GamesService } from 'src/app/services/games.service';

import { ReactiveFormsModule } from '@angular/forms';
import { InteropObservable } from 'rxjs';

import { Router } from '@angular/router';
import { AuthService } from 'src/app/services/auth-service.service';

@Component({
  selector: 'app-games-home',
  templateUrl: './games-home.component.html',
  styleUrls: ['./games-home.component.css']
})
export class GamesHomeComponent implements OnInit {
  games : Game[] = []

  constructor(private gamesService : GamesService, private router: Router) { }

  ngOnInit(): void {
    this.carregarGames();
  }

  carregarGames(): void {
    this.gamesService.listar().subscribe((games: Game[]) => {
      this.games = games;
    });
  }

  adicionar(): void {
    this.router.navigate(['/games']);
  }

  excluir(id: number): void {
    this.gamesService.excluir(id).subscribe(() => {
      // A exclusão foi concluída com sucesso, agora carregamos os jogos novamente
      this.carregarGames();
    });
  }
}