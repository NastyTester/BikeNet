import { Link } from "react-router-dom"

export default function Home() {

    return(
        <div>
            This is the home screen
            <Link to="feed"> go to feed</Link>
        </div>
    )
}