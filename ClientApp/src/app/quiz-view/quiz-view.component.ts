import { Component, OnInit } from '@angular/core';
import { ActivatedRoute } from '@angular/router';

import { QuizService }  from '../quiz.service';
import {Quiz} from '../quiz'

@Component({
  selector: 'app-quiz-view',
  templateUrl: './quiz-view.component.html',
  styleUrls: ['./quiz-view.component.css']
})
export class QuizViewComponent implements OnInit {
  quiz:Quiz;

  constructor(private route: ActivatedRoute, private quizService: QuizService) { }

  ngOnInit() {
    this.getQuiz();
  }

  getQuiz(): void {
    const permalink = this.route.snapshot.paramMap.get('permalink');
    this.quizService.getQuiz(permalink)
      .subscribe(quiz => this.quiz = quiz);
  }

  SendAnswers(): void { 

  }

}
