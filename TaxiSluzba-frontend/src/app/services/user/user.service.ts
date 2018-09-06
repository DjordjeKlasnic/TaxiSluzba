import { Injectable } from '@angular/core';
import {HttpClient, HttpHeaders} from '@angular/common/http';
import {User} from '../../model/user';

@Injectable({
  providedIn: 'root'
})
export class UserService {

  constructor(private http: HttpClient) { }

  login(username: string, password: string) {
    const loginObj = {'username': username, 'password': password};
    return this.http.get('/api/users');
  }

  register(user: User) {
    return this.http.post('/api/users', user);
  }

}
