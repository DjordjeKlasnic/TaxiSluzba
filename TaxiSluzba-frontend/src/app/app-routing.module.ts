import {RouterModule, Routes} from '@angular/router';
import {NgModule} from '@angular/core';
import {RegisterComponent} from './components/account/register/register.component';
import {LoginComponent} from './components/account/login/login.component';
import {AccountComponent} from './components/account/account.component';

const appRoutes: Routes = [
  {path: '', redirectTo: 'account', pathMatch: 'full'},
  {path: 'register', component: RegisterComponent},
  {path: 'account', component: AccountComponent},
  {path: 'login', component: LoginComponent}

];

@NgModule({
  imports: [RouterModule.forRoot(appRoutes)],
  exports: [RouterModule]
})

export class AppRoutingModule {
}
