import { CommonModule } from '@angular/common';
import { NgModule } from '@angular/core';
import { FormsModule } from '@angular/forms';
import { RouterModule } from '@angular/router';
import { AdminRoutes } from '../Routing/routing.admin';
import { AdminComponent } from '../Admin/admin.component';
import {HttpClientModule} from '@angular/common/http';



@NgModule({
  declarations: [
    AdminComponent,
],
  imports: [
    CommonModule,
    FormsModule,
    HttpClientModule,
    RouterModule.forChild(AdminRoutes)
  ],
  providers: [],
  bootstrap: [AdminComponent]
})
export class AdminModule { }