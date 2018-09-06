export class SecurityUtil {

  static getRole() {
    if (this.isEmpty()) {
      return 'GUEST';
    }
    return JSON.parse(localStorage.getItem('loggedUser'))['RegisterDto']['Role'];
  }

  static clearLocalStorage() {
    localStorage.clear();
  }

  static isEmpty() {
    return localStorage.getItem('loggedUser') === null;
  }

  static getUsername() {
    return JSON.parse(localStorage.getItem('loggedUser'))['RegisterDto']['Username'];
  }

  static getEmail() {
    return JSON.parse(localStorage.getItem('loggedUser'))['RegisterDto']['Email'];
  }

  static getId() {
    if (this.isEmpty()) {
      return -1;
    }
    return JSON.parse(localStorage.getItem('loggedUser'))['RegisterDto']['Id'];
  }

  static getUser() {
    return JSON.parse(localStorage.getItem('loggedUser'));
  }

}
