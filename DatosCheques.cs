using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cuenta_Por_Pagar
{
    class DatosCheques
    {
        public static List<CHEQUESvictorP> MostarCheque()
        {
            using (SCXPvictorPEntities BD = new SCXPvictorPEntities())
            {
                var Info = (from C in BD.CHEQUESvictorP select C).ToList();
                return Info;
            }
        }
        public static List<CHEQUESvictorP> BuscarCheque(int NumeroCheque)
        {
            using (SCXPvictorPEntities BD = new SCXPvictorPEntities())
            {
                var Info = (from C in BD.CHEQUESvictorP
                            where C.NUMEROCHEQUE == NumeroCheque
                            select C).ToList();
                return Info;

            }
        }
        public static List<CHEQUESvictorP> BuscarNumeroFactura(int NumeroFactura)
        {
            using (SCXPvictorPEntities BD = new SCXPvictorPEntities())
            {
                var info = (from C in BD.CHEQUESvictorP
                            where C.NUMEROFACTURA == (NumeroFactura)
                            select C).ToList();
                return info;

            }
        }
        public static void AgregarCheque(int NumeroCheque, int NumeroFactura, decimal ValorCheque, DateTime FechaCheque)
        {

            using (SCXPvictorPEntities BD = new SCXPvictorPEntities())
            {
                BD.CHEQUESvictorP.Add(new CHEQUESvictorP
                {
                    NUMEROCHEQUE = NumeroCheque,
                    NUMEROFACTURA = NumeroFactura,
                    VALORCHEQUE = ValorCheque,
                    FECHACHEQUE = FechaCheque
                });
                BD.SaveChanges();
            }
        }
        public static void ModificarCheque(int NumeroCheque, int NumeroFactura, decimal ValorCheque, DateTime FechaCheque)
        {
            using (SCXPvictorPEntities BD = new SCXPvictorPEntities())
            {
                var Modificar = (from F in BD.CHEQUESvictorP where F.NUMEROCHEQUE == NumeroCheque select F).Single();
                Modificar.NUMEROCHEQUE = NumeroCheque;
                Modificar.NUMEROFACTURA = NumeroFactura;
                Modificar.VALORCHEQUE = ValorCheque;
                Modificar.FECHACHEQUE = FechaCheque;
                BD.SaveChanges();
            }
        }
        public static void ElimunarCheque(int NumeroCheque)
        {
            using (SCXPvictorPEntities BD = new SCXPvictorPEntities())
            {
                var Eliminar = (from F in BD.CHEQUESvictorP where F.NUMEROCHEQUE == NumeroCheque select F).Single();
                BD.CHEQUESvictorP.Remove(Eliminar);
                BD.SaveChanges();
            }
        }
        public static CHEQUESvictorP Cargar(int NumeroCheque)
        {
            CHEQUESvictorP Cheque = new CHEQUESvictorP();
            using (SCXPvictorPEntities BD = new SCXPvictorPEntities())
            {
                var INFO = (from F in BD.CHEQUESvictorP where F.NUMEROCHEQUE == NumeroCheque select F).Single();
                Cheque. NUMEROCHEQUE = INFO.NUMEROCHEQUE;
                Cheque.NUMEROFACTURA = INFO.NUMEROFACTURA;
                Cheque.VALORCHEQUE = INFO.VALORCHEQUE;
                Cheque.FECHACHEQUE = INFO.FECHACHEQUE;
                return Cheque;
            }
        }

    }


}
