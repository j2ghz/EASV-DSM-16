import { Injectable } from '@angular/core';
import { MessageService } from '../messages/message.service';

@Injectable()
export class AuthService {

  constructor(private messageService: MessageService) { }

  login(user: string, password: string): boolean {
    if (user === 'user' && password === 'password') {
      this.log('Logged in: ' + user);
      localStorage.setItem('username', user);
      return true;
    }
    this.log('Failed to log in: ' + user);
    return false;
  }

  logout(): void {
    localStorage.removeItem('username');
  }

  getUser(): string {
    console.log('Check current user');
    return localStorage.getItem('username');
  }

  isLoggedIn(): boolean {
    console.log('Check logged in');
    return this.getUser() !== null;
  }

  private log(message: string) {
    this.messageService.add('AuthService: ' + message);
  }
}
