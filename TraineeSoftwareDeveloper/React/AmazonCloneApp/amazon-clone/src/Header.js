import React from 'react'
import './Header.css'
import SearchIcon from '@mui/icons-material/Search';
import ShoppingBasketIcon from '@mui/icons-material/ShoppingBasket';
import {Link} from "react-router-dom";
import {useStateValue} from './StateProvider';
import {auth} from "./firebase.js";

function Header() {
    const [{basket, user}, dispatch] = useStateValue();
    const handleAuthentication = () => {
        if(user){
            auth.signOut();
        }
    }
    const getUsername = (email) => {
        const index = email.indexOf("@");
        let username = email.substring(0, index);   // Get User Name from Email 
        username = username[0].toUpperCase() + username.slice(1);   // Capitalized First Letter
        return username;
    }
    var username;
    if(user) {    
        username = getUsername(user?.email);
    }

    return (
        <div className='header'>
            <Link to='/'>
                <img className='header__logo' src='./amazonLogo.png' alt="logo" />
            </Link>

            <div className='header__search'>
                <input className='header__searchInput' type='text' />
                <SearchIcon className='header__searchIcon' />
            </div>

            <div className='header__nav'>
                <Link to={!user && '/login'}>   {/* only directs to Login Page if there's no user */}
                    <div onClick={handleAuthentication} className='header__option'>
                        <span className='header__optionLineOne'>Hello {username}</span>
                        <span className='header__optionLineTwo'>
                            {user ? 'Sign Out' : 'Sign In'}
                        </span>
                    </div>
                </Link>
                <div className='header__option'>
                    <span className='header__optionLineOne'>Returns</span>
                    <span className='header__optionLineTwo'>& Orders</span>
                </div>
                <Link to='/checkout'>
                    <div className='header__optionBasket'>
                        <ShoppingBasketIcon />
                        <span className='header__optionLineTwo header__basketCount'>
                            {basket.length}
                        </span>
                    </div>
                </Link>
            </div>

        </div>
    )
}

export default Header
