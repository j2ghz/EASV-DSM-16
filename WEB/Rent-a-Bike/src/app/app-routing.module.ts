import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { BikesComponent } from './bikes/bikes.component';
import { DashboardComponent } from './dashboard/dashboard.component';
import { BikeDetailComponent } from './bikes/bike-detail/bike-detail.component';
import { LoggedInGuard } from './auth/logged-in.guard';

const routes: Routes = [
  { path: '', redirectTo: '/dashboard', pathMatch: 'full' },
  { path: 'dashboard', component: DashboardComponent },
  { path: 'bikes', component: BikesComponent, canActivate: [LoggedInGuard] },
  { path: 'detail/:id', component: BikeDetailComponent }
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
