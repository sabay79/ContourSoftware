import React from 'react';
import './Checkout.css';
import SubTotal from './Subtotal.js';

function Checkout() {
  return (
    <div className='checkout'>

        <div className='checkout__left'>
            <img className='checkout__ad' src='./checkoutAD.jpg' alt='Ad' />
            <div>
                <h2 className='checkout__title'>Your Shopping Basket</h2>
            </div>
        </div>
        
        <div className='checkout__left'>
            <SubTotal />
        </div>

    </div>
  )
}

export default Checkout
