import { HttpClient } from '@angular/common/http';
import { Component } from '@angular/core';
import { User } from './user.model';

@Component({
  
  templateUrl: './user.component.html',
})
export class UserComponent {
  constructor(public httpz:HttpClient){

  }
  title = 'ecommerceproject';
  UserModel:User=new User();
  UserModels:Array<User>=new Array<User>();
  AddUser(){
    console.log(this.UserModel);

    var userdto={
      UserID:this.UserModel.Userid,
      UserName:this.UserModel.UserName,
      UserPassword:this.UserModel.UserPassword,
    }
    this.httpz.post("https://localhost:44380/api/User",userdto).subscribe(res=>this.PostSuccess(res),res=>this.PostError(res));
   
    this.UserModel=new User();
  }
  PostSuccess(res:any){
    console.log(res);

  }
  PostError(res:any){
    console.log(res);

  }
  getData(){
    console.log("Working");
    this.httpz.get("https://localhost:44380/api/User").subscribe(res=>this.GetSuccess(res),res=>this.GetError(res));
  }
  GetSuccess(input:any){
    this.UserModels=input;
  }
  GetError(input:any){
    console.log(input);
  }
}