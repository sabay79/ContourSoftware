import React, { useState } from 'react';
import { Link, useNavigate } from 'react-router-dom';
import { useDispatch } from 'react-redux';
import { useForm } from 'react-hook-form';

import authService from '../appwrite/auth';
import { login } from '../store/authSlice';
import { Button, Input} from './';

const Signup = () => {

    const navigate = useNavigate();
    const [error, setError] = useState('');
    const dispatch = useDispatch();
    const { register, handleSubmit } = useForm();

    const create = async(data) => {
        setError('');

        try {
            const userData = await authService.createAccount(data);

            if(userData){
                const userData = await authService.getCurrentUser();
                if(userData){
                    dispatch(login(userData));
                }
                navigate('/');
            }
        } catch (error) {
            setError(error.message);
        }
    }
    return (
        <div className='flex items-center justify-center w-full'>
            <div className={`mx-auto w-full max-w-lg bg-gray-100 rounded-xl p-10 border border-black/10`}>

                <h2 className="text-center text-2xl font-bold leading-tight">Sign Up to Create Account</h2>

                {error && <p className="text-red-600 mt-8 text-center">{error}</p>}

                <form onSubmit={handleSubmit(create)} className='mt-8'>
                    <div className="space-y-5">
                        <Input
                            label="Full Name: "
                            placeholder="Enter your full name"
                            {...register("name", {
                                required: true,
                            })}
                        />
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
                            Create Account
                        </Button>
                    </div>
                </form>

                <p className="mt-2 text-center text-base text-black/60">
                    Already have an Account?
                    <Link to='/login' className="font-medium text-primary transition-all duration-200 hover:underline">
                        Sign In
                    </Link>
                </p>

            </div>
        </div>
    );
}

export default Signup;
