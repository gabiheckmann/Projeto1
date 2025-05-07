using Microsoft.AspNetCore.Mvc;
using Projeto1.Repositorio;

namespace Projeto1.Controllers
{
    public class UsuarioController : Controller
    {
        /*DECLARANDO UMA VARIÁVEL PRIVADA SOMENTE PARA LEITURA DO TIPO UsuarioRepositorio chamada
        _usuarioRepositorio*/

        private readonly UsuarioRepositorio _usuarioRepositorio;

        // DEFININDO CONSTRUTOR DA CLASSE USUARIOCONTROLLER QUE VAI RECEBER UMA INSTANCIA DE UsuarioRepositorio
         public UsuarioController( UsuarioRepositorio usuarioRepositorio)
        {
            _usuarioRepositorio = usuarioRepositorio;
        }
        public IActionResult Login()
        {
            
            return View();
        }
        [HttpPost]
        public IActionResult Login( string email, string senha)
        {

            return View();
        }
        public IActionResult Contato()
        {
            return View();
        }
    }

}
