// Working with Forms

import { useState } from "react";

export default function Contact() {

    const [name, setName] = useState("Saba Y");
    const [email, setEmail] = useState("saba@email.com");
    const [message, setMessage] = useState("Hi there!");

    const onSubmitForm = (e) => {
        e.preventDefault();
        console.log(e);
        console.log("Hey, the form has been submitted...")

        const formBody = {
            name, 
            email,
            message
        };
        console.log(formBody);

        // Make API Call
    }
    return(
        <form onSubmit={onSubmitForm}>
            <input type="text" value={name} placeholder="Saba"
                onChange={(e) => {
                    setName(e.target.value);
                }} />

            <input type="text" value={email} placeholder="saba@email.com"
                onChange={(e) => {
                    setEmail(e.target.value);
                }} />

            <br /><br />

            <textarea value={message} placeholder="Hi there!"
                onChange={(e) => {
                    setMessage(e.target.value)
                }} >
            </textarea>

            <br /><br />

            <input type="submit" value="SUBMIT" />
        </form>
    );
}
