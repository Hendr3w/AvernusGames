import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';

import { CommonModule } from '@angular/common';
import { HttpClientModule } from '@angular/common/http';

import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';

import { ReactiveFormsModule } from '@angular/forms';
import { ModalModule } from 'ngx-bootstrap/modal';

import { ClientesService } from './services/clientes.service';
import { ClientesComponent } from './components/clientes/clientes.component';

import { VendasService } from './services/vendas.service';
import { VendasComponent } from './components/vendas/vendas.component';

import { PreLoginComponent } from './components/pre-login/pre-login.component';
import { LoginClienteComponent } from './components/login-cliente/login-cliente.component';

import { FuncionariosService } from './services/funcionarios.service';
import { FuncionariosComponent } from './components/funcionarios/funcionario.component';

import { FornecedoresService } from './services/fornecedores.service';
import { FornecedoresComponent } from './components/fornecedores/fornecedores.component';
import { HomeComponent } from './components/home/home.component';



@NgModule({
  declarations: [
    AppComponent,
    ClientesComponent,
    VendasComponent,
    PreLoginComponent,
    LoginClienteComponent,
    FornecedoresComponent,
    HomeComponent,
    FuncionariosComponent
  ],
  imports: [
    BrowserModule,
    AppRoutingModule,
    CommonModule,
    HttpClientModule,
    ReactiveFormsModule,
    ModalModule.forRoot()
  ],
  providers: [HttpClientModule, ClientesService, VendasService, FornecedoresService, FuncionariosService],
  bootstrap: [AppComponent]
})
export class AppModule { }
