import React from 'react'
import './Header.css'
import SearchIcon from '@mui/icons-material/Search';
import ShoppingBasketIcon from '@mui/icons-material/ShoppingBasket';
import { Link } from "react-router-dom";

function Header() {
  return (
    <div className='header'>
        <Link to='/'> {/* Not Working */}
            <img className='header__logo' src='./amazonLogo.png' alt="logo" />
        </Link>
        <div className='header__search'>
            <input className='header__searchInput' type='text' />
            <SearchIcon className='header__searchIcon' />
        </div>
        <div className='header__nav'>
            <div className='header__option'>
                <span className='header__optionLineOne'>Hello Guest</span>
                <span className='header__optionLineTwo'>Sign In</span>
            </div>
            <div className='header__option'>
                <span className='header__optionLineOne'>Returns</span>
                <span className='header__optionLineTwo'>& Orders</span>
            </div>
            <Link to='/checkout'> {/* Not Working */}
                <div className='header__optionBasket'>
                    <ShoppingBasketIcon />
                    <span className='header__optionLineTwo header__basketCount'>0</span>
                </div>
            </Link>
        </div>
    </div>
  )
}

export default Header
