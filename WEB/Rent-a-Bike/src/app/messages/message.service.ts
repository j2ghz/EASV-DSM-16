import { Injectable } from '@angular/core';

@Injectable()
export class MessageService {
  messages: string[] = [];

  add(message: string) {
    this.messages.push(`[${new Date().toLocaleString()}] ` + message);
  }

  clear() {
    this.messages = [];
  }
}
