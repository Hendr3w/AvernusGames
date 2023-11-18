import { HttpClient, HttpHeaders } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Observable } from 'rxjs';
import { Cliente } from './models/Cliente';

const httpOptions = {
  headers: new HttpHeaders({
  'Content-Type' : 'application/json'
  })
  }


@Injectable({
  providedIn: 'root'
})
export class ClientesService {
  apiUrl = 'http://localhost:5000/cliente';
  constructor(private http: HttpClient) { }

  listar(): Observable<Cliente[]> {
    const url = `${this.apiUrl}/listar_clientes`;
    return this.http.get<Cliente[]>(url);
  }

  buscarCpf(cpf : string): Observable<Cliente> {
    const url = `${this.apiUrl}/buscar_cpf_do_cliente/${cpf}`;
    return this.http.get<Cliente>(url);
  }

  cadastrar(cliente : Cliente) : Observable<any> {
    const url = `${this.apiUrl}/cadastrar_cliente`;
    return this.http.post<Cliente>(url, cliente, httpOptions)
  }
  
  atualizar(cliente : Cliente) : Observable<any> {
    const url = `${this.apiUrl}/atualizar_cliente`;
    return this.http.put<Cliente>(url, cliente, httpOptions)
  }

  excluir(id : number) : Observable<any> {
    const url = `${this.apiUrl}/excluir_id/${id}`
    return this.http.delete<string>(url, httpOptions)
  }
  
}