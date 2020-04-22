using System;
using System.Collections.Generic;
using System.Data.Odbc;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaDatos;
namespace CapaLogica
{
    public class Logica
    {
        Sentencias sn = new Sentencias();
        //----CONCEPTO
        //--------------------------------------------------MODIFICAR----------------------------------------------------//
        public OdbcDataReader modificarconcepto(string sCodigo, string sNombre, string sEfecto, string sestado)
        {
            return sn.modificarconcepto(sCodigo, sNombre, sEfecto, sestado);
        }
        //------------------------------------------------------ELIMINAR--------------------------------------------//
        public OdbcDataReader eliminarconcepto(string sCodigo)
        {
            return sn.eliminarconcepto(sCodigo);
        }
        //-----------------------------------------------------GUARDAR-------------------------------------------------//
        public OdbcDataReader guardarconcepto(string sCodigo, string sNombre, string sEfecto, string sestado)
        {
            return sn.guardarconcepto(sCodigo, sNombre, sEfecto, sestado);
        }
        //-----------------------------------------------------------------------------------------------------------//
        //----PUESTO
        //--------------------------------------------------MODIFICAR----------------------------------------------------//
        public OdbcDataReader modificarpuesto(string sCodigo, string sNombre, string sestado)
        {
            return sn.modificarpuesto(sCodigo, sNombre, sestado);
        }
        //------------------------------------------------------ELIMINAR--------------------------------------------//
        public OdbcDataReader eliminarpuesto(string sCodigo)
        {
            return sn.eliminarpuesto(sCodigo);
        }
        //-----------------------------------------------------GUARDAR-------------------------------------------------//
        public OdbcDataReader guardarpuesto(string sCodigo, string sNombre, string sestado)
        {
            return sn.guardarpuesto(sCodigo, sNombre, sestado);
        }
        //-----------------------------------------------------------------------------------------------------------//
        //----DEPARTAMENTO
        //--------------------------------------------------MODIFICAR----------------------------------------------------//
        public OdbcDataReader modificardepto(string sCodigo, string sNombre, string sestado)
        {
            return sn.modificardepto(sCodigo, sNombre, sestado);
        }
        //------------------------------------------------------ELIMINAR--------------------------------------------//
        public OdbcDataReader eliminardepto(string sCodigo)
        {
            return sn.eliminardepto(sCodigo);
        }
        //-----------------------------------------------------GUARDAR-------------------------------------------------//
        public OdbcDataReader guardardepto(string sCodigo, string sNombre, string sestado)
        {
            return sn.guardardepto(sCodigo, sNombre, sestado);
        }
        //-----------------------------------------------------------------------------------------------------------//
        //----EMPLEADO
        //--------------------------------------------------MODIFICAR----------------------------------------------------//
        public OdbcDataReader modificarempleado(string sCodigo, string sNombre, string sPuesto, string sDepartamento, float fSueldo, string sestado)
        {
            return sn.modificarempleado(sCodigo, sNombre,sPuesto, sDepartamento, fSueldo, sestado);
        }
        //------------------------------------------------------ELIMINAR--------------------------------------------//
        public OdbcDataReader borrarempleado(string sCodigo)
        {
            return sn.eliminarempleado(sCodigo);
        }
        //-----------------------------------------------------GUARDAR-------------------------------------------------//
        public OdbcDataReader guardarempleado(string sCodigo, string sNombre, string sPuesto, string sDepartamento, float fSueldo, string sestado)
        {
            return sn.guardarempleado(sCodigo, sNombre, sPuesto, sDepartamento, fSueldo, sestado);
        }
        //-----------------------------------------------------------------------------------------------------------//
    }
}
