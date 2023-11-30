import React from 'react';
import { useParams } from 'react-router-dom';

const User = () => {

    const {id} = useParams();

    return (
        <div className='flex justify-center p-10 text-3xl bg-gray-700 text-white'>
            User: {id}
        </div>
    );
}

export default User;
