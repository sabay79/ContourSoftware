// Working with API

import { useEffect, useState } from "react";

export default function ToDo() {

    const [todoId, setTodoId] = useState();
    const [todoName, setTodoName] = useState();

    useEffect(() => {

        async function todoItems(){
            console.log("hey, I'm called from useEffect");

            const res = await fetch("https://dummyjson.com/todos/1");
            const response = await res.json();

            console.log(response);

            setTodoId(response.id);
            setTodoName(response.todo);
        }

        todoItems();
    }, []);

    return(
        <div>
            <h3>ID: {todoId}</h3>
            <h3>ToDo: {todoName}</h3>
        </div>
    );
}
