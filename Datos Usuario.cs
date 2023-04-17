using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cuenta_Por_Pagar
{
    class DatosUsuario
    {
        public static List<USUARIOSvictorP> Mostrar()
        {
            using (SCXPvictorPEntities BD = new SCXPvictorPEntities())
            {
                var Info = (from U in BD.USUARIOSvictorP select U).ToList();
                return Info;
            }
        }
        public static List<USUARIOSvictorP> BuscarUsuario(string Usuario)
        {
            using (SCXPvictorPEntities BD = new SCXPvictorPEntities())
            {
                var Info  = (from U in BD.USUARIOSvictorP
                            where U.USUARIO.StartsWith(Usuario)
                            select U).ToList();
                return Info;
               
            }
        }
        public static List<USUARIOSvictorP> BuscarClave(string Clave)
        {
            using (SCXPvictorPEntities BD = new SCXPvictorPEntities())
            {
                var info = (from U in BD.USUARIOSvictorP
                            where U.CLAVE.StartsWith(Clave)
                            select U).ToList();
                return info;

            }
        }
    }
}
