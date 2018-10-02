import {AnswerOption} from './answerOption'

export class Question {
  id: number;
  title: string;
  questionType: number;
  answerOptions: AnswerOption[];
  userAnswer: number;
  userTextAnswer: string;
}
