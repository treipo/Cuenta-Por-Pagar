using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cuenta_Por_Pagar
{
    class DatosEstadoDeCuenta
    {
        public static List<ESTADODECUENTAS> MostarEstado()
        {
            using (SCXPvictorPEntities BD = new SCXPvictorPEntities())
            {
                var Info = (from E in BD.ESTADODECUENTAS select E).ToList();
                return Info;
            }
        }
        public static List<ESTADODECUENTAS> BuscarNumeroFactura(int NumeroFactura)
        {
            using (SCXPvictorPEntities BD = new SCXPvictorPEntities())
            {
                var Info = (from E in BD.ESTADODECUENTAS where E.NUMEROFACTURA == NumeroFactura select E).ToList();
                return Info;
            }
        }
        public static List<ESTADODECUENTAS> BuscarCodigo(string Codigo)
        {
            using (SCXPvictorPEntities BD = new SCXPvictorPEntities())
            {
                var info = (from E in BD.ESTADODECUENTAS where E.CODIGO == (Codigo) select E).ToList();
                return info;
            }
        }
        

    }
}
