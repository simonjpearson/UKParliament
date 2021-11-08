import { Component, OnInit } from '@angular/core';

import { Person } from '../shared/person.model';
import { PersonService } from '../shared/person.service';
import { DatePipe } from '@angular/common';

@Component({
  selector: 'app-person',
  templateUrl: './person.component.html',
  styles: []
})
export class PersonComponent implements OnInit {

  constructor(public service: PersonService, public datepipe: DatePipe) { }

  ngOnInit(): void {
    this.service.refreshList();
  }

  populateForm(selectedRecord: Person) {
    this.service.formData = Object.assign({}, selectedRecord);
    this.service.formData.dateOfBirthString = this.datepipe.transform(selectedRecord.dateOfBirth, 'yyyy-MM-dd')
  }

  onDelete(id: number) {
    this.service.deletePerson(id)
      .subscribe(
        res => {
          this.service.refreshList();
          //reset the form
          this.service.formData = Object.assign({}, null);
        },
        err => { console.log(err) }
      )
  }

}
