import { Component, OnInit } from '@angular/core';
import { HttpClient } from '@angular/common/http';

@Component({
  selector: 'app-value',
  templateUrl: './value.component.html',
  styleUrls: ['./value.component.css']
})
export class ValueComponent implements OnInit {
  values: any;

  constructor(private httpClient: HttpClient) { }

  ngOnInit() {
   this.getValues();
   console.log(this.values);
  }

  getValues() {
    this.httpClient.get('http://localhost:5000/api/values').subscribe(response => {
      this.values = response;
      console.log(this.values);
    }, error => {
      console.log(error);
    });
  }
}
