using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using Biblioteca.Classes;

namespace WEBAPIPARTNER.Controllers
{
    public class MarcasController : ApiController
    {
        // GET: api/Marcas
        public IEnumerable<Marca> Get()
        {
            return new Marca().GetAll();
        }

        // GET: api/Marcas/5
        public Marca Get(int id)
        {
            return new Marca(id);
        }

        // POST: api/Marcas
        public IHttpActionResult Post(/*[FromBody]Marca value*/string nome)
        {

            var  Marca = new Marca();

            Marca.Nome = nome;
           

            try
            {
                Marca.Insert();
            }
            catch (Exception){
                
                throw;
            }

            return Ok();

        }

        // PUT: api/Marcas/5
        public void Put(int id, /*[FromBody]string value*/string nome)
        {
            Marca mar = new Marca(id);

            mar.MarcaID = id;
            mar.Nome = nome;

            try
            {
                mar.Update();
            }
            catch (Exception)
            {
                throw;
            }

          
        }

        // DELETE: api/Marcas/5
        public void Delete(int id)
        {
            Marca mar = new Marca(id);

            try
            {
                mar.Delete();
            }
            catch(Exception)
            {
                throw;
            }
            
        }
        // GET: api/marcas/patrimonio?id=
        [HttpGet]
        [Route("api/marcas/patrimonio")]
        public IEnumerable<Patrimonio> Listar(int id)
        {

            return new Patrimonio().GetAllpatri(id);
        }
    }
}
