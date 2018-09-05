import {Address} from './address.model';
import {University} from './university.model';

export class User {

  constructor(public id?: number,
              public username?: string,
              public password?: string,
              public firstname?: string,
              public lastname?: string,
              public gender?: string,
              public jmbg?: string,
              public email?: string,
              public address?: Address,
              public university?: University,
              public expertise?: string,
              public role?: string
  ) {
    this.address = new Address();
    this.university = new University();
  }
}
