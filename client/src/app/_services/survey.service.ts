import { HttpClient } from '@angular/common/http';
import { inject, Injectable } from '@angular/core';
import { getSurvey } from '../_models/getSurvey';
import { Observable } from 'rxjs';

@Injectable({
  providedIn: 'root'
})
export class SurveyService {
  private http = inject(HttpClient);
  private apiUrl = 'https://localhost:5001/api/survey';
 
  submitSurvey(survey: getSurvey): Observable<{ message: string }> {
  return this.http.post<{ message: string }>(`${this.apiUrl}`, survey);
}

}
