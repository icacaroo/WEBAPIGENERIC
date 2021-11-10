using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using Biblioteca.Classes;

namespace WEBAPIGENERIC.Controllers
{
    public class PatrimonioController : ApiController
    {
        // GET: api/Patrimonio
        public IEnumerable<Patrimonio> Get()
        {
            return new Patrimonio().GetAll();
        }

        // GET: api/Patrimonio/5
        public Patrimonio Get(int id)
        {
            return new Patrimonio(id);
        }

        // POST: api/Patrimonio
        public void Post(string nome, int marca, string descricao)
        {
            Patrimonio patri = new Patrimonio();

            patri.Descricao = descricao;
            patri.MarcaID = marca;
            patri.Nome = nome;
         

            try
            {
                patri.Insertpatri();
            }
            catch (Exception)
            {
                throw;
            }

        }

        // PUT: api/Patrimonio/5
        public void Put(int id, string nome , int marca , string descricao/*, Patrimonio value*/)
        {

            Patrimonio patri = new Patrimonio(id);
             
            patri.Descricao = descricao;
            patri.MarcaID = marca;
            patri.Nome = nome;
             
            try
            {
                patri.Update();
            }
            catch (Exception)
            {
                throw;
            }
        }

        // DELETE: api/Patrimonio/5
        public void Delete(int id)
        {

            Patrimonio patri = new Patrimonio(id);

            try
            {
                patri.Delete();
            }
            catch (Exception)
            {
                throw;
            }

        }
    }
}
