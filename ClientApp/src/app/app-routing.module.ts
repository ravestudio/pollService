import { NgModule }             from '@angular/core';
import { RouterModule, Routes } from '@angular/router';

import { QuizzesComponent} from './quizzes/quizzes.component';
import { QuizViewComponent } from './quiz-view/quiz-view.component';
import { QuizResultComponent } from './quiz-result/quiz-result.component';

const routes: Routes = [
  { path: '', component: QuizzesComponent },
  { path: 'result/:id', component: QuizResultComponent },
  { path: ':permalink', component: QuizViewComponent }
];

@NgModule({
  imports: [ RouterModule.forRoot(routes) ],
  exports: [ RouterModule ]
})
export class AppRoutingModule {}
