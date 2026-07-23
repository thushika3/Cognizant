import { Injectable } from '@angular/core';

@Injectable({
  providedIn:'root'
})
export class StudentService{

  students:string[]=[
    "John",
    "Alice"
  ];

}
