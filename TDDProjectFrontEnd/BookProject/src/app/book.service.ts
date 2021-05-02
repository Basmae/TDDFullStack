import { Injectable } from '@angular/core';
import { HttpClient, HttpHeaders } from '@angular/common/http';

@Injectable({
  providedIn: 'root'
})
export class BookService {
  private headers: HttpHeaders;
  private accessPointUrl: string = 'https://localhost:44383/api/books';

  constructor(private http: HttpClient) {
    this.headers = new HttpHeaders({'Content-Type': 'application/json; charset=utf-8'});
  }

  public getAllBooks() {
    return this.http.get(this.accessPointUrl, {headers: this.headers});
  }

  public getBook(id) {
    return this.http.get(this.accessPointUrl + '/' + id, {headers: this.headers});
  }

  public addBook(payload) {
    return this.http.post(this.accessPointUrl, payload, {headers: this.headers});
  }

  public removeBook(payload) {
    return this.http.delete(this.accessPointUrl + '/' + payload.id, {headers: this.headers});
  }

  public updateBook(payload) {
    return this.http.put(this.accessPointUrl + '/' + payload.id, payload, {headers: this.headers});
  }
}