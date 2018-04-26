import { Component, OnInit } from '@angular/core';
import { AuthService } from '../auth.service';

@Component({
  selector: 'app-login-status',
  templateUrl: './login-status.component.html',
  styleUrls: ['./login-status.component.css']
})
export class LoginStatusComponent implements OnInit {
  loggedIn: boolean;
  currentUser: string;
  constructor(private authService: AuthService) {
    this.loggedIn = authService.isLoggedIn();
    this.currentUser = authService.getUser();
  }

  ngOnInit() {
  }

}
