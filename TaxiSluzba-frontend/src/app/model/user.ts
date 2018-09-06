
export class User {

  constructor(public iD?: number,
              public username?: string,
              public password?: string,
              public firstName?: string,
              public lastName?: string,
              public gender?: string,
              public jmbg?: string,
              public phoneNumber?: string,
              public email?: string,
              public role?: string,
              public drivings?: string[]) {
    this.drivings = [];
  }
}
