import { async, ComponentFixture, TestBed } from '@angular/core/testing';

import { UsuarioServiceComponent } from './usuario-service.component';

describe('UsuarioServiceComponent', () => {
  let component: UsuarioServiceComponent;
  let fixture: ComponentFixture<UsuarioServiceComponent>;

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      declarations: [ UsuarioServiceComponent ]
    })
    .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(UsuarioServiceComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
