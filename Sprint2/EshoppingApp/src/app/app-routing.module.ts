import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';

import { AdminComponent } from './admin/admin.component';
import { CartComponent } from './cart/cart.component';
import { CategoryComponent } from './category/category.component';
import { DashboardComponent } from './dashboard/dashboard.component';
import { FinalOrderComponent } from './finalorder/finalorder.component';
import { HomeComponent } from './home/home.component';
import { LoginComponent } from './login/login.component'
import { OrdercompleteComponent } from './ordercomplete/ordercomplete.component';
import { ProductComponent } from './product/product.component';
import { RegisterComponent } from './register/register.component';
import { UpdateComponent } from './update/update.component';
import { UserDetailsComponent } from './userdetails/userdetails.component';

const routes: Routes = [
  {
    path: 'home',
    component: HomeComponent
  },
  {
    path: '',
    component: HomeComponent
  },
  {
    path: 'login',
    component: LoginComponent
  },
  {
    path: 'register',
    component: RegisterComponent
  },
  {
    path: 'dashboard',
    component: DashboardComponent
  },
  {
    path:'finalorder',
    component:FinalOrderComponent
  },
  {
    path: 'cart',
    component: CartComponent
  },
  {
    path:'ordercomplete',
    component:OrdercompleteComponent
  },
  {
    path: 'product',
    component: ProductComponent
  },
  {
    path: 'admin',
    component: AdminComponent
  },
  {
    path: 'category',
    component: CategoryComponent
  },
  {
    path:'userdetails',
    component:UserDetailsComponent
  },
  {
    path: 'update',
    component: UpdateComponent
  },
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
