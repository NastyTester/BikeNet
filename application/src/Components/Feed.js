import NavBar from "./NavBar";
import React, { useState, useEffect } from 'react';
import axios from 'axios';


export default function Feed() {
    const [data, setData] = useState({ posts: [] });

    useEffect(async () => {
        const result = await axios(
          'https://localhost:7134/Post/feed',
        );
            console.log(result)
        setData(result.data);
      });

    console.log(data);

    return(
        <div>
        <NavBar/>
            <ul>
                {data.posts.map(item => (
                <li key={item.Id}>
                    <p>item.Title</p>
                </li>
                ))}
            </ul>
        Soon data will be shown here
        </div>
    )
}