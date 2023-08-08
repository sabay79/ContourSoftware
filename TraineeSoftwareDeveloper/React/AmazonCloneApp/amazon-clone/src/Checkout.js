import React, { useState } from 'react';
import './Checkout.css';
import SubTotal from './Subtotal.js';
import CheckoutProduct from './CheckoutProduct.js';
import { useStateValue } from './StateProvider';

function Checkout() 
{
  const [{basket}, dispatch] = useStateValue();

  return (
    <div className='checkout'>
        <div className='checkout__left'>
          <img className='checkout__ad' src='./checkoutAD.jpg' alt='Ad' />
          <div>
            <h2 className='checkout__title'>Your Shopping Basket</h2>

            {basket.map(item => (
              <CheckoutProduct 
                id={item.id}
                title={item.title}
                price={item.price}
                rating={item.rating}
                image={item.image}
              />
            ))}
          </div>
        </div>
        
        <div className='checkout__left'>
          <SubTotal />
        </div>

    </div>
  )
}

export default Checkout
