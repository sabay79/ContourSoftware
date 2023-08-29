import { Component } from '@angular/core';
import { NgForm } from '@angular/forms';
import { ToastrService } from 'ngx-toastr';
import { PaymentDetail } from 'src/app/shared/payment-detail.model';
import { PaymentDetailService } from 'src/app/shared/payment-detail.service';

@Component({
  selector: 'app-payment-detail-form',
  templateUrl: './payment-detail-form.component.html',
  styles: []
})

export class PaymentDetailFormComponent 
{

  constructor(public service: PaymentDetailService, private toastr:ToastrService) {}

  onSubmit(form:NgForm)
  {
    this.service.postPaymentDetail()
        .subscribe({
          next: res => 
          { 
            this.service.list = res as PaymentDetail[];
            this.service.resetForm(form);
            this.toastr.success('Inserted Successfully', 'Payment Detail Register')
          },
          error: err => {console.log(err); }
        })
  }

}
