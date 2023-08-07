import React, {createContext, useContext, useReducer} from "react";

// Prepare the Data Layer
export const StateContext = createContext();

// Wrap our App and provide the Data Layer
export const StateProvider = ({ reducer, initialState, children}) => (
    <StateContext.Provider value={useReducer(reducer, initialState)}>
        {children}
    </StateContext.Provider>
);

// Pull information from the Data Layer
export const useStateValue = () => useContext(StateContext);