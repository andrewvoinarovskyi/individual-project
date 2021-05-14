import React, {Component, useEffect} from 'react';
import { useDispatch } from "react-redux";

import Post from "./Post/Post";
import { download } from '../../store/posts/reducer';

const Posts = () => {

    const dispatch = useDispatch();

    const nums = [1, 2];
    return (
        <>
            <div>
                {nums.map((num, i) => <Post number={num} key={i} />)}
            </div>
            <button onClick={() => dispatch(download())}>download</button>
        </>
    );
}

export default Posts;