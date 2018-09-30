import { Component, OnInit } from '@angular/core';

import {QuizService} from '../quiz.service'
import {Quiz} from '../quiz'

@Component({
  selector: 'app-quizzes',
  templateUrl: './quizzes.component.html',
  styleUrls: ['./quizzes.component.css']
})
export class QuizzesComponent implements OnInit {
  quizzes: Quiz[];

  constructor(private quizService : QuizService) { }

  ngOnInit() {
    this.getQuizzes();
  }

  getQuizzes(): void {
    this.quizService.getQuizzes()
      .subscribe(quizzes => this.quizzes = quizzes);
  }

}
