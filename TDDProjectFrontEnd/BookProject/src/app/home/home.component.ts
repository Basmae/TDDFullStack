import { Component, OnInit } from '@angular/core';
import { BookService } from '../book.service'
import * as _ from 'lodash';
@Component({
  selector: 'app-home',
  templateUrl: './home.component.html',
  styleUrls: ['./home.component.css']
})
export class HomeComponent implements OnInit {
  public booksData: Array<any>;
  public currentBook: any;

  constructor(private bookService: BookService) {
      bookService.getAllBooks().subscribe((data: any)=>this.booksData = data);
      this.currentBook = this.setInitialValuesForBookData();
   }

  ngOnInit(): void {
  }
  private setInitialValuesForBookData () {
    return {
      id: undefined,
      title: '',
      author: ''
    }
  }
  public createOrUpdateBook = function(book: any) {
    let bookWithId;
    bookWithId = this.booksData.find(el => el.id === book.id);

    if (bookWithId) {
      var updateIndex ;
      var index =0;
      this.booksData.forEach(element => {
        if(element.id === book.id)
        {
          updateIndex = index
        }
        index++;
      });

      this.bookService.updateBook(book).subscribe(
        bookRecord =>  this.booksData.splice(updateIndex, 1, book)
      );
    } else {
      this.bookService.addBook(book).subscribe(
        bookRecord => this.booksData.push(book)
      );
    }

    this.currentBook = this.setInitialValuesForBookData();
  };
    
public editClicked = function(record) {
  this.currentBook = record;
};

public newClicked = function() {
  this.currentBook = this.setInitialValuesForBookData(); 
};

public deleteClicked(record) {
  const deleteIndex = _.findIndex(this.booksData, {id: record.id});
  this.bookService.removeBook(record).subscribe(
    result => this.booksData.splice(deleteIndex, 1)
  );
}
}

