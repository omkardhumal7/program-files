import { Component, OnInit } from '@angular/core';
import {Product} from './product.model';
import { HttpClient } from '@angular/common/http';

@Component({
  templateUrl: './Product.component.html'
})
export class ProductComponent{
  constructor(public httpc:HttpClient){

  }
  title='SPRINTAPP';
  ProductModel:Product=new Product();
  ProductModels:Array<Product>=new Array<Product>();
  AddProduct(){
    console.log(this.ProductModel);
   
    var Productdto={
      ProductID:this.ProductModel.ProductID,
      ProductName:this.ProductModel.ProductName,
      Category:this.ProductModel.Category,
    }
    this.httpc.post("https://localhost:44380/api/Product",Productdto).subscribe(res=>this.PostSuccess(res),res=>this.PostError(res));
    this.ProductModel=new Product();
  }
  PostSuccess(res:any){
    console.log(res);

  }
  PostError(res:any){
    console.log(res);

  }
  getData(){
    console.log("Working");
    this.httpc.get("https://localhost:44380/api/Product").subscribe(res=>this.GetSuccess(res),res=>this.GetError(res));
  }
  GetSuccess(input:any){
    this.ProductModels=input;
  }
  GetError(input:any){
    console.log(input);
  }
}