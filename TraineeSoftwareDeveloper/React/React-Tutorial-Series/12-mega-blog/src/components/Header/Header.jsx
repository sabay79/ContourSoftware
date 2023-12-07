import React from 'react';
import { Container, Logo, LogoutBtn } from '../index';
import { Link, useNavigate } from 'react-router-dom';
import { useSelector } from 'react-redux';

const Header = () => {

    const authStatus = useSelector((state) => state.auth.status);
    const navigate = useNavigate();
    
    const navItems = [
        {name: 'Home', url: '/', active: true},
        {name: 'Login', url: '/login', active: !authStatus},
        {name: 'Signup', url: '/signup', active: !authStatus},
        {name: 'All Posts', url: '/all-posts', active: authStatus},
        {name: 'Add Post', url: '/add-post', active: authStatus},
    ];

    return (
        <header className='p-3 shadow bg-blue-700 text-white'>
            <Container>
                <nav className="flex">
                    <div className="mr-4 mt-1  text-2xl">
                        <Link to='/'>
                            <Logo width='70px' />
                        </Link>
                    </div>

                    <ul className="flex ml-auto">
                        {navItems.map((item) => item.active 
                                            ? (
                                                <li key={item.name}>
                                                    <button
                                                        onClick={() => navigate(item.url)}
                                                        className='inline-block px-6 py-2 duration-200 hover:bg-white hover:text-black rounded-full'
                                                    >
                                                        {item.name}
                                                    </button>
                                                </li>
                                            )
                                            : null
                                    )
                        }

                        {authStatus && (
                            <li>
                                <LogoutBtn/>
                            </li>
                        )}
                    </ul>
                </nav>
            </Container>
        </header>
    );
}

export default Header;
