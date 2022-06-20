import { Component } from '@angular/core';
import { Supplier } from './supplier.model';

@Component({
  templateUrl: './Supplier.component.html'
})
export class SupplierComponent {
  title = 'first-sample-project';
  myname = 'Omkar Dhumal'
  SupplierModel: Supplier = new Supplier();
  CustmerModels: Array<Supplier> = new Array<Supplier>();
  AddSupplier() {
    this.CustmerModels.push(this.SupplierModel);
    this.SupplierModel = new Supplier();
  }
  EditSupplier(input: Supplier) {
    this.SupplierModel = input;
  }
  DeleteSupplier(input: Supplier) {
    var index=this.CustmerModels.indexOf(input);
    this.CustmerModels.splice(index,1);
  }

}