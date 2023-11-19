import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { ClientesComponent } from './components/clientes/clientes.component';
import { PreLoginComponent } from './components/pre-login/pre-login.component';
import { LoginClienteComponent } from './components/login-cliente/login-cliente.component';
import { VendasComponent } from './components/vendas/vendas.component';
import { GamesComponent } from'./components/games/games.component';
import { HomeComponent } from './components/home/home.component';
import { FuncionariosComponent } from './components/funcionarios/funcionarios.component';
import { FornecedoresComponent } from './components/fornecedores/fornecedores.component';

const routes: Routes = [
  {path: 'clientes', component:ClientesComponent}, 
  {path: 'inicio', component:PreLoginComponent},
  {path: 'login_cliente', component:LoginClienteComponent},
  {path: 'vendas', component:VendasComponent},
  {path: 'games', component:GamesComponent},
  {path: 'home', component:HomeComponent},
  {path: 'funcionarios', component:FuncionariosComponent},
  {path: 'fornecedores', component:FornecedoresComponent}
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
