import NavBar from "./NavBar";
import React, { useState, useEffect } from 'react';
import axios from 'axios';


export default function Feed() {
    const [data, setData] = useState({ posts: [] });
    const [isLoading, setIsLoading] = useState(false);

    // https://www.robinwieruch.de/react-hooks-fetch-data/
    // https://www.youtube.com/watch?v=egITMrwMOPU&t=2s

    useEffect(() => {
        const fetchData = async () => {
            setIsLoading(true);
            // const result = await axios(
            //     'https://localhost:7134/feed',
            // {
            //     method: "GET",
            //     headers: {"Content-type": "application/json;charset=UTF-8"}
            // })
            // .then(result => result.json()) 
            // .then(json => console.log(json)); 
            const result = await fetch("https://localhost:7134/feed",{
                     method: "GET",
                     headers: {
                        "Content-type": "application/json;charset=UTF-8",
                        "Accept": 'application/json'}
                 })
    // Handle success
    // .then(response => response.json())  // convert to json
            
            setData(result.data)
            setIsLoading(false);
        };

        fetchData();
    }, []);
        

    console.log(data);

    return(
        <div>
        <NavBar/>

        {isLoading ? (
        <div>Loading ...</div>
      ) : (
            <ul>
                {data.posts.map(item => (
                <li key={item.Id}>
                    <p>item.Title</p>
                </li>
                ))}
            </ul>
      )}
        Soon data will be shown here
        </div>
    )
}