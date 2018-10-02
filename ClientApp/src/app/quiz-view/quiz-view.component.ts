import { Component, OnInit } from '@angular/core';
import { ActivatedRoute, Router } from '@angular/router';

import { QuizService } from '../quiz.service';
import { AnswerService } from '../answer.service';
import {Quiz} from '../quiz'

@Component({
  selector: 'app-quiz-view',
  templateUrl: './quiz-view.component.html',
  styleUrls: ['./quiz-view.component.css']
})
export class QuizViewComponent implements OnInit {
  quiz: Quiz;

  constructor(private route: ActivatedRoute, private router: Router, private quizService: QuizService, private answerService: AnswerService) { }

  ngOnInit() {
    this.getQuiz();
  }

  getQuiz(): void {
    const permalink = this.route.snapshot.paramMap.get('permalink');
    this.quizService.getQuiz(permalink)
      .subscribe(quiz => this.quiz = quiz);
  }

  SendAnswers(): void {

    this.answerService.addQuiz(this.quiz)
      .subscribe(resId => {
        console.log(resId);

        this.router.navigate(['/result', resId]);
      });

  }

}
