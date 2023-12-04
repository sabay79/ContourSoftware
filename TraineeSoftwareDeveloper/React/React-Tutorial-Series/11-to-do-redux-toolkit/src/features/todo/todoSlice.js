import {createSlice, nanoid} from '@reduxjs/toolkit';

const initialState  = {
    todos: [
        {id:1, text:'Hello World'}
    ]
};

export const todoSlice = createSlice({
    name: 'todo',
    initialState,
    reducers: {
        addTodo: (state, action) => {
            const todo = { 
                id: nanoid(),
                text: action.payload
            };
            if(todo.text)
            {
                state.todos.push(todo);
            } else{
                alert("Can't Add An Empty Item");
            }
        },

        removeTodo: (state, action) => {
            state.todos = state.todos.filter((todo) => todo.id !== action.payload);
        },

        // updateTodo: (state, action) => {
        //     state.todos = state.todos.map((prevTodo) => prevTodo.id === action.payload.id ? action.payload : prevTodo); // To Be Verified
        // }
    }
});

export const {addTodo, removeTodo, updateTodo} = todoSlice.actions;

export default todoSlice.reducer;
