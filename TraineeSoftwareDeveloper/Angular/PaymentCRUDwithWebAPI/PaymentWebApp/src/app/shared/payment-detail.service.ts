import { Injectable } from '@angular/core';
import {HttpClient} from "@angular/common/http";
import { environment } from 'src/environments/environment.development';
import { PaymentDetail } from './payment-detail.model';
import { NgForm } from '@angular/forms';

@Injectable({
  providedIn: 'root'
})
export class PaymentDetailService 
{

  url : string = environment.apiBaseUrl + '/PaymentDetail'
  list : PaymentDetail[] = [];
  formData : PaymentDetail = new PaymentDetail();

  constructor(private http:HttpClient) { }

  /* 
    This will make a GET request to running instance of Web API 
    to retrieve the Existing Payment Details
  */
 
  refreshList()
  {
    this.http.get(this.url)
        .subscribe({
          next: res => { this.list = res as PaymentDetail[] },
          error: err => { console.log(err); }
    })
  }

  postPaymentDetail = () => this.http.post(this.url, this.formData);

  resetForm(form:NgForm)
  {
    form.form.reset();
    this.formData= new PaymentDetail();
  }

}
