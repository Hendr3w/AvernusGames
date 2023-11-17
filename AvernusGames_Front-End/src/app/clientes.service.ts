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
  
}