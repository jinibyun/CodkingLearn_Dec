// observable-event-http.component
import { Component, OnInit, OnDestroy } from '@angular/core';
import { FormControl } from '@angular/forms';
import { HttpClient } from '@angular/common/http';

import { Subscription, Observable, of, throwError } from 'rxjs';
import { debounceTime, switchMap, map, tap, catchError } from 'rxjs/operators';

interface GithubUser{
  login: number;
  name: string;
}

@Component({
  selector: 'app-rx-js-example4',
  templateUrl: './rx-js-example4.component.html',
  styleUrls: ['./rx-js-example4.component.css']
})
export class RxJsExample4Component implements OnInit, OnDestroy {
  // angular forms
  searchInput: FormControl = new FormControl('');
  githubUser: GithubUser;
  subscription: Subscription;

  constructor(private http: HttpClient) { }

  ngOnInit() {
    // form's control value change becomes overseavable
    this.subscription = this.searchInput.valueChanges
      .pipe(
        // delay receiving time for data from obserble
        debounceTime(500),
        // create new obserble
        switchMap((userId: string) => this.getGithubUser(userId))
      )
      // subscription
      .subscribe(
        user => this.githubUser = user,
        error => console.log(error)
      );
  }

  // return obserbable from respons value from server
  getGithubUser(userId: string): Observable<GithubUser> {
    return this.http
      .get<GithubUser>(`https://api.github.com/users/${userId}`)
      .pipe(
        map(user => ({ login: user.login, name: user.name })),
        tap(console.log),
        // Error handling
        catchError(err => {
          if (err.status === 404) {
            return of(`[ERROR] Not found user: ${userId}`);
          } else {
            return throwError(err);
          }
        })
      );
  }

  ngOnDestroy() {
    this.subscription.unsubscribe();
  }
}
