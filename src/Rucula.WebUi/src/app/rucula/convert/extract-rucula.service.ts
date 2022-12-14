import { Injectable } from '@angular/core';
import { HttpClient, HttpHeaders } from '@angular/common/http';
import { Observable } from 'rxjs';

@Injectable({
  providedIn: 'root',
})
export class ExtractRuculaService {
    
    constructor(private http: HttpClient) { }
    
    private Url:string = "https://localhost:7170";
    
    PreviewContent(contentRucula:string): Observable<string>{
      let httpheaders=new HttpHeaders()
      .set('Content-type','application/json');
      let options={
        headers:httpheaders
      };
      return this.http.post<any>(`${this.Url}/RucuclaConvert`, `"${contentRucula}"`,options)
    }
}