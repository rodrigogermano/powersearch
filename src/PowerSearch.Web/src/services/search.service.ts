import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http'
import { Observable } from 'rxjs';
import { environment } from 'src/environments/environment';


@Injectable({
  providedIn: 'root'
})
export class SearchService {

  constructor(
    private requet: HttpClient
  ) { }

  public Get(data: string) : Observable<any> {
    return this.requet.get(`${environment.webapi}/Search/${data}`);
  }
}
