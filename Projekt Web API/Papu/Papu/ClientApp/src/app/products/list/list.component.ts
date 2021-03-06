import { Component, Injectable, OnInit } from '@angular/core';

import { Product } from "../product";
import { ProductsService } from '../products.service';
import { Ng2OrderModule } from 'ng2-order-pipe';

@Component({
  selector: 'app-list',
  templateUrl: './list.component.html',
  styleUrls: ['./list.component.css']
})

@Injectable({
  providedIn: 'root'
})

export class ListComponent implements OnInit {
  products: Product[] = [];

  constructor(public productsService: ProductsService) {
  }

  totalLenght: any;
  page: number = 1;

  productName: any;

  order = false;
  isDesc: boolean = false;

  categoryName: boolean = false;
  groupName: boolean = false;
  unitName: boolean = false;
  iron: boolean = false;
  vitaminB12: boolean = false;
  folate: boolean = false;
  vitaminD: boolean = false;
  calcium: boolean = false;
  magnesium: boolean = false;
  fiber: boolean = false;
  protein: boolean = false;
  fat: boolean = false;
  assimilableCarbohydrates: boolean = false;
  carbohydrateReplacement: boolean = false;

  ngOnInit(): void {
    this.productsService.getProducts().subscribe((data: Product[]) => {
      this.products = data;

      console.log(this.products);

      this.totalLenght = data.length;

    });
  }

  search() {
    if(this.productName == ""){
      this.ngOnInit();
    }else{
      this.products = this.products.filter(res =>{
        return res.productName.toLocaleLowerCase().match(this.productName.toLocaleLowerCase());
      })
    }
  }

  sortByNumber() {
    if(this.order) {
      let newarr = this.products.sort((a,b) => a.weight - b.weight);
      this.products = newarr;
    }
    else {
      let newarr = this.products.sort((a,b) => b.weight - a.weight);
      this.products = newarr;
    }

    this.order = !this.order;
  }

  sortByString(property) {
    this.isDesc = !this.isDesc;

    let direction = this.isDesc ? 1: -1;

    this.products.sort(function (a, b) {
      if(a[property] < b[property]) {
        return -1 * direction;
      }
      else if(a[property] > b[property]) {
        return 1 * direction;
      }
      else {
        return 0;
      }
    });
  }

  showCategories() {
    this.categoryName = !this.categoryName;
  }

  showGroups() {
    this.groupName = !this.groupName;
  }

  showUnits() {
    this.unitName = !this.unitName;
  }

  showIron() {
    this.iron = !this.iron;
  }

  showVitaminB12() {
    this.vitaminB12 = !this.vitaminB12;
  }

  showFolate() {
    this.folate = !this.folate;
  }

  showVitaminD() {
    this.vitaminD = !this.vitaminD;
  }

  showCalcium() {
    this.calcium = !this.calcium;
  }

  showMagnesium() {
    this.magnesium = !this.magnesium;
  }

  showFiber() {
    this.fiber = !this.fiber;
  }

  showProtein() {
    this.protein = !this.protein;
  }

  showFat() {
    this.fat = !this.fat;
  }

  showAssimilableCarbohydrates() {
    this.assimilableCarbohydrates = !this.assimilableCarbohydrates;
  }

  showCarbohydrateReplacement() {
    this.carbohydrateReplacement = !this.carbohydrateReplacement;
  }

  deleteProduct(productId) {
    this.productsService.deleteProduct(productId).subscribe(res => {
      this.products = this.products.filter(item => item.productId !== productId);
    });
  }

}
