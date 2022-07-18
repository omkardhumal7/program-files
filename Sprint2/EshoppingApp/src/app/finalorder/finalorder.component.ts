import { HttpClient } from '@angular/common/http';
import { Component, OnInit } from '@angular/core';
import { Router } from '@angular/router';
import { finalorder } from '../models/finalorder';
import { AdddetailService } from '../services/adddetail.service';

@Component({
  selector: 'app-finalorder',
  templateUrl: './finalorder.component.html',
  styleUrls: ['./finalorder.component.css']
})
export class FinalOrderComponent implements OnInit {

  constructor(public httpc: HttpClient, private _detail: AdddetailService, private _router: Router) { }

  ngOnInit(): void {
  }

  adddetail: finalorder = new finalorder();
  adddetails: Array<finalorder> = new Array<finalorder>();

  Adddetail() {
    console.log(this.adddetail)

    var deto = {
      id: Number(this.adddetail.id),
      firstName: this.adddetail.firstName,
      lastName: this.adddetail.lastName,
      address: this.adddetail.address,
      state: this.adddetail.state,
      city: this.adddetail.city,
      zip: Number(this.adddetail.zip),
      email: this.adddetail.email,
      orderName: this.adddetail.orderName,
      orderQuantity: Number(this.adddetail.orderQuantity),
      orderPrice: Number(this.adddetail.orderPrice)
    }
    this.httpc.post("https://localhost:44388/api/FinalOrder", deto).subscribe(res => this.PostSuccess(res), res => this.PostError(res));
    this.adddetail = new finalorder();


  }

  PostSuccess(res: any) {
    console.log(res);

  }
  PostError(res: any) {
    console.log(res);
  }

  Show() {
    console.log("Hi");
    this.httpc.get("https://localhost:44388/api/FinalOrder").subscribe(res => this.GetSuccess(res), res => this.GetError(res));
  }
  GetSuccess(input: any) {
    this.adddetails = input;
  }
  GetError(input: any) {
    console.log(input);
  }


}