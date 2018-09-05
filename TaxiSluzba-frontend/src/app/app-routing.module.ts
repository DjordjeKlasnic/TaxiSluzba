import {RouterModule, Routes} from '@angular/router';
import {NgModule} from '@angular/core';
import {RegisterComponent} from './components/account/register/register.component';
import {LoginComponent} from './components/account/login/login.component';

const appRoutes: Routes = [
  {path: '', redirectTo: '/login', pathMatch: 'full'},
  {path: 'login', component: LoginComponent},
  {path: 'register', component: RegisterComponent}

];

@NgModule({
  imports: [RouterModule.forRoot(appRoutes)],
  exports: [RouterModule]
})

export class AppRoutingModule {
}
