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
import { FornecedorHomeComponent } from './components/fornecedor-home/fornecedor-home.component';
import { FuncionarioHomeComponent } from './components/funcionario-home/funcionario-home.component';
import { GamesHomeComponent } from './components/games-home/games-home.component';
import { LoginFuncionarioComponent } from './components/login-funcionario/login-funcionario.component';




const routes: Routes = [
  {path: 'clientes', component:ClientesComponent}, 
  {path: 'inicio', component:PreLoginComponent},
  {path: 'login_cliente', component:LoginClienteComponent},
  {path: 'vendas', component:VendasComponent},
  {path: 'games', component:GamesComponent},
  {path: 'home', component:HomeComponent},
  {path: 'funcionarios', component:FuncionariosComponent},
  {path: 'fornecedores', component:FornecedoresComponent},
  {path: 'fornecedor_home', component:FornecedorHomeComponent},
  {path: 'funcionario_home', component:FuncionarioHomeComponent},
  {path: 'game_home', component:GamesHomeComponent},
  {path: 'login_funcionario', component:LoginFuncionarioComponent}
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
