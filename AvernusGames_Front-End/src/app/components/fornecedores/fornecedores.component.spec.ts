import { ComponentFixture, TestBed } from '@angular/core/testing';

import { FornecedoresComponent } from './fornecedores.component';

describe('FornecedoresComponent', () => {
  let component: FornecedoresComponent;
  let fixture: ComponentFixture<FornecedoresComponent>;

  beforeEach(() => {
    TestBed.configureTestingModule({
      declarations: [FornecedoresComponent]
    });
    fixture = TestBed.createComponent(FornecedoresComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
