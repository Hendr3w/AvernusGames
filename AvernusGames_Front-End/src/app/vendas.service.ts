import { HttpClient, HttpHeaders } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Observable } from 'rxjs';
import { Venda } from './models/Venda';

const httpOptions = {
  headers: new HttpHeaders({
  'Content-Type' : 'application/json'
  })
  }


@Injectable({
  providedIn: 'root'
})
export class VendasService {
  apiUrl = 'http://localhost:5000/venda';
  constructor(private http: HttpClient) { }

  listar(): Observable<Venda[]> {
    const url = `${this.apiUrl}/listar_vendas`;
    return this.http.get<Venda[]>(url);
  }

  buscarNf(nf: string): Observable<Venda> {
    const url = `${this.apiUrl}/buscar_cpf_do_venda/${nf}`;
    return this.http.get<Venda>(url);
  }

  cadastrar(venda : Venda) : Observable<any> {
    const url = `${this.apiUrl}/cadastrar_venda`;
    return this.http.post<Venda>(url, Venda, httpOptions)
  }
 
  //Talvez não seja usado. 
  atualizar(venda : Venda) : Observable<any> {
    const url = `${this.apiUrl}/atualizar_venda`;
    return this.http.put<Venda>(url, Venda, httpOptions)
  }

  
}