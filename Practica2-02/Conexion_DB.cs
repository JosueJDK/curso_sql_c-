using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica2_02
{
    internal class Conexion_DB
    {
        string CadConex = "Server=(local); DataBase=JSalazar; uid=sa; pwd=1234";

        public SqlConnection Conex = new SqlConnection();

        public Conexion_DB()
        {
            Conex.ConnectionString = CadConex;
        }

        public void open()
        {
            try
            {
                Conex.Open();
                Console.WriteLine("Conexion exitosa!");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error de conexion!" + ex.Message);
            }
        }

        public void close()
        {
            try
            {
                Conex.Close();
                Console.WriteLine("Conexion cerrada exitosamente!");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error al cerrar conexion!" + ex.Message);
            }
        }
    }
}
