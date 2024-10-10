import { useEffect, useState } from "react"
import DjelatnikService from "../../services/DjelatnikService"
import { Button, Table } from "react-bootstrap";
import { NumericFormat } from "react-number-format";
import moment from "moment";
import { GrValidate } from "react-icons/gr";
import { Link, useNavigate } from "react-router-dom";
import { RouteNames } from "../../constants";



export default function DjelatnikPregled(){

    const navigate = useNavigate()

    const[djelatnici, setDjelatnici] = useState();

    async function dohvatiDjelatnike(){
        const odgovor = await DjelatnikService.get();
        if(odgovor.greska){
            alert(odgovor.poruka)
            return
        }
        //debugger; // ovo radi u Chrome inspect (ali i ostali preglednici)
        setDjelatnici(odgovor.poruka)
    } 

    // Ovaj hook (kuka) se izvodi dolaskom na stranicu djelatnici
    useEffect(()=>{
        dohvatiDjelatnike();
    },[])

 

    function obrisi(id_djelatnik){
        if(!confirm('Sigurno obrisati')){
            return;
        }
        brisanjeDjelatnika(id_djelatnik)
    }

    async function brisanjeDjelatnika(id_djelatnik) {
        
        const odgovor = await DjelatnikService.brisanje(id_djelatnik);
        if(odgovor.greska){
            alert(odgovor.poruka)
            return
        }
        dohvatiDjelatnike();
    }


    return(
        <>
        <Link to={RouteNames.DJELATNIK_DODAJ}
        className="btn btn-success siroko">Dodaj novog djelatnika</Link>
        <Table striped bordered hover responsive>
            <thead>
                <tr>
                    <th>Ime</th>
                    <th>Prezime</th>
                    <th>OIB</th>
                    
                </tr>
            </thead>
            <tbody>
                {djelatnici && djelatnici.map((djelatnik,index)=>(
                    <tr key={index}>
                        <td>
                            {djelatnik.ime}
                        </td>
                        <td>
                            {djelatnik.prezime}
                        </td>
                        <td>
                            {djelatnik.oib}
                        </td>
                       
                        <td>
                            <Button
                            variant="danger"
                            onClick={()=>obrisi(djelatnik.id_djelatnik)}
                            >
                                Obriši
                            </Button>
                            &nbsp;&nbsp;&nbsp;
                            <Button
                            onClick={()=>navigate(`/djelatnici/${djelatnik.id_djelatnik}`)}
                            >
                                Promjena
                            </Button>
                        </td>
                    </tr>
                ))}
            </tbody>
        </Table>
        </>
    )
}