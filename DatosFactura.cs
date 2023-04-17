using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cuenta_Por_Pagar
{
    class DatosFactura
    {

        public static List<FACTURASvictorP> MostarFactura()
        {
            using (SCXPvictorPEntities BD = new SCXPvictorPEntities())
            {
                var Info = (from F in BD.FACTURASvictorP select F).ToList();
                return Info;
            }
        }
        public static List<FACTURASvictorP> BuscarFactura(int NumeroFactura)
        {
            using (SCXPvictorPEntities BD = new SCXPvictorPEntities())
            {
                var Info = (from F in BD.FACTURASvictorP
                            where F.NUMEROFACTURA == NumeroFactura
                            select F).ToList();
                return Info;

            }
        }
        public static List<FACTURASvictorP> BuscarCodigoF(String Codigo)
        {
            using (SCXPvictorPEntities BD = new SCXPvictorPEntities())
            {
                var info = (from F in BD.FACTURASvictorP
                            where F.CODIGO == (Codigo)
                            select F).ToList();
                return info;

            }
        }
        public static void AgregarFactura(int NumeroFactura, string CodigoCliente, decimal ValorFactur, DateTime FechaFactura, DateTime FechaVencimiento)
        {

            using (SCXPvictorPEntities BD = new SCXPvictorPEntities())
            {
                BD.FACTURASvictorP.Add(new FACTURASvictorP
                {
                    NUMEROFACTURA = NumeroFactura,
                    CODIGO = CodigoCliente,
                    VALORFACTURA = ValorFactur,
                    FECHAFACTURA = FechaFactura,
                    FECHAVENCIMIENTO = FechaVencimiento,
                });
                BD.SaveChanges();
            }

        }
        public static void ModificarFactura(int NumeroFactura, string CodigoCliente, decimal ValorFactur, DateTime FechaFactura, DateTime FechaVencimiento)
        {

            using (SCXPvictorPEntities BD = new SCXPvictorPEntities())
            {
                var Modificar = (from F in BD.FACTURASvictorP
                                 where F.NUMEROFACTURA == NumeroFactura
                                 select F).Single();
                Modificar.NUMEROFACTURA = NumeroFactura;
                Modificar.CODIGO = CodigoCliente;
                Modificar.VALORFACTURA = ValorFactur;
                Modificar.FECHAFACTURA = FechaFactura;
                Modificar.FECHAVENCIMIENTO = FechaVencimiento;
                BD.SaveChanges();
            }
        }
        public static void ElimunarFactura(int NumeroFactura)
        {
            using (SCXPvictorPEntities BD = new SCXPvictorPEntities())
            {
                var Eliminar = (from F in BD.FACTURASvictorP
                               where F.NUMEROFACTURA == NumeroFactura
                               select F).Single();
                BD.FACTURASvictorP.Remove(Eliminar);
                BD.SaveChanges();
            }
        }
        public static FACTURASvictorP Cargar(int NumeroFactura)
        {
            FACTURASvictorP Factura = new FACTURASvictorP();
            using (SCXPvictorPEntities BD = new SCXPvictorPEntities())
            {
                var INFO = (from F in BD.FACTURASvictorP where F.NUMEROFACTURA == NumeroFactura select F).Single();
                Factura.NUMEROFACTURA = INFO.NUMEROFACTURA;
                Factura.CODIGO = INFO.CODIGO;
                Factura.VALORFACTURA = INFO.VALORFACTURA;
                Factura.FECHAFACTURA = INFO.FECHAFACTURA;
                Factura.FECHAVENCIMIENTO = INFO.FECHAVENCIMIENTO;
                return Factura;
            }
        }

    }
}
