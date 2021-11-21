import { HttpClient } from '@angular/common/http';
import { Component, Inject, OnInit } from '@angular/core';
import { FormBuilder, Validators } from '@angular/forms';
import { Information } from '../interfaces/information';

@Component({
  selector: 'app-show-information',
  templateUrl: './show-information.component.html',
  styleUrls: ['./show-information.component.css']
})
export class ShowInformationComponent implements OnInit {
  information: Information;
  informationForm = this.fb.group({
    informationId: ['', Validators.required],
  });

  constructor(private fb: FormBuilder, private http: HttpClient, @Inject('BASE_URL') private baseUrl: string) { }

  ngOnInit() {
  }

  onSubmit() {
    
    const id = this.informationForm.get("informationId").value;
    console.log("submit clicked.. value entered: " + id);
    this.http.get<Information>(this.baseUrl + 'api/informations/'+id).subscribe(result => {
      this.information = result;
    }, error => console.error(error));
  }

}
