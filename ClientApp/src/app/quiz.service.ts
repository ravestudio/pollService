import { Injectable } from '@angular/core';
import { HttpClient, HttpHeaders } from '@angular/common/http';
import { Observable, of } from 'rxjs';
import { catchError, map, tap } from 'rxjs/operators';

import {Quiz} from './quiz';

@Injectable({
  providedIn: 'root'
})
export class QuizService {

  private quizzesUrl = 'api/quiz';  // URL to web api

  /** GET quizzes from the server */
  getQuizzes (): Observable<Quiz[]> {
    return this.http.get<Quiz[]>(this.quizzesUrl);
  }

   /** GET quiz by permalink.*/
   getQuiz(permalink: string): Observable<Quiz> {
    const url = `${this.quizzesUrl}/${permalink}`;
    return this.http.get<Quiz>(url);
  }

  constructor(private http: HttpClient) { }
}
