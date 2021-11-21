import { async, ComponentFixture, TestBed } from '@angular/core/testing';

import { ShowAllInformationComponent } from './show-all-information.component';

describe('ShowAllInformationComponent', () => {
  let component: ShowAllInformationComponent;
  let fixture: ComponentFixture<ShowAllInformationComponent>;

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      declarations: [ ShowAllInformationComponent ]
    })
    .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(ShowAllInformationComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
