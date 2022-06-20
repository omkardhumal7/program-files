import { Component, Host, OnInit } from '@angular/core';
import { Admin } from '../Admin/admin.model';

@Component({
  selector: 'app-admin',
  templateUrl: './admin.component.html',
})
export class AdminComponent{
  title='SPRINTAPP';
  AdminModel:Admin=new Admin();
  AdminModels:Array<Admin>=new Array<Admin>();
  AddAdmin(){
    this.AdminModels.push(this.AdminModel)
    this.AdminModel=new Admin();
  }

}
