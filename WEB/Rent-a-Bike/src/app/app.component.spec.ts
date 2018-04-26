import { TestBed, async } from '@angular/core/testing';
import { RouterTestingModule } from '@angular/router/testing';
import { AppComponent } from './app.component';
import { MessagesComponent } from './messages/messages.component';
import { Component } from '@angular/core';

describe('AppComponent', () => {
  beforeEach(async(() => {

    @Component({ selector: 'app-messages', template: '' })
    class MessagesStubComponent { }

    @Component({ selector: 'app-login-status', template: '' })
    class LoginStatusStubComponent { }

    TestBed.configureTestingModule({
      declarations: [
        AppComponent,
        MessagesStubComponent,
        LoginStatusStubComponent
      ],
      imports: [
        RouterTestingModule
      ]
    }).compileComponents();
  }));

  it('should create the app', async(() => {
    const fixture = TestBed.createComponent(AppComponent);
    const app = fixture.debugElement.componentInstance;
    expect(app).toBeTruthy();
  }));
  it(`should have as title 'app'`, async(() => {
    const fixture = TestBed.createComponent(AppComponent);
    const app = fixture.debugElement.componentInstance;
    expect(app.title).toEqual('app');
  }));
  it('should render title in a h1 tag', async(() => {
    const fixture = TestBed.createComponent(AppComponent);
    fixture.detectChanges();
    const compiled = fixture.debugElement.nativeElement;
    expect(compiled.querySelector('h1').textContent).toContain('app');
  }));
});
