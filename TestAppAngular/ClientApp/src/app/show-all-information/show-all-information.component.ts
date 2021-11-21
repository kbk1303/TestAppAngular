import { HttpClient } from '@angular/common/http';
import { Component, Inject, OnInit } from '@angular/core';
import { Information } from '../interfaces/information';

@Component({
  selector: 'app-show-all-information',
  templateUrl: './show-all-information.component.html',
  styleUrls: ['./show-all-information.component.css']
})
export class ShowAllInformationComponent implements OnInit {

  public informations: Information[];

  constructor(http: HttpClient, @Inject('BASE_URL') baseUrl: string) {
    http.get<Information[]>(baseUrl + 'api/informations').subscribe(result => {
      this.informations = result;
    }, error => console.error(error));
  }

  ngOnInit() {
  }

}
