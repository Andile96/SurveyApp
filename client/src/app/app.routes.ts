import { Routes } from '@angular/router';
import { ResultsComponent } from './results/results.component';
import { SubmitComponent } from './submit/submit.component';

export const routes: Routes = [
    { path: '', redirectTo: 'submit', pathMatch: 'full' },
    {path: 'submit', component: SubmitComponent},
    {path:'results', component: ResultsComponent}
   
];
