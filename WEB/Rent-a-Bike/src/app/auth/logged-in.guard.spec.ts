import { TestBed, async, inject } from '@angular/core/testing';

import { LoggedInGuard } from './logged-in.guard';
import { AuthService } from './auth.service';

describe('LoggedInGuard', () => {
  let authServiceStub: Partial<AuthService>;

  beforeEach(() => {
    authServiceStub = {
      isLoggedIn: () => true
    };

    TestBed.configureTestingModule({
      providers: [LoggedInGuard, { provide: AuthService, useValue: authServiceStub }]
    });
  });

  it('should be true when service is true', inject([LoggedInGuard], (guard: LoggedInGuard) => {
    expect(guard).toBeTruthy();
  }));
});
