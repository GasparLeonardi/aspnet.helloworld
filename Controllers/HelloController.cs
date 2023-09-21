using Microsoft.AspNetCore.Mvc;

namespace helloworld.Controllers
{
    [Route("~/")]
    [ApiController]
    public class HelloController
    {
        [HttpGet]
        public string Hello()
        {
            return "Hello World and Turma .NET 03!";
        }

        [HttpGet("/bsm")]
        public string MeuNome()
        {
            return "Mentalidade de Crescimento\n" +
                "Persistência\n" +
                "Responsabilidade Pessoal\n" +
                "Orientação ao Futuro\n" +
                "Comunicação\n" +
                "Orientação ao Detalhe\n" +
                "Proatividade\n" +
                "Trabalho em Equipe\n";
        }

        [HttpGet("/objetivos")]
        public string Objetivos()
        {
            return "Aperfeiçoar o PI\n" +
                "Melhorar meu currilo\n" +
                "Aperfeiçoar meu Pitch Pessoal\n" +
                "Começar o projeto do blog pessoal\n";
        }
    }
}
