using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;


namespace DAL
{
    public class Cls_Ventanas_DAL
    {
        private DB_ConstruccionesEntities miContexto = new DB_ConstruccionesEntities();
        public Array ListaVentanas()
        {
            try
            {
               var ListaVentanas =
                    from ventanas in miContexto.ventanas
                    select new
                    {
                       ID_Ventana = ventanas.idventana,
                       Nombre= ventanas.nombre
                    };
                return ListaVentanas.ToArray();

            }
            catch (Exception ex)
            {
                throw ex;
            }

        }

        public ventanas ConsultarVentana(int pIdVentana)
        {
            try
            {
                return miContexto.ventanas.Single(ventanas => ventanas.idventana == pIdVentana);
            }
            catch
            {
                throw new Exception("Datos de usuario invalidos");
            }
        }



        public void Agregar(ventanas ventanas)
        {
            try
            {
                using (DB_ConstruccionesEntities contexto = new DB_ConstruccionesEntities())
                {
                    contexto.ventanas.Add(ventanas);
                    contexto.SaveChanges();
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public ventanas Consultar(int idVentana)
        {
            try
            {
                return miContexto.ventanas.Single(ventanas => ventanas.idventana == idVentana);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void Modificar(ventanas pVentanas)
        {
            try
            {
                ventanas ventana = Consultar(pVentanas.idventana);
                ventana.nombre = pVentanas.nombre;
                miContexto.SaveChanges();

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void Eliminar(int idVentana)
        {
            try
            {
                ventanas ventana = miContexto.ventanas.First(ventanas => ventanas.idventana == idVentana);
                miContexto.ventanas.Remove(ventana);
                miContexto.SaveChanges();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

    }
}
