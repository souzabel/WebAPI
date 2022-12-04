using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using WebAPI.DAL;
using WebAPI.Models;


namespace WebAPI.Controllers

{
    public class TipoProdutoController : ApiController
    {
        // Método responsável por listar os Tipos de Produtos
        public IHttpActionResult Get()
        {
            return Ok(new TipoProdutoDAL().Listar());
        }

        // Método responsável por consultar o detalhe de um Tipo
        public IHttpActionResult Post([FromBody] TipoProduto TipoProduto)
        {
            try
            {
                // Cria o objeto DAL
                TipoProdutoDAL dal = new TipoProdutoDAL();
                // Insere a informação do banco de dados
                dal.Inserir(TipoProduto);

                // Cria uma propriedade para efetuar a consulta da informação cadastrada
                string location =
                    Url.Link("DefaultApi",
                    new { controller = "tipoproduto", id = TipoProduto.IdTipo });

                return Created(new Uri(location), TipoProduto);
            }
            catch (Exception)
            {
                return BadRequest();
            }
        }

        public IHttpActionResult Delete(int id)
        {
            try
            {
                TipoProdutoDAL dal = new TipoProdutoDAL();
                dal.Excluir(id);
                return Ok();
            }
            catch (Exception)
            {
                return BadRequest();
            }
        }

        public IHttpActionResult Put([FromBody] TipoProduto tipoProduto)
        {
            try
            {
                TipoProdutoDAL dal = new TipoProdutoDAL();
                dal.Alterar(tipoProduto);
                return Ok();
            }
            catch (Exception)
            {
                return BadRequest();
            }
        }



    }
}