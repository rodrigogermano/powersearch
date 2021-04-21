import { Component } from '@angular/core';
import { SearchService } from 'src/services/search.service';

@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  styleUrls: ['./app.component.scss']
})
export class AppComponent {
  
  public data: string = "";
  public result: Array<any> = [];
  
  constructor(
    private searchService: SearchService
  ){

  }

  public search() : void {    
    this.searchService.Get(this.data).subscribe(
      success => { 
        console.log(success);      
        this.result = success;
      },
      error => console.error(error)
    )
  }
}
