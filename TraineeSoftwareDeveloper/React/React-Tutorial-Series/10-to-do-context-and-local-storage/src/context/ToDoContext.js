import { useContext } from "react";
import { createContext } from "react";

export const ToDoContext = createContext({
    todos: [
        {
            id: Date.now(),
            toDo: 'Todo Message',
            completed: false,
        }
    ],
    addToDo: (toDo) => {},
    updateToDo: (id, toDo) => {},
    deleteToDo: (id) => {},
    toggleComplete: (id) => {}
});

export const useToDo = () => {
    return useContext(ToDoContext);
}

export const ToDoProvider = ToDoContext.Provider;
 