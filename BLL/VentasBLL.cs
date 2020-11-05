using VictorP2_AP2.DAL;
using VictorP2_AP2.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace VictorP2_AP2.BLL
{
    public class VentasBLL
    {
        public static Ventas Buscar(int id)
        {
            Contexto contexto = new Contexto();
            Ventas ventas;

            try
            {
                ventas = contexto.Ventas.Find(id);
            }
            catch (Exception)
            {

                throw;
            }
            finally
            {
                contexto.Dispose();
            }
            return ventas;

        }
        public static List<Ventas> GetList(Expression<Func<Ventas, bool>> producto)
        {
            List<Ventas> Lista = new List<Ventas>();
            Contexto aux = new Contexto();

            try
            {
                Lista = aux.Ventas.Where(producto).ToList();
            }
            catch (Exception)
            {

                throw;
            }
            finally
            {
                aux.Dispose();
            }

            return Lista;
        }
    }
}