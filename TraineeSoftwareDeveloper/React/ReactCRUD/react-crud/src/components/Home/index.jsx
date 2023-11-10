import axios from "axios"
import { useEffect, useState } from "react"
import { Link, useNavigate } from "react-router-dom";

function Home() {
    const [data, setData] = useState([]);

    useEffect(() => {
        axios.get('http://localhost:3000/users')
             .then(res => setData(res.data))
             .catch(err => console.log(err));
    }, [])

    const handleDelete = (id) => {
        const confirm = window.confirm("Are you sure to Delete?");
        if(confirm) {
            axios.delete('http://localhost:3000/users/' + id)
                 .then(res => {
                    window.location.reload();
                 })
                 .catch(err => console.log(err));
        }
    }

    return(
        <div className="d-flex flex-column justify-content-center align-items-center bg-light vh-100">
            <h1>List of Users</h1>
            <div className="w-75 rounded bg-white border shadow p-4">

                <div className="d-flex justify-content-end">
                    <Link to="/create" className="btn btn-sm btn-primary">Create New User</Link>
                </div>
                
                <table className="table table-striped">
                    <thead>
                        <tr>
                            <th>Id</th>
                            <th>Name</th>
                            <th>Email</th>
                            <th>Phone</th>
                            <th>Country</th>
                            <th>Postal Code</th>
                            <th>Action</th>
                        </tr>
                    </thead>
                    <tbody>
                        {
                            data.map((data, index) => (
                                <tr key={{index}}>
                                    <td>{data.id}</td>
                                    <td>{data.name}</td>
                                    <td>{data.email}</td>
                                    <td>{data.phone}</td>
                                    <td>{data.country}</td>
                                    <td>{data.postalZip}</td>
                                    <td>
                                        <Link to={`/read/${data.id}`}  className="btn btn-sm btn-success me-2">Read</Link>
                                        <Link to={`/update/${data.id}`} className="btn btn-sm btn-warning me-2">Update</Link>
                                        <button onClick={e => handleDelete(data.id)} className="btn btn-sm btn-danger me-2">Delete</button>
                                    </td>
                                </tr>
                            ))
                        }
                    </tbody>
                </table>
            </div>
        </div>
    )
}

export default Home
