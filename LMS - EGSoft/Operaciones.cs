using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SQLite;

namespace LMS___EGSoft
{
    public class Operaciones
    {
        public string Conectar()
        {
            SQLiteConnection cnx = new SQLiteConnection("Data Source=C:\\Programacion\\LMS\\LMSDataBase.db;Version=3;");
            try
            {
                cnx.Open();
                return "Conexion Exitosa";
            }
            catch (Exception ex){
                return ex.Message;
            }
            finally{
                cnx.Close();
            }

        }

    }

}
