import axios from "axios";
import { useEffect, useState } from "react";
import { Link, useParams } from "react-router-dom";

function Read() {

    const [data, setData] = useState([]);
    const {id} = useParams();

    useEffect(() => {
        axios.get('http://localhost:3000/users/' + id)
             .then(res => setData(res.data))
             .catch(err => console.log(err));
    }, [])

    return(
        <div className="d-flex w-100 vh-100 justify-content-center align-items-center bg-light">
            <div className="w-50 border bg-white shadow px-5 pt-3 pb-5 rounded">
                <div className="mb-2">
                    <strong>Name: </strong> {data.name}
                </div>
                
                <div className="mb-2">
                    <strong>Email: </strong> {data.email}
                </div>

                <div className="mb-2">
                    <strong>Phone: </strong> {data.phone}
                </div>

                <div className="mb-2">
                    <strong>Country: </strong> {data.country}
                </div>

                <div className="mb-2">
                    <strong>Postal Code: </strong> {data.postalZip}
                </div>

                <Link to={`/update/${id}`} className="btn btn-warning">Update</Link> 
                <Link to='/' className="btn btn-secondary ms-3">Back</Link>
            </div>
        </div>
    )
}

export default Read
