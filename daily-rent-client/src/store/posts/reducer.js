import React from "react";
import {createAsyncThunk, createSlice} from "@reduxjs/toolkit";

import URL from "../../URL";

const axios = require('axios');
const config = {
    headers: {'Access-Control-Allow-Origin': 'http://localhost:3000'}
}
const initialState = {
    value: [],
    status: 'idle',
};

const postsSlice = createSlice({
    name: 'posts',
    initialState,
    reducers: {
        download: (state) => {
            axios.get(URL)
                .then((response) => console.table(response))
                .catch((error) => console.log(error))
            state.value = [];
            state.status = 'download';
        }
    }
})

export const { download } = postsSlice.actions;

// The function below is called a selector and allows us to select a value from
// the state. Selectors can also be defined inline where they're used instead of
// in the slice file. For example: `useSelector((state: RootState) => state.counter.value)`
export const selectCount = (state) => state.posts.value;

export default postsSlice.reducer;