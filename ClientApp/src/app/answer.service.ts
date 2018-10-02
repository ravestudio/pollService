import { Injectable } from '@angular/core';
import { HttpClient, HttpHeaders } from '@angular/common/http';
import { Observable, of } from 'rxjs';

import { Quiz } from './quiz';


const httpOptions = {
  headers: new HttpHeaders({ 'Content-Type': 'application/json'})
}

@Injectable({
  providedIn: 'root'
})
export class AnswerService {
  private answersUrl = 'api/answer';  // URL to web api

  /** post quiz with.*/
  addQuiz(quiz: Quiz): Observable<object> {
    return this.http.post<object>(this.answersUrl, quiz, httpOptions);
  }

  constructor(private http: HttpClient) { }
}
