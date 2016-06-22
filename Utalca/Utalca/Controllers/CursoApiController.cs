using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Utalca.Controllers
{
    public class Registro
    {
       public long idCurso { get; set; }
       public long idClase { get; set; }
       public long idParticipante { get; set; }
    }




    public class CursoApiController : ApiController
    {


        // GET: api/CursoApi/ID
        public string Get(long id)
        {
            return "value";
        }

        // POST: api/
        [HttpPost]
        public void RegistroAsistencia(string id, [FromBody] Registro r  )
        {
            var servicio = new ControlAsistencia.ControlAsistenciaClient();
            servicio.RegistrarAsistencia(r.idParticipante, r.idCurso, r.idClase);
        }

    }
}
