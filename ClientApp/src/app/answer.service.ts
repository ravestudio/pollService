import { Injectable } from '@angular/core';
import { HttpClient, HttpHeaders } from '@angular/common/http';
import { Observable, of } from 'rxjs';

import { Quiz } from './quiz';
import { Statistics } from './statistics';


const httpOptions = {
  headers: new HttpHeaders({ 'Content-Type': 'application/json'})
}

@Injectable({
  providedIn: 'root'
})
export class AnswerService {
  private answersUrl = 'api/answer';  // URL to web api

  /** post quiz with.*/
  addQuiz(quiz: Quiz): Observable<number> {
    return this.http.post<number>(this.answersUrl, quiz, httpOptions);
  }

  /** GET quiz result by id.*/
  getStatistics(id: string): Observable<Statistics> {
    const url = `${this.answersUrl}/${id}`;
    return this.http.get<Statistics>(url);
  }

  constructor(private http: HttpClient) { }
}
