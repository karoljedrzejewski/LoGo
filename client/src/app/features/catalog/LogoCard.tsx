import { Card, CardHeader, Avatar, CardMedia, CardContent, Typography, CardActions, Button } from "@mui/material";
import { Link } from "react-router-dom";
import { Logo } from "../../models/logos";

interface Props {
    logo: Logo;
}
export default function LogoCard({ logo }: Props) {
    return (
        <Card>
            <CardHeader
                avatar={
                    <Avatar sx={{color: 'silver', bgcolor: 'black'}}>
                        {logo.name.charAt(0).toUpperCase()}
                    </Avatar>
                }
                title={logo.name}
                titleTypographyProps={{
                    sx: {fontWeight: 900, color: 'primary.main'}
                }}
                />
            <CardMedia
                sx={{height: 140, backgroundSize: 'contain', bgcolor: '#white'}}
                image={logo.pictureUrl}
                title={logo.name}
            />
            <CardContent>
                <Typography gutterBottom color="secondary" variant="h5">
                    ${(logo.price / 100).toFixed(2)}
                </Typography>
                <Typography variant="body2" color="text.secondary">
                    {logo.description}
                </Typography>
            </CardContent>
            <CardActions>
                <Button size="small">Add to cart</Button>
                <Button component={Link} to={`/catalog/${logo.id}`} size="small">View</Button>
            </CardActions>
        </Card>
    )
}