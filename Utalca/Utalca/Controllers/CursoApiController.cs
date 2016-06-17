using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Utalca.Controllers
{
    public class CursoApiController : ApiController
    {


        // GET: api/CursoApi/ID
        public string Get(long id)
        {
            return "value";
        }

        // PUT: api/
        public void Post(long idCurso, long idClase, long idParticipante)
        {
            var servicio = new ControlAsistencia.ControlAsistenciaClient();
            servicio.RegistrarAsistencia(idParticipante, idCurso, idClase);
        }

    }
}
