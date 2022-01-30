using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using smartHome.Modelos;

namespace CepHome.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class Lucas : ControllerBase
    {
        [HttpGet("sala/{id}")]
        public Sala Sala(int id)
        {
            Sala sala = new Sala();

            sala.Id = 1;
            //sala.Sofa = "sofa";
            sala.Tv = "tv";
            sala.Impressora = "impressora";

            Sala cozinha = new Sala()
            {
                Id = 2,
                Sofa = "pia",
                Tv = "fogão",
                Impressora = "geladeira"

            };

            Sala banheiro = new Sala()
            {
                Id = 3,
                Sofa = "vaso",
                Tv = "choveuro",
                Impressora = "pia"

            };

            Sala retorno = new();

            if (id == 1)
                retorno = sala;

            if (id == 3)
                retorno = banheiro;

            if (id == 2)
                retorno = cozinha;

            if (retorno == null)
                return null;


            return retorno;
        }
    }
}
