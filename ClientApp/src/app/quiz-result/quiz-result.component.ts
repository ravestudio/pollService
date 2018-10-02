import { Component, OnInit } from '@angular/core';
import { ActivatedRoute, Router } from '@angular/router';

import { AnswerService } from '../answer.service';
import { Statistics } from '../statistics'

@Component({
  selector: 'app-quiz-result',
  templateUrl: './quiz-result.component.html',
  styleUrls: ['./quiz-result.component.css']
})
export class QuizResultComponent implements OnInit {
  statistics: Statistics;

  constructor(private route: ActivatedRoute, private answerService: AnswerService) { }

  ngOnInit() {
    this.getStatistics();
  }

  getStatistics(): void {
    const id = this.route.snapshot.paramMap.get('id');
    this.answerService.getStatistics(id)
      .subscribe(statistics => this.statistics = statistics);
  }

}
