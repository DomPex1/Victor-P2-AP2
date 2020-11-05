using VictorP2_AP2.DAL;
using VictorP2_AP2.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace VictorP2_AP2.BLL
{
    public class ClientesBLL
    {
        public static List<Clientes> GetList(Expression<Func<Clientes, bool>> expression)
        {
            List<Clientes> Lista = new List<Clientes>();
            Contexto aux = new Contexto();

            try
            {
                Lista = aux.Clientes.Where(expression).ToList();
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