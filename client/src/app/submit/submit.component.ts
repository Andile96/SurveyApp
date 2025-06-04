import { Component, inject, OnInit } from '@angular/core';
import { FormBuilder, FormGroup, Validators, FormsModule, ReactiveFormsModule } from '@angular/forms';
import { SurveyService } from '../_services/survey.service';
import { getSurvey } from '../_models/getSurvey';
import { NgFor } from '@angular/common';

@Component({
  selector: 'app-submit',
  standalone: true,
  imports: [NgFor, FormsModule, ReactiveFormsModule],
  templateUrl: './submit.component.html',
  styleUrls: ['./submit.component.css'] // ✅ fixed plural
})
export class SubmitComponent {
  private fb = inject(FormBuilder);
  private surveyService = inject(SurveyService);

  ratingFields: string[] = ['watchingMoviesRating', 'listeningRadioRating', 'eatingOutRating', 'watchingTvRating'];
  ratingLabels: string[] = [
    'I like to watch movies',
    'I like to listen to radio',
    'I like to eat out',
    'I like to watch TV'
  ];

  surveyForm: FormGroup = this.fb.group({
    fullName: ['', Validators.required],
    email: ['', [Validators.required, Validators.email]],
    dateOfBirth: ['', Validators.required],
    contactNumber: ['', Validators.required],
    favoriteFoods: this.fb.group({
      Pizza: false,
      Pasta: false,
      PapAndWors: false,
      Other: false,
    }),
    eatingOutRating: [null, Validators.required],
    watchingMoviesRating: [null, Validators.required],
    watchingTvRating: [null, Validators.required],
    listeningRadioRating: [null, Validators.required]
  });

  onSubmit() {
    if (this.surveyForm.invalid) return;

    const formValue = this.surveyForm.value;
    const favoriteFoods = Object.entries(formValue.favoriteFoods)
      .filter(([_, selected]) => selected)
      .map(([food]) => food);

    const newSurvey: getSurvey = {
      fullName: formValue.fullName,
      email: formValue.email,
      dateOfBirth: formValue.dateOfBirth,
      contactNumber: formValue.contactNumber,
      favoriteFoods,
      eatingOutRating: formValue.eatingOutRating,
      watchingMoviesRating: formValue.watchingMoviesRating,
      watchingTvRating: formValue.watchingTvRating,
      listeningRadioRating: formValue.listeningRadioRating,
    };

    this.surveyService.submitSurvey(newSurvey).subscribe(() => {
      alert('Survey submitted successfully!');
      this.surveyForm.reset();
    });
  }
}
