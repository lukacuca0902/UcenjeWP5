import { HttpService } from "./HttpService";



async function get(){
    return await HttpService.get('/Djelatnik')
    .then((odgovor)=>{
        //console.log(odgovor.data)
        //console.table(odgovor.data)
        return {greska: false, poruka: odgovor.data}
    })
    .catch((e)=>{
        //console.log(e)
        return {greska: true, poruka: 'Problem kod dohvaćanja djelatnika'}   
    })
}

async function brisanje(id_djelatnik){
    return await HttpService.delete('/Djelatnik/' + id_djelatnik)
    .then(()=>{
        return {greska: false, poruka: 'Obrisano'}
    })
    .catch(()=>{
        return {greska: true, poruka: 'Problem kod brisanja djelatnika'}   
    })
}

async function dodaj(Djelatnik){
    return await HttpService.post('/Djelatnik',Djelatnik)
    .then(()=>{
        return {greska: false, poruka: 'Dodano'}
    })
    .catch(()=>{
        return {greska: true, poruka: 'Problem kod dodavanja djelatnika'}   
    })
}

async function promjena(id_djelatnik,Djelatnik){
    return await HttpService.put('/Djelatnik/' + id_djelatnik,Djelatnik)
    .then(()=>{
        return {greska: false, poruka: 'Dodano'}
    })
    .catch(()=>{
        return {greska: true, poruka: 'Problem kod dodavanja djelatnika'}   
    })
}

async function getBySifra(id_djelatnik){
    return await HttpService.get('/Djelatnik/' + id_djelatnik)
    .then((odgovor)=>{
        return {greska: false, poruka: odgovor.data}
    })
    .catch((e)=>{
        return {greska: true, poruka: 'Problem kod dohvaćanja djelatnika sa šifrom ' + id_djelatnik}   
    })
}

export default {
    get,
    brisanje,
    dodaj,
    promjena,
    getBySifra
}