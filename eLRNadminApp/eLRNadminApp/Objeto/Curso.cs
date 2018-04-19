using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
id_cur, carrera_id_carrera, id_fac, nombre_cur, descrip_cur, creditos_ot, creditos_nec, nota_min, zona_min

namespace eLRNadminApp.Objeto
{
    class Curso
    {
        public int IdCurso { get; set; }
        public int IdCarrera { get; set; }
        public int IdFacultad { get; set; }
        public int credNec { get; set; }
        public int credOtor { get; set; }
        public int notaMin { get; set; }
        public int notaMax { get; set; }
        public string nombreCurso { get; set; }

        public Curso(int id, int IdCarreraP, int IdFacultadP, int credNecP, int credOtorP, int notaMinP, int notaMaxP, string nombreCursoP)
        {
            this.IdCarrera = id;
            this.IdFacultad = IdFacultadP;
            this.credNec = credNecP;
            this.credOtor = credOtorP;
            this.notaMin = notaMinP;
            this.notaMax = notaMaxP;
            this.nombreCurso = nombreCursoP;

        }
    }
}
