import { BrowserModule } from '@angular/platform-browser';
import { NgModule } from '@angular/core';

import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
import { HomeComponent } from './home/home.component';
import { BookComponent } from './book/book.component';
import { AddOrUpdateHomeComponent } from './add-or-update-home/add-or-update-home.component';
import { Routes, RouterModule } from '@angular/router';
import { BookService } from './book.service';
import { HttpClientModule } from '@angular/common/http';
import { FormsModule } from '@angular/forms';
import * as _ from 'lodash';
const appRoutes: Routes = [
  { path: '', component: HomeComponent },
  { path: 'AddOrUpdate', component: AddOrUpdateHomeComponent }
 
];

@NgModule({
  declarations: [
    AppComponent,
    HomeComponent,
    BookComponent,
    AddOrUpdateHomeComponent
  ],
  imports: [
    BrowserModule,
    AppRoutingModule,
    RouterModule.forRoot(appRoutes),
    HttpClientModule,
    FormsModule
  ],
  providers: [BookService],
  bootstrap: [AppComponent]
})
export class AppModule { }