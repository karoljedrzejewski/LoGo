import { Grid, Typography, Divider, TableContainer, Table, TableBody, TableRow, TableCell } from "@mui/material";
import axios from "axios";
import { useState, useEffect } from "react";
import { useParams } from "react-router-dom";
import { Logo } from "../../models/logos";

export default function LogoDetails() {
    const {id} = useParams<{id: string}>();
    const [logo, setLogo] = useState<Logo | null>(null);
    const [loading, setLoading] = useState(true);

useEffect(() =>{
    axios.get(`http://localhost:5000/api/logos/${id}`)
    .then(response => setLogo(response.data))
    .catch(error => console.log(error))
    .finally(() => setLoading(false));
}, [id])

if (loading) return <h3>Loading...</h3>

if (!logo) return <h3>Logo not found</h3>
    return (
        <Grid container sx={{mt: 10}} spacing={6}>
            <Grid item xs={6}>
                <img src={logo.pictureUrl} alt={logo.name} style={{width: '100%'}}/>
            </Grid>
            <Grid>
                <Typography variant='h3'>{logo.name}</Typography>
                <Divider sx={{mb: 2}}/>
                <Typography variant='h4' color='secondary'>{"$"+(logo.price / 100).toFixed(2)}</Typography>
                <TableContainer>
                    <Table>
                        <TableBody>
                            <TableRow>
                                <TableCell>Name</TableCell>
                                <TableCell>{logo.name}</TableCell>
                            </TableRow>
                            <TableRow>
                                <TableCell>Description</TableCell>
                                <TableCell>{logo.description}</TableCell>
                            </TableRow>
                            <TableRow>
                                <TableCell>Availability</TableCell>
                                <TableCell>{logo.availability}</TableCell>
                            </TableRow>
                            <TableRow>
                                <TableCell>Characteristics</TableCell>
                                <TableCell>{logo.characteristics}</TableCell>
                            </TableRow>
                        </TableBody>
                    </Table>
                </TableContainer>
            </Grid>
        </Grid>
    )
}