using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cuenta_Por_Pagar
{
   public class DatosProveedores
    {
        public static List<PROVEEDORESvictorP> MostrarDatos()
        {
            using (SCXPvictorPEntities BD = new SCXPvictorPEntities())
            {
                var Info = (from P in BD.PROVEEDORESvictorP select P).ToList();
                return Info;
            }
        }
        public static List<PROVEEDORESvictorP> BuscarCodigo(string Codigo)
        {
            using (SCXPvictorPEntities BD = new SCXPvictorPEntities())
            {
                var Info = (from P in BD.PROVEEDORESvictorP
                            where P.CODIGO.StartsWith(Codigo)
                            select P).ToList();
                return Info;
            }
        }
        public static List<PROVEEDORESvictorP> BuscarNombre(string Nombre)
        {
            using (SCXPvictorPEntities BD = new SCXPvictorPEntities())
            {
                var info = (from P in BD.PROVEEDORESvictorP
                            where P.NOMBRES.StartsWith(Nombre)
                            select P).ToList();
                return info;
            }
        }
        public static List<PROVEEDORESvictorP> BuscarApellido(string Apellido)
        {
            using (SCXPvictorPEntities BD = new SCXPvictorPEntities())
            {
                var info = (from P in BD.PROVEEDORESvictorP
                            where P.APELLIDOS.StartsWith(Apellido)
                            select P).ToList();
                return info;
            }
        }
        public static List<PROVEEDORESvictorP> BuscarDireccion(string Direccion)
        {
            using (SCXPvictorPEntities BD = new SCXPvictorPEntities())
            {
                var info = (from P in BD.PROVEEDORESvictorP
                            where P.DIRECCION.StartsWith(Direccion)
                            select P).ToList();
                return info;
            }
        }
        public static List<PROVEEDORESvictorP> BuscarCiudad(string Ciudad)
        {
            using (SCXPvictorPEntities BD = new SCXPvictorPEntities())
            {
                var info = (from P in BD.PROVEEDORESvictorP
                            where P.CIUDAD.StartsWith(Ciudad)
                            select P).ToList();
                return info;
            }
        }
        public static List<PROVEEDORESvictorP> BuscarTelefono(string Telefono)
        {
            using (SCXPvictorPEntities BD = new SCXPvictorPEntities())
            {
                var info = (from P in BD.PROVEEDORESvictorP
                            where P.TELEFONO.StartsWith(Telefono)
                            select P).ToList();
                return info;
            }
        }
        public static void InsertarProveedor
            (String Codigo, String Nombre, String Apellido, String Direccion, String Ciudad, String Telefono)
        {
            using (SCXPvictorPEntities BD = new SCXPvictorPEntities())
            {
                
                    BD.PROVEEDORESvictorP.Add(new PROVEEDORESvictorP
                    {
                        CODIGO = Codigo,
                        NOMBRES = Nombre,
                        APELLIDOS = Apellido,
                        DIRECCION = Direccion,
                        CIUDAD = Ciudad,
                        TELEFONO = Telefono
                    });
                    BD.SaveChanges();
                
            }
        }
        public static void ModificarProveedor
            (string Codigo,string Nombres,string Apellidos,string Direccion,string Ciudad,string Telefono)
        {
            using (SCXPvictorPEntities BD = new SCXPvictorPEntities())
            {
                var Modificar = (from P in BD.PROVEEDORESvictorP where P.CODIGO == Codigo select P).Single();
                Modificar.CODIGO = Codigo;
                Modificar.NOMBRES = Nombres;
                Modificar.APELLIDOS = Apellidos;
                Modificar.DIRECCION = Direccion;
                Modificar.CIUDAD = Ciudad;
                Modificar.TELEFONO = Telefono;
                BD.SaveChanges();
            }
        }
        public static void EliminarProveedor(string Codigo)
        {
            using (SCXPvictorPEntities BD = new SCXPvictorPEntities())
            {
                var Eliminar = (from P in BD.PROVEEDORESvictorP where P.CODIGO == Codigo select P).Single();
                BD.PROVEEDORESvictorP.Remove(Eliminar);
                BD.SaveChanges();
            }
        }
        public static PROVEEDORESvictorP Cargar(string Codigo)
        {
            PROVEEDORESvictorP Proveedores = new PROVEEDORESvictorP();
            using (SCXPvictorPEntities BD = new SCXPvictorPEntities())
            {
                var INFO = (from P in BD.PROVEEDORESvictorP where P.CODIGO == Codigo select P).Single();
                Proveedores.CODIGO = INFO.CODIGO;
                Proveedores.NOMBRES = INFO.NOMBRES;
                Proveedores.APELLIDOS = INFO.APELLIDOS;
                Proveedores.DIRECCION = INFO.DIRECCION;
                Proveedores.CIUDAD = INFO.CIUDAD;
                Proveedores.TELEFONO = INFO.TELEFONO;

                return Proveedores;
            }
        }
    }
}
