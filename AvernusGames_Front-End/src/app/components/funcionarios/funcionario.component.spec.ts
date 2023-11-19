import { ComponentFixture, TestBed } from '@angular/core/testing';
import { FuncionariosComponent } from './funcionario.component';

describe('FuncionariosComponent', () => {
  let component: FuncionariosComponent;
  let fixture: ComponentFixture<FuncionariosComponent>;

  beforeEach(() => {
    TestBed.configureTestingModule({
      declarations: [FuncionariosComponent]
    });
    fixture = TestBed.createComponent(FuncionariosComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
