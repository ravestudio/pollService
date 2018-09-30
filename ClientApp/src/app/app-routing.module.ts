import { NgModule }             from '@angular/core';
import { RouterModule, Routes } from '@angular/router';

import { QuizzesComponent} from './quizzes/quizzes.component';
import {QuizViewComponent} from './quiz-view/quiz-view.component';

const routes: Routes = [
  { path: '', component: QuizzesComponent },
  { path: ':permalink', component: QuizViewComponent }
];

@NgModule({
  imports: [ RouterModule.forRoot(routes) ],
  exports: [ RouterModule ]
})
export class AppRoutingModule {}
