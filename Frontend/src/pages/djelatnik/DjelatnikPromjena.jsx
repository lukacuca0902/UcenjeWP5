import DjelatnikService from "../../services/DjelatnikService"
import { Button, Row, Col, Form } from "react-bootstrap";
import moment from "moment";
import { Link, useNavigate, useParams } from "react-router-dom";
import { RouteNames } from "../../constants";
import { useEffect, useState } from "react";


export default function DjelatnikPromjena(){

    const [djelatnik,setDjelatnik] = useState({})
    const navigate = useNavigate()
    const routeParams = useParams()

    async function dohvatiDjelatnike(){
        const odgovor = await DjelatnikService.getBySifra(routeParams.id_djelatnik);
        if(odgovor.greska){
            alert(odgovor.poruka)
            return
        }
        setDjelatnik(odgovor.poruka)
        
    } 

    useEffect(()=>{
        dohvatiDjelatnike();
     },[])

     async function promjena(Djelatnik) {
        //console.log(smjer)
        //console.log(JSON.stringify(smjer))
        const odgovor = await DjelatnikService.promjena(routeParams.id_djelatnik,Djelatnik)
        if(odgovor.greska){
            alert(odgovor.poruka)
            return;
        }
        navigate(RouteNames.DJELATNIK_PREGLED)
    }

    function obradiSubmit(e){ // e je event
        e.preventDefault(); // nemoj odraditi zahtjev na server
        let podaci = new FormData(e.target)
        //console.log(podaci.get('naziv'))
        promjena({
            ime: podaci.get('ime'),
            prezime: podaci.get('prezime'),
            oib: podaci.get('oib')
        })
    }

    return(
        <>
        Promjena djelatnika
        <Form onSubmit={obradiSubmit}>

            <Form.Group controlId="ime">
                <Form.Label>Ime</Form.Label>
                <Form.Control type="text" name="ime" required defaultValue={djelatnik.ime}/>

            </Form.Group>

            <Form.Group controlId="prezime">
                <Form.Label>Prezime</Form.Label>
                <Form.Control type="text" name="prezime" required defaultValue={djelatnik.prezime}/>
            </Form.Group>


            <Form.Group controlId="oib">
                <Form.Label>Oib</Form.Label>
                <Form.Control type="number" step={0.01} name="oib" required defaultValue={djelatnik.oib}/>
            </Form.Group>


        <Row className="akcije">
            <Col xs={6} sm={12} md={3} lg={6} xl={6} xxl={6}>
            <Link to={RouteNames.DJELATNIK_PREGLED} 
            className="btn btn-danger siroko">Odustani</Link>
            </Col>
            <Col xs={6} sm={12} md={9} lg={6} xl={6} xxl={6}>
            <Button variant="success"
            type="submit"
            className="siroko">Promijeni djelatnika</Button>
            </Col>
        </Row>
        </Form>
        </>
    )
}