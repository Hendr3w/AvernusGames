import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';

import { CommonModule } from '@angular/common';
import { HttpClientModule } from '@angular/common/http';

import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';

import { ReactiveFormsModule } from '@angular/forms';
import { ModalModule } from 'ngx-bootstrap/modal';

import { ClientesService } from './clientes.service';
import { ClientesComponent } from './components/clientes/clientes.component';

import { VendasService } from './vendas.service';
import { VendasComponent } from './components/vendas/vendas.component';

import { PreLoginComponent } from './components/pre-login/pre-login.component';
import { LoginClienteComponent } from './components/login-cliente/login-cliente.component';

import { FornecedoresService } from './fornecedores.service';
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
    HomeComponent
  ],
  imports: [
    BrowserModule,
    AppRoutingModule,
    CommonModule,
    HttpClientModule,
    ReactiveFormsModule,
    ModalModule.forRoot()
  ],
  providers: [HttpClientModule, ClientesService, VendasService, FornecedoresService],
  bootstrap: [AppComponent]
})
export class AppModule { }
