import {Component, OnInit} from '@angular/core';
import {SecurityUtil} from '../../utils/security-util';
import {NgxPermissionsService} from 'ngx-permissions';
import {Router} from '@angular/router';

@Component({
  selector: 'app-navbar',
  templateUrl: './navbar.component.html',
  styleUrls: ['./navbar.component.css']
})
export class NavbarComponent implements OnInit {
  isLoggedUser: boolean;

  constructor(private permissionsService: NgxPermissionsService, private router: Router) {
    this.isLoggedUser = true;
  }

  ngOnInit() {
    const perm = [];

    const role = SecurityUtil.getRole();
    perm.push(role);
    this.permissionsService.loadPermissions(perm);
    this.permissionsService.permissions$.subscribe((permisios) => {
    });

  }

  logout() {
    SecurityUtil.clearLocalStorage();
    this.router.navigate(['/account']);
  }
}
