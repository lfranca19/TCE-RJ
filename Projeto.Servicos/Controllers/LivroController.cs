using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using Projeto.Servicos.Models;
using Projeto.DAL.Repositorios;
using Projeto.Entidades;
using System.Web;

namespace Projeto.Servicos.Controllers
{
    [RoutePrefix("api/livro")]
    public class LivroController : ApiController
    {

        [HttpPost]
        [Route("cadastrar")]
        public HttpResponseMessage Cadastrar(LivroCadastroModel model)
        {
            if (ModelState.IsValid)
            {
                try
                {
                    LivroRepositorio rep = new LivroRepositorio();


                    Livro l = new Livro();
                    l.ISBN = model.ISBN;
                    l.Autor = model.Autor;
                    l.Nome = model.Nome;
                    l.Preco = model.Preco;
                    l.Data_Publicacao = model.Data_Publicacao;
                    l.Imagem_Capa = model.Imagem_Capa;

                    rep.Insert(l);

                    return Request.CreateResponse(HttpStatusCode.OK, $"Livro {l.Nome}, cadastrado com sucesso.");
                    
                }
                catch (Exception e)
                {

                    return Request.CreateResponse(HttpStatusCode.InternalServerError, e.Message);
                }

            }
            else
            {
                List<string> lista = ListarErros();
                return Request.CreateResponse(HttpStatusCode.BadRequest, lista);
            }
            

        }
        private List<string> ListarErros()
        {

            List<string> lista = new List<string>();

            foreach (var m in ModelState)
            {

                if (m.Value.Errors.Count > 0)
                {
                    lista.Add(m.Value.Errors.Select(e => e.ErrorMessage).FirstOrDefault());
                }
            }

            return lista;
        }

        [HttpPut]
        [Route("alterar")]
        public HttpResponseMessage Alterar(LivroCadastroModel model)
        {

            try
            {
                LivroRepositorio rep = new LivroRepositorio();


                Livro l = new Livro();
                l.ISBN = model.ISBN;
                l.Autor = model.Autor;
                l.Nome = model.Nome;
                l.Preco = model.Preco;
                l.Data_Publicacao = model.Data_Publicacao;
                l.Imagem_Capa = model.Imagem_Capa;

                rep.Insert(l);

                return Request.CreateResponse(HttpStatusCode.OK, $"Livro {l.Nome}, alterado com sucesso.");
                //}
            }
            catch (Exception e)
            {

                return Request.CreateResponse(HttpStatusCode.InternalServerError, e.Message);
            }

        }

        [HttpPost]
        [Route("consultar")]
        public HttpResponseMessage Consultar(LivroFiltroConsultaModel model)
        {

            try
            {
                LivroRepositorio rep = new LivroRepositorio();                                     

                List<Livro> livros = rep.SelectAllLivro(model.ISBN, model.Autor, model.Nome, model.Preco_Ini, model.Preco_Fim, model.Data_Ini, model.Data_Fim);

                List<LivroConsultaModel> lista = new List<LivroConsultaModel>();

                foreach (Livro l in livros)
                {
                    LivroConsultaModel item = new LivroConsultaModel();
                    item.ISBN = l.ISBN;
                    item.Autor = l.Autor;
                    item.Nome = l.Nome;
                    item.Preco = l.Preco;
                    item.Data_Publicacao = l.Data_Publicacao;
                    item.Imagem_Capa = l.Imagem_Capa;

                    lista.Add(item);

                }

                return Request.CreateResponse(HttpStatusCode.OK, lista);
                //}
            }
            catch (Exception e)
            {

                return Request.CreateResponse(HttpStatusCode.InternalServerError, e.Message);
            }

        }

        

    }

        
}

