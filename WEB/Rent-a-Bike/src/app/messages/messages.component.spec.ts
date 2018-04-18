import { async, ComponentFixture, TestBed } from '@angular/core/testing';

import { MessagesComponent } from './messages.component';
import { MessageService } from './message.service';

describe('MessagesComponent', () => {
  let component: MessagesComponent;
  let fixture: ComponentFixture<MessagesComponent>;
  let messageServiceStub: Partial<MessageService>;


  beforeEach(async(() => {
    messageServiceStub = {
      messages: ["[DateTime] SomeService: SomeMessage"]
    }

    TestBed.configureTestingModule({
      declarations: [MessagesComponent],
      providers: [{ provide: MessageService, useValue: messageServiceStub }]
    })
      .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(MessagesComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
