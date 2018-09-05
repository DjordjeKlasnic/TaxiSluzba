import {Component, OnInit} from '@angular/core';
import {UserService} from '../../../services/user.service';

@Component({
  selector: 'app-login',
  templateUrl: './login.component.html',
  styleUrls: ['./login.component.css']
})
export class LoginComponent implements OnInit {

  public username: string;
  public password: string;

  constructor(private userService: UserService) {
  }

  ngOnInit() {
  }

  login() {
    console.log(this.username + ',' + this.password);
    this.userService.login(this.username, this.password).subscribe(user => {
      console.log(user);
    });
  }


}
