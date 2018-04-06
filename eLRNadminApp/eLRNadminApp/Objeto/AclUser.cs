using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eLRNadminApp.Objeto
{
    public class AclUser : IEquatable<AclUser>
    {
        public int ModuloID { get; set; }
        public string ModuloNombre { get; set; }
        public Int16 ModuloEscitura { get; set; }
        public Int16 ModuloEdicion { get; set; }
        public Int16 ModuloeEliminar { get; set; }
        public Int16 ModuloeImprimir { get; set; }
        public Int16 ModuloConsultar { get; set; }

        public AclUser(int id, string nombre)
        {
            ModuloID = id;
            ModuloNombre = nombre;
        }

        public bool Equals(AclUser acl) {
            if (acl == null) return false;
            if (this.ModuloID == acl.ModuloID) return true;
            else return false;
        }

        public override bool Equals(Object obj)
        {
            if (obj == null)
                return false;

            AclUser aclObj = obj as AclUser;
            if (aclObj == null)
                return false;
            else
                return Equals(aclObj);
        }

        public override int GetHashCode()
        {
            return this.ModuloID.GetHashCode();
        }

        public static bool operator == (AclUser acl1, AclUser acl2)
        {
            if( ((object)acl1) == null ||((object)acl2 == null))
            {
                return Object.Equals(acl1, acl2);
            }

            return acl1.Equals(acl2);
        }

        public static bool operator !=(AclUser acl1, AclUser acl2)
        {
            if (((object)acl1) == null || ((object)acl2 == null))
            {
                return !Object.Equals(acl1, acl2);
            }

            return !(acl1.Equals(acl2));
        }
    }
}
