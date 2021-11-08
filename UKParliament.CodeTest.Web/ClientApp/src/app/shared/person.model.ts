export class Person {
  id: number;
  name: string;
  dateOfBirth: Date;
  dateOfBirthString: string;
  addressLine1: string;
  addressLine2: string;
  street: string;
  postTown: string;
  county: string;
  postCode: string;
  emailAddress: string;
  phoneNumber: string;

  constructor() {
    this.id = 0;
    this.name = "";
    this.dateOfBirth = new Date();
    this.dateOfBirthString = "";
    this.addressLine1 = "";
    this.addressLine2 = "";
    this.street = "";
    this.postTown = "";
    this.county = "";
    this.postCode = "";
    this.emailAddress = "";
    this.phoneNumber = "";

  }
}
