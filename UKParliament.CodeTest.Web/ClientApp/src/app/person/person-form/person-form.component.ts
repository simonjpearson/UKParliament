import { Component, OnInit } from '@angular/core';
import { PersonService } from '../../shared/person.service';
import { NgForm } from '@angular/forms';
import { Person } from '../../shared/person.model';

@Component({
  selector: 'app-person-form',
  templateUrl: './person-form.component.html',
  styles: []
})
export class PersonFormComponent implements OnInit {

  constructor(public service:PersonService) { }

  ngOnInit(): void {
  }

  onSubmit(form: NgForm) {
    if (this.service.formData.id == 0)
      this.insertRecord(form);
    else
      this.updateRecord(form);
  }
  insertRecord(form: NgForm) {
    this.service.postPerson().subscribe(
      res => {
        this.resetForm(form);
        this.service.refreshList();
      },
      err => {
        console.log(err);
      }
    );
  }
  updateRecord(form: NgForm) {
    this.service.putPerson().subscribe(
      res => {
        this.resetForm(form);
        this.service.refreshList();
      },
      err => {
        console.log(err);
      }
    );
  }
  resetForm(form: NgForm) {
    form.form.reset();
    this.service.formData = new Person();
  }


}
