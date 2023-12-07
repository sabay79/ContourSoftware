import React, { useState } from 'react';
import { Link, useNavigate } from 'react-router-dom';
import { login as authLogin } from '../store/authSlice';
import { Button, Input, Logo } from './index';
import { useDispatch } from 'react-redux';
import authService from '../appwrite/auth';
import { useForm } from 'react-hook-form';

const Login = () => {

    const navigate = useNavigate();
    const dispatch = useDispatch();
    const { register, handleSubmit } = useForm();
    const [error, setError] = useState('');
    
    const login = async(data) => {
        setError('');
        try {
            const session = await authService.login(data);
            if(session){
                const userData = await authService.getCurrentUser();
                if(userData){
                    dispatch(authLogin(userData));
                }
                navigate('/');
            }
        } catch (error) {
            setError(error.message);
        }
    }

    return (
        <div className='flex items-center justify-center w-full py-8'>
            <div className={`mx-auto w-full max-w-lg bg-gray-100 rounded-xl p-10 border border-black/10`}>

                <h2 className="text-center text-2xl font-bold leading-tight">Sign In to your Account</h2>
                
                {error && <p className="text-red-600 mt-8 text-center">{error}</p>}
                
                <form onSubmit={handleSubmit(login)} className='mt-8'>
                    <div className="space-y-5">
                        <Input
                            label='Email:'
                            placeholder='Enter your Email'
                            type='email'
                            {...register('email', {
                                required: true,
                                validate: {
                                    matchPattern: (value) => /^\w+([.-]?\w+)*@\w+([.-]?\w+)*(\.\w{2,3})+$/.test(value) || 'Email Address must be a Valid Address',
                                }
                            })}
                        />

                        <Input
                            label='Password:'
                            placeholder='Enter your Password'
                            type='password'
                            {...register('password', {
                                required: true,
                            })}
                        />

                        <Button 
                            type='submit'
                            className='w-full'
                        >
                            Sign In
                        </Button>
                    </div>
                </form>
                
                <p className="mt-2 text-center text-base text-black/60">
                    Doesn't have any Account? {/* Check if Error */}
                    <Link to='/signup' className='font-medium text-primary transition-all duration-200 hover:underline'>
                        Sign Up
                    </Link>
                </p>
            </div>
            
        </div> 
    );
}

export default Login;
