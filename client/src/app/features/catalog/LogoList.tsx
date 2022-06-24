import { Grid } from "@mui/material";
import { Logo } from "../../models/logos";
import LogoCard from "./LogoCard";

interface Props {
    logos: Logo[];
}

export default function LogoList({logos}: Props){
    return(
        <Grid container spacing={4}>
            {logos.map(logo => (
                <Grid item xs={4} key={logo.id} >
                <LogoCard logo={logo}/>
                </Grid>
        ))}
        </Grid>
    )
}