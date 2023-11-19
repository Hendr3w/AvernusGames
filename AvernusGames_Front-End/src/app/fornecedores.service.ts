import { HttpClient, HttpHeaders } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Observable } from 'rxjs';
import { Fornecedor } from './models/Fornecedor';

const httpOptions = {
  headers: new HttpHeaders({
    'Content-Type' : 'application/json'
  })
}

@Injectable({
  providedIn: 'root'
})
export class FornecedoresService {
  apiUrl = 'http://localhost:5000/fornecedor';
  constructor(private http: HttpClient) { }

  listar(): Observable<Fornecedor[]> {
    const url = `${this.apiUrl}/listar_fornecedor`;
    return this.http.get<Fornecedor[]>(url);
  }
  buscar(id: number): Observable<Fornecedor> {
    const url = `${this.apiUrl}/buscar_fornecedor_por_id/${id}`;
    return this.http.get<Fornecedor>(url);
  }

  cadastrar(fornecedor: Fornecedor): Observable<any> {
    const url = `${this.apiUrl}/cadastrar_fornecedor`;
    return this.http.post<Fornecedor>(url, fornecedor, httpOptions);
  }

  alterar(fornecedor: Fornecedor): Observable<any> {
    const url = `${this.apiUrl}/alterar_fornecedor`;
    return this.http.put<Fornecedor>(url, fornecedor, httpOptions);
  }

  excluir_(id: number): Observable<any> {
    const url = `${this.apiUrl}/excluir_fornecedor_por_id/${id}`;
    return this.http.delete<string>(url, httpOptions);
  }
}