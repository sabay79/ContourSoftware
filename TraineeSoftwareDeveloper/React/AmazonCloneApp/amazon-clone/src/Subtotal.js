import React from 'react';
import './Subtotal.css';
import CurrencyFormat from 'react-currency-format';
function Subtotal() {
  return (
    <div className='subtotal'>
    <CurrencyFormat
        renderText={(value) => (
            <>
                <p>
                    SubTotal (0 items): <strong>0</strong>
                </p>
                <small className='subtotal__gift'>
                    <input type='checkbox' /> This Order Contains a Gift.
                </small>
            </>
        )}
        decimalScale={2}
        value={0}
        displayType={"text"}
        thousandSeparator={true}
        prefix={'$'}
    />
    <button>Proceed to CheckOut</button>
    </div>
  )
}

export default Subtotal
