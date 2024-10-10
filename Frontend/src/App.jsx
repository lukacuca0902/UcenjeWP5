import 'bootstrap/dist/css/bootstrap.min.css'
import Container from 'react-bootstrap/Container';
import './App.css'
import NavBarEdunova from './components/NavBarEdunova';
import { Route, Routes } from 'react-router-dom';
import { RouteNames } from './constants';
import Pocetna from './pages/Pocetna';
import DjelatnikPregled from './pages/djelatnik/DjelatnikPregled';
import DjelatnikDodaj from './pages/djelatnik/DjelatnikDodaj';
import DjelatnikPromjena from './pages/djelatnik/DjelatnikPromjena';


function App() {

  return (
    <>
    <Container>
      <NavBarEdunova />
      <Routes>
        <Route path={RouteNames.HOME} element={<Pocetna/>} />

        <Route path={RouteNames.DJELATNIK_PREGLED} element={<DjelatnikPregled/>}/>
        <Route path={RouteNames.DJELATNIK_DODAJ} element={<DjelatnikDodaj/>}/>
        <Route path={RouteNames.DJELATNIK_PROMJENA} element={<DjelatnikPromjena/>}/>

      </Routes>
      <hr/>
      &copy; Luka
    </Container>
    
    </>
  )
}

export default App