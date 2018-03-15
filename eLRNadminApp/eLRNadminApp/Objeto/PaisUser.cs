using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eLRNadminApp.Objeto
{
    class PaisUser : IEquatable<PaisUser>
    {
        //public int CmbIndex { get; set; }
        public string PaisNombre { get; set; }
        public int IdPais { get; set; }

        public PaisUser(int idpais, string nombre)
        {
            //CmbIndex = index;
            IdPais = idpais;
            PaisNombre = nombre;
        }

        public bool Equals(PaisUser upais)
        {
            if (upais == null) return false;
            if (this.PaisNombre == upais.PaisNombre) return true;
            else return false;
        }

        public override bool Equals(Object obj)
        {
            if (obj == null)
                return false;

            PaisUser paisObj = obj as PaisUser;
            if (paisObj == null)
                return false;
            else
                return Equals(paisObj);
        }

        public override int GetHashCode()
        {
            return this.PaisNombre.GetHashCode();
        }

        public static bool operator ==(PaisUser pais1, PaisUser pais2)
        {
            if (((object)pais1) == null || ((object)pais2 == null))
            {
                return Object.Equals(pais1, pais2);
            }

            return pais1.Equals(pais2);
        }

        public static bool operator !=(PaisUser pais1, PaisUser pais2)
        {
            if (((object)pais1) == null || ((object)pais2 == null))
            {
                return !Object.Equals(pais1, pais2);
            }

            return !(pais1.Equals(pais2));
        }
    }
}

