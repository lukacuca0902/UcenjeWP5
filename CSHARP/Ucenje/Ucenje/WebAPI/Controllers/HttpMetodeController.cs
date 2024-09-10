using Microsoft.AspNetCore.Mvc;
using WebAPI.Models;

namespace WebAPI.Controllers
{

    [ApiController]
    [Route("api/v1/[controller]")]
    public class HttpMetodeController : ControllerBase
    {

        // ovdje počinje ruta
        [HttpGet]

        public string Pozdravi()
        {
            return "Hello world";
        }

        //ovdje zavrsava ruta





        // ovdje počinje ruta
        [HttpGet]
        [Route("Pozdravi")]
        public string Pozdravi(string ime)
        {
            return "Hello " + ime;
        }



        //ovdje zavrsava ruta


        //Kreirajte rutu naziva Zbroj koja prima dva cijela broja i vraća nazad njihov zbroj
        // ovdje počinje ruta
        [HttpGet]
        [Route("Zbroj")]

        public int Zbroj(int x, int y)
        {
            return x + y;
        }

        //ovdje zavrsava ruta




        // ovdje počinje ruta
        [HttpGet]
        [Route("Hello")]
        public IActionResult Pozdravi(int id, string ime)
        {
            return Ok(new { id = id, ime = ime });
        }
        //ovdje zavrsava ruta



        // ovdje počinje ruta
        [HttpPost]
        public IActionResult Post()
        {
            return BadRequest(new { greska = true, poruka = "Nesto ne valja" });
        }

        //ovdje zavrsava ruta

        // ovdje počinje ruta
        [HttpPut]
        public IActionResult Put(Osoba osoba)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(new { greska = true, poruka = "Nesto ne valja" });
            }
            osoba.Prezime = "g. " + osoba.Prezime;
            return StatusCode(StatusCodes.Status206PartialContent, osoba);
        }

        //ovdje zavrsava ruta



        // ovdje počinje ruta
        [HttpDelete]
        public IActionResult Delete(int id)
        {

            return NotFound(new { id = id, poruka = "Ne mogu pronaći", greška = true });

        }
        //ovdje zavrsava ruta
    }
}
