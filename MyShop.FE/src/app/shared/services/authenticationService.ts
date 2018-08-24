import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { map } from 'rxjs/operators';

@Injectable({ providedIn: 'root' })
export class AuthenticationService {
    constructor(private httpClient: HttpClient) { }

    login(username: string, password: string) {
        var url = "https://localhost:44369/account/login";
        this.httpClient.post<any>(url, { email: username, password: password })
            .pipe(map(user => {
                if (user && user.access_token) {
                    localStorage.setItem('currentUser', JSON.stringify(user));
                }
                return user;
            }));
    }

    logout() {
        localStorage.removeItem('currentUser');
    }
}