import { Component, EventEmitter, Input, Output, OnInit } from '@angular/core';


@Component({
  selector: 'app-add-or-update-home',
  templateUrl: './add-or-update-home.component.html',
  styleUrls: ['./add-or-update-home.component.css']
})
export class AddOrUpdateHomeComponent implements OnInit {

  @Output() bookCreated = new EventEmitter<any>();
  @Input() bookInfo: any;

  public buttonText = 'Save';

  constructor() {
    this.clearBookInfo();
    console.log(this.bookInfo.Title);
   }

  ngOnInit(): void {
  }

  private clearBookInfo = function() {
    // Create an empty book object
    this.bookInfo = {
      id: undefined,
      Author: '',
      Title: ''
    };
  };

  public addOrUpdateBookRecord = function(event) {
    this.bookCreated.emit(this.bookInfo);
    this.clearBookInfo();
  };
}