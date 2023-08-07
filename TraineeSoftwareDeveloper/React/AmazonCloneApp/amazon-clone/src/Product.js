import React from 'react'
import "./Product.css"
import { useStateValue } from './StateProvider'

function Product({title, price, rating, image}) 
{
  const [{basket}, dispatch] = useStateValue();

  const AddToBasket = () => {
    // Dispatch the Item into Data Layer
    dispatch({
      type: 'ADD_TO_BASKET',
      item: {
        title: title,
        price: price,
        rating: rating,
        image:image,
      },
    });
  };

  return (
    <div className='product'>
        <div className='product__info'>
            <p>{title}</p>
            <p className='product__price'>
                <small>$</small>
                <strong>{price}</strong>
            </p>
            <div className='product__rating'>
              {Array(rating)
                .fill()
                .map((_, i) => (
                  <p>⭐</p>
                ))
              }
            </div>
        </div>
        
        <img src={image} alt='Book Cover' />

        <button onClick={AddToBasket}>Add to Basket</button>
    </div>
  )
}

export default Product
