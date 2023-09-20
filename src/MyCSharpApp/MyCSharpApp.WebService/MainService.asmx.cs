using System;
using System.Data;
using System.Data.SqlClient;
using System.Web.Services;

namespace MyCSharpApp.WebService
{
    /// <summary>
    /// Descripción breve de MainService
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // Para permitir que se llame a este servicio web desde un script, usando ASP.NET AJAX, quite la marca de comentario de la línea siguiente. 
    // [System.Web.Script.Services.ScriptService]
    public class MainService : System.Web.Services.WebService
    {

        [WebMethod(Description ="Get All users registered in database")]
        public DataSet GetAllUsers()
        {
            SqlConnection Connection = new SqlConnection();
            SqlCommand Command = new SqlCommand();
            SqlDataAdapter Da = new SqlDataAdapter();
            DataSet UsersData = new DataSet();

            try
            {
                Connection.ConnectionString = Globals.SqlCredentialsConnectionString;
                Command.Connection = Connection;
                Command.CommandText = "sp_MY_CSHARP_APP_GetAllUsers";
                Command.CommandType = CommandType.StoredProcedure;
                Da.SelectCommand = Command;
                Da.Fill(UsersData, "users");

                return UsersData;

            } 
            catch (SqlException err)
            {

            }

            return UsersData;
            
        }
    }
}
