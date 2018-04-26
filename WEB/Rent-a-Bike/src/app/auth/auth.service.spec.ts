import { TestBed, inject } from '@angular/core/testing';

import { AuthService } from './auth.service';
import { MessageService } from '../messages/message.service';

describe('AuthService', () => {
  let messageServiceStub: Partial<MessageService>;

  beforeEach(() => {
    messageServiceStub = {
      messages: ['[DateTime] SomeService: SomeMessage']
    };

    TestBed.configureTestingModule({
      providers: [AuthService, { provide: MessageService, useValue: messageServiceStub }]
    });
  });

  it('should be created', inject([AuthService], (service: AuthService) => {
    expect(service).toBeTruthy();
  }));
});
