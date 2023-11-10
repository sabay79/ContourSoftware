import axios from "axios";
import { useState } from "react"
import { Link, useNavigate } from "react-router-dom";

function Create() {
    
    const [values, setValues] = useState({
        name: '',
        email: '',
        phone: '',
        country: '',
        postalZip: ''
    })

    const navigate = useNavigate();

    const handleSubmit = (event) => {
        event.preventDefault();

        axios.post('http://localhost:3000/users', values)
             .then(res => {
                console.log(res);
                navigate('/');
             })
             .catch(err => console.log(err));
    }

    return(
        <div className="d-flex w-100 vh-100 justify-content-center align-items-center bg-light">
            <div className="w-50 border bg-white shadow px-5 pt-3 pb-5 rounded">

                <h1>Create New User</h1>

                <form onSubmit={handleSubmit}>
                    <div className="mb-2">
                        <label htmlFor="name">Name:</label>
                        <input type="text" name="name" className="form-control" placeholder="Enter Name" 
                            onChange={e => setValues({...values, name: e.target.value})} required />
                    </div>

                    <div className="mb-2">
                        <label htmlFor="email">Email:</label>
                        <input type="email" name="email" className="form-control" placeholder="Enter Email" 
                            onChange={e => setValues({...values, email: e.target.value})} required />
                    </div>

                    <div className="mb-2">
                        <label htmlFor="phone">Phone:</label>
                        <input type="text" name="phone" className="form-control" placeholder="Enter Phone" 
                            onChange={e => setValues({...values, phone: e.target.value})} />
                    </div>

                    <div className="mb-2">
                        <label htmlFor="country">Country:</label>
                        <input type="text" name="country" className="form-control" placeholder="Enter Country" 
                            onChange={e => setValues({...values, country: e.target.value})} required />
                    </div>

                    <div className="mb-3">
                        <label htmlFor="postalZip">Postal Code:</label>
                        <input type="text" name="postalZip" className="form-control" placeholder="Enter Postal Code" 
                            onChange={e => setValues({...values, postalZip: e.target.value})} />
                    </div>

                    <button className="btn btn-success">Submit</button>
                    <Link to='/' className="btn btn-secondary ms-3">Back</Link>
                </form>
            </div>
        </div>
    )
}

export default Create
