import { HttpClient, HttpHeaders } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Observable } from 'rxjs';
import { Game } from './models/Game';

const httpOptions = {
  headers: new HttpHeaders({
  'Content-Type' : 'application/json'
  })
}

@Injectable({
  providedIn: 'root'
})

export class GamesService {
  apiUrl = 'http://localhost:5000/game';
  constructor(private http: HttpClient) { }

  listar(): Observable<Game[]> {
    const url = `${this.apiUrl}/listar_game`;
    return this.http.get<Game[]>(url);
  }

  buscarNome(): Observable<Game[]> {
    const url = `${this.apiUrl}/buscar_game_nome`;
    return this.http.get<Game[]>(url);
  }

  cadastrar(game: Game): Observable<any> {
    const url = `${this.apiUrl}/cadastrar_game`;
    return this.http.post<Game>(url, game, httpOptions);
  }

  atualizar(game: Game): Observable<any> {
    const url = `${this.apiUrl}/alterar_game`;
    return this.http.put<Game>(url, game, httpOptions)
  }

  excluir(id : number) : Observable<any> {
    const url = `${this.apiUrl}/deletar_game_id${id}`
    return this.http.delete<string>(url, httpOptions)
  }
}