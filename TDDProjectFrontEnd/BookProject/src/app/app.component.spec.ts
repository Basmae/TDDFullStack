import { TestBed, async, inject } from '@angular/core/testing';
import { RouterTestingModule } from '@angular/router/testing';
import { AppComponent } from './app.component';
import { BookService } from './book.service';
import { HttpClient, HttpEvent, HttpEventType } from '@angular/common/http';
import {
  HttpClientTestingModule,
  HttpTestingController
} from '@angular/common/http/testing';

describe('AppComponent', () => {
  let service: BookService;
  let http: HttpClient;
  beforeEach(async(() => {
    service = new BookService(http);
    TestBed.configureTestingModule({
      imports: [
        RouterTestingModule,
        HttpClientTestingModule
      ],
      declarations: [
        AppComponent
      ],
      providers: [BookService]
    }).compileComponents();
  }));
  
  it(
    '#getBooks should return books data',
    inject(
      [HttpTestingController, BookService],
      (httpMock: HttpTestingController, bookService: BookService) => {
        const books = [
          {
            "id": 1,
            "title": "book1",
            "author": "author1"
        },
        {
            "id": 2,
            "title": "book2",
            "author": "author2"
        },
        {
            "id": 3,
            "title": "book3",
            "author": "author3"
        },
        {
            "id": 5,
            "title": "w",
            "author": "wow"
        },
        {
            "id": 6,
            "title": "newBook",
            "author": "newAuthor2"
        }
        ];
        bookService.getAllBooks().subscribe((event: HttpEvent<any>) => {
      switch (event.type) {
        case HttpEventType.Response:
          expect(event.body).toEqual(books);
      }
    });
  }
));

  it(
    '#addBook should add & return book data',
    inject(
      [HttpTestingController, BookService],
      (httpMock: HttpTestingController, bookService: BookService) => {
        const book = {
          title : 'unitTest',
          author :'unitTestAngular'
       };
        const expected = {
          id : 7,
          title : 'unitTest',
          author :'unitTestAngular'
       };
        bookService.addBook(book).subscribe((event: HttpEvent<any>) => {
      switch (event.type) {
        case HttpEventType.Response:
          expect(event.body).toEqual(expected);
      }
    });
  }
));
 
  it(
    '#updateBook should update & return book data',
    inject(
      [HttpTestingController, BookService],
      (httpMock: HttpTestingController, bookService: BookService) => {
        const book = {
          id : 5,
          title : 'wow',
          author :'wowAuthor'
       };
        bookService.updateBook(book).subscribe((event: HttpEvent<any>) => {
      switch (event.type) {
        case HttpEventType.Response:
          expect(event.body).toEqual(book);
      }
    });
  }
));
});