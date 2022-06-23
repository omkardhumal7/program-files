import { AdminComponent } from "../Admin/admin.component";
import { HomeComponent } from "../Home/home.component";
import { ProductComponent } from "../Product/product.component";
import { UserComponent } from "../User/user.component";

export const MainRoutes=[
    {path:'',component:HomeComponent},
    {path:'Home',component:HomeComponent},
    {path:'User',loadChildren:()=>import('../User/user.module').then(m=>m.UserModule)},
    {path:'Admin',loadChildren:()=>import('../Admin/admin.component').then(m => m.AdminComponent)},
    {path:'Product',loadChildren:()=>import('../Product/product.component').then(m=>m.ProductComponent)}
];

// import { CustomerComponent } from "../customer/customer.component";
// import { HomeComponent } from "../home/home.component";
// import { SupplierComponent } from "../supplier/supplier.component";

// export const MainRoutes= [
//     {path:'',component:HomeComponent},
//     {path:'home',component:HomeComponent},
//     {path:'customer',loadChildren:()=>import('../customer/customer.module').then(m=>m.CustomerModule)},
//     {path:'supplier',loadChildren:()=>import('../supplier/supplier.module').then(m=>m.SupplierModule)}
// ];