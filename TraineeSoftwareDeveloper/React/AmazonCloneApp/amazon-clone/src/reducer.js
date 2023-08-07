export const initialState = { basket: [], };

const reducer = (state, action) => {
    switch(state.type)
    {
        case "ADD_TO_BASKET":
            return{ ...state, basket: [...state.basket, action.item], };
    }
};
export default reducer;