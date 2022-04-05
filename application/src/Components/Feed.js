import NavBar from "./NavBar";
import React, { useState, useEffect } from 'react';
import axios from 'axios';


export default function Feed() {
    const [data, setData] = useState({ posts: [] });

    // https://www.robinwieruch.de/react-hooks-fetch-data/
    // https://www.youtube.com/watch?v=egITMrwMOPU&t=2s

    useEffect(async () => {
        const result = await axios(
          'https://localhost:7134/feed',
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