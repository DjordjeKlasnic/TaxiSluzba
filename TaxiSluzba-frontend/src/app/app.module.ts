import {BrowserModule} from '@angular/platform-browser';
import {NgModule} from '@angular/core';

import {AppComponent} from './app.component';
import {LoginComponent} from './components/account/login/login.component';
import {RegisterComponent} from './components/account/register/register.component';
import {FormsModule} from '@angular/forms';
import {RouterModule} from '@angular/router';
import {HttpClientModule} from '@angular/common/http';
import {AppRoutingModule} from './app-routing.module';
import {UserService} from './services/user/user.service';
import { AccountComponent } from './components/account/account.component';
import {ToastrModule} from 'ngx-toastr';
import {NavbarComponent} from './components/navbar/navbar.component';

@NgModule({
  declarations: [
    AppComponent,
    LoginComponent,
    RegisterComponent,
    AccountComponent,
    NavbarComponent
  ],
  imports: [
    ToastrModule.forRoot({
      preventDuplicates: true,
    }),
    BrowserModule,
    RouterModule,
    BrowserModule,
    FormsModule,
    HttpClientModule,
    AppRoutingModule
  ],
  providers: [ UserService],
  bootstrap: [AppComponent]
})
export class AppModule {
}
