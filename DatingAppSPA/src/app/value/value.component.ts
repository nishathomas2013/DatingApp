import { Component, OnInit } from '@angular/core';
import { HttpClient } from '@angular/common/http';

@Component({
  selector: 'app-value',
  templateUrl: './value.component.html',
  styleUrls: ['./value.component.css']
})
export class ValueComponent implements OnInit {

  constructor(private http: HttpClient) { }
  values: any;

  ngOnInit() {
    this.getValues();
  }

  getValues(){
    this.http.get('http://localhost:8000/api/Values').subscribe(response => {
      this.values = response;
    }, err => {
      console.log(err);
    });
  }

}
