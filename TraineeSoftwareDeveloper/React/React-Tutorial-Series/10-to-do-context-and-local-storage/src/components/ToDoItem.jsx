import React from 'react';
import { useToDo } from '../context/ToDoContext';
import { useState } from 'react';

const ToDoItem = ({toDo}) => {

    const [isToDoEditable, setIsToDoEditable] = useState(false);
    const [toDoMsg, setToDoMsg] = useState(toDo.toDo);
    const {updateToDo, deleteToDo, toggleComplete} = useToDo();

    const editToDo = () => {
        updateToDo(toDo.id, {...toDo, toDo: toDoMsg});
        setIsToDoEditable(false);
    }

    const toggleCompleted = () => {
        toggleComplete(toDo.id);
    }

    return (
        <div
            className={`flex border border-black/10 rounded-lg px-3 py-1.5 gap-x-3 shadow-sm shadow-white/50 duration-300  text-black ${
                toDo.completed ? "bg-[#c6e9a7]" : "bg-[#ccbed7]"
            }`}
        >
            <input
                type="checkbox"
                className="cursor-pointer"
                checked={toDo.completed}
                onChange={toggleCompleted}
            />
            <input
                type="text"
                className={`border outline-none w-full bg-transparent rounded-lg ${
                    isToDoEditable ? "border-black/10 px-2" : "border-transparent"
                } ${toDo.completed ? "line-through" : ""}`}
                value={toDoMsg}
                onChange={(e) => setToDoMsg(e.target.value)}
                readOnly={!isToDoEditable}
            />
            {/* Edit, Save Button */}
            <button
                className="inline-flex w-8 h-8 rounded-lg text-sm border border-black/10 justify-center items-center bg-gray-50 hover:bg-gray-100 shrink-0 disabled:opacity-50"
                onClick={() => {
                    if (toDo.completed) return;

                    if (isToDoEditable) {
                        editToDo();
                    } else setIsToDoEditable((prev) => !prev);
                }}
                disabled={toDo.completed}
            >
                {isToDoEditable ? "📁" : "✏️"}
            </button>
            {/* Delete Todo Button */}
            <button
                className="inline-flex w-8 h-8 rounded-lg text-sm border border-black/10 justify-center items-center bg-gray-50 hover:bg-gray-100 shrink-0"
                onClick={() => deleteToDo(toDo.id)}
            >
                ❌
            </button>
        </div>
    );
}

export default ToDoItem;
