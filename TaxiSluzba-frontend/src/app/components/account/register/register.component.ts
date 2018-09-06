import { Component, OnInit } from '@angular/core';
import {User} from '../../../model/user';
import {UserService} from '../../../services/user/user.service';
import {MessageService} from '../../../services/message.service';
import {Router} from '@angular/router';

@Component({
  selector: 'app-register',
  templateUrl: './register.component.html',
  styleUrls: ['./register.component.css']
})
export class RegisterComponent implements OnInit {

  user: User;
  constructor(private userService: UserService, private messageService: MessageService, private router: Router) { }

  ngOnInit() {
    this.user = new User();
  }

  registerUser() {

      this.user.role = 'Custome';
      this.userService.register(this.user).subscribe(() => {
        this.messageService.sendMessage('You have been successfully registered. Please log in.');
        this.router.navigate(['/home']);
      });

  }
}
