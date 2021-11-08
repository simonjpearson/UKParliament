import { Injectable } from '@angular/core';
import * as $ from 'jquery';
import { Person } from './person.model';
import { HttpClient } from "@angular/common/http";

@Injectable({
  providedIn: 'root'
})
export class PersonService {
  constructor(private http: HttpClient) {
  }
  readonly _baseUrl = "https://localhost:5001/api/person";
  formData: Person = new Person();
  list: Person[];
  postPerson() {
    if (this.formData.dateOfBirthString.length > 0) {
      var dt = new Date(this.formData.dateOfBirthString);
      this.formData.dateOfBirth = dt;
    }
    return this.http.post(this._baseUrl, this.formData);
  }
  putPerson() {
    if (this.formData.dateOfBirthString.length > 0) {
      var dt = new Date(this.formData.dateOfBirthString);
      this.formData.dateOfBirth = dt;
    }
    return this.http.put(this._baseUrl +'/' + this.formData.id, this.formData);
  }
  deletePerson(id: number) {
    return this.http.delete(this._baseUrl + '/' + id);
  }
  refreshList() {
    this.http.get(this._baseUrl)
      .toPromise()
      .then(res => this.list = res as Person[]);
  }

}
