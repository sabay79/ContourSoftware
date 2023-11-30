import React, { useContext } from 'react';
import UserContext from '../context/UserContext';

const Profile = () => {

    const {user} = useContext(UserContext);

    if(!user){
        return(
            <p style={{color:'red'}}>
                <em>
                    Please Login!
                </em>
            </p>
        );
        }

    return(
        <p style={{color:'green'}}>
            <em>
                Welcome <strong>{user.username}</strong>
            </em>
        </p>
    );
}

export default Profile;
