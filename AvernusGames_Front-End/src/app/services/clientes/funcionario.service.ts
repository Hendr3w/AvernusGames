import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { Observable } from 'rxjs';
import { Funcionario } from 'src/app/models/funcionario.model';

@Injectable({
  providedIn: 'root'
})
export class FuncionarioService {
  apiUrl = 'http://localhost:5000/Funcionario'

  constructor(private http: HttpClient) {}

  cadastrarFuncionario(novoFuncionario: Funcionario): Observable<any> {
    return this.http.post(`${this.apiUrl}/funcionario`, novoFuncionario);
  }

  listarFuncionarios(): Observable<Funcionario[]> {
    return this.http.get<Funcionario[]>(`${this.apiUrl}/funcionario`);
  }
}
