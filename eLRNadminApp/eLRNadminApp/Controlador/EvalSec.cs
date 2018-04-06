using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eLRNadminApp.Controlador
{
    static class EvalSec
    {
        private static int acceso = 0;
        private static List<Objeto.AclUser> list;

        public static void clearACLs()
        {
            if (list != null)
            {
                list.Clear();
                acceso = 0;
            }
        }

        public static int consultar(string stApp, int stSec)
        {
            try
            {
                list = Objeto.Common.ListAcl;
                foreach (Objeto.AclUser acl in list) {
                    acceso = 0;

                    switch(stSec){
                        case 1:
                            if (acl.ModuloNombre.Equals(stApp))
                            {
                                acceso = acl.ModuloEscitura;
                                return acceso;
                            }
                            break;

                        case 2:
                            if (acl.ModuloNombre.Equals(stApp))
                            {
                                acceso = acl.ModuloConsultar;
                                return acceso;
                                Console.Out.WriteLine(acl.ModuloID + acl.ModuloNombre + acl.ModuloConsultar + acl.ModuloEdicion + acl.ModuloeEliminar + acl.ModuloeImprimir + acl.ModuloEscitura);
                            }
                            break;

                        case 3:
                            if (acl.ModuloNombre.Equals(stApp))
                            {
                                acceso = acl.ModuloEdicion;
                                return acceso;
                            }
                            break;

                        case 4:
                            if (acl.ModuloNombre.Equals(stApp))
                            {
                                acceso = acl.ModuloeEliminar;
                                return acceso;
                            }
                            break;

                        case 5:
                            if (acl.ModuloNombre.Equals(stApp))
                            {
                                acceso = acl.ModuloeImprimir;
                                return acceso;
                            }
                            break;

                        default:
                            acceso = 0;
                            break;
                    }
                        //acceso = acl.ModuloConsultar;
                        //Console.Out.WriteLine(acl.ModuloID + acl.ModuloNombre + acl.ModuloConsultar + acl.ModuloEdicion + acl.ModuloeEliminar + acl.ModuloeImprimir + acl.ModuloEscitura);
                }
                return 0;
            }
            catch (Exception ex) { return 0; }
        }

        public static int ingresar(string stApp, int stSec)
        {
            try
            {
                //Objeto.AclUser aclAux = new Objeto.AclUser(null, stApp);
                List<Objeto.AclUser> list = Objeto.Common.ListAcl;
                   
                return acceso;
            }
            catch (Exception ex) { return 0; }
        }
    }
}
