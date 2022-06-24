import { useState, useEffect } from "react";
import { Logo } from "../../models/logos";
import LogoList from "./LogoList";


export default function Catalog() {
    const [logos, setLogos] = useState<Logo[]>([]);

    useEffect(() => {
        fetch('http://localhost:5000/api/logos')
            .then(response => response.json())
            .then(data => setLogos(data))
    }, [])
    return (
        <>
            <LogoList logos={logos} />
        </>
    )
}