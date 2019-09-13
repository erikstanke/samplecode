import { Component, Inject } from '@angular/core';
import { HttpClient } from '@angular/common/http';

@Component({
  selector: 'app-fetch-data',
  templateUrl: './fetch-data.component.html'
})
export class FetchDataComponent {
  
  public stories: Story[];

  constructor(http: HttpClient, @Inject('BASE_URL') baseUrl: string) {

    if (this.stories == null) {
      http.get<Story[]>(baseUrl + 'api/news').subscribe(result => {
        this.stories = result;
      }, error => console.error(error));
    }
  } 
}


interface Story {
  id: number;
  by: string;
  title: string;
  url: string;
}
