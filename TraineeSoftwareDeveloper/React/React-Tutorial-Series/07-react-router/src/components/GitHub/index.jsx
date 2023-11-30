import React, { useState, useEffect } from 'react';
import { useLoaderData } from 'react-router-dom';

const GitHub = () => {
    
    // const [data, setData] = useState([]);

    // useEffect(() => {
    //     fetch('https://api.github.com/users/hiteshchoudhary')
    //     .then(response => response.json())
    //     .then(data => setData(data))
    //     .catch(error => console.log(error));
    // }, []);

    const data = useLoaderData();
    return (
        <div className="m-auto max-w-7xl px-2 md:px-0 my-10">
            <div className="flex justify-center">
                <div>
                    <div
                        className="relative h-[350px] rounded-[10px]"
                        style={{
                        backgroundPosition: 'center',
                        backgroundSize: 'cover',
                        backgroundRepeat: 'no-repeat',
                        }}
                    >
                        <img
                        src={data.avatar_url}
                        alt=""
                        className="z-0 h-full w-full rounded-[10px] object-cover"
                        />
                        <div className="absolute bottom-4 left-4">
                            <h1 className="text-2xl font-semibold text-white">{data.name}</h1>
                            <h6 className="text-base text-white">Followers: <strong>{data.followers}</strong></h6>
                            <button type='button' className='rounded-md bg-white px-3 py-2 text-md font-bold text-black my-2'>
                                <a href="https://github.com/hiteshchoudhary/chai-aur-react/tree/main">
                                    View GitHub Profile
                                </a>
                            </button>
                        </div>
                    </div>
                </div>                    
            </div>
        </div>        
    );
}

export default GitHub;

export const gitHubInfoLoader = async() => {
    const response = await fetch('https://api.github.com/users/hiteshchoudhary');
    return response.json();
}
