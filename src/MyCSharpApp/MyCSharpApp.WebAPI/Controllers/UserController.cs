using Microsoft.AspNetCore.Mvc;
using Microsoft.Data.SqlClient;
using System.Data;
// using System.Text;
using Newtonsoft.Json;
using System.Text;

namespace MyCSharpApp.WebAPI.Controllers
{

    [ApiController]
    [Route("api/users")]
    public class UserController : ControllerBase
    {

        [HttpGet("getUsers", Name ="GetUsers", Order = 1)]
        public ContentResult Get([FromQuery(Name = "numrows")] string NumRows)
        {
            SqlConnection Connection = new SqlConnection(
                Environment.GetEnvironmentVariable("SQL_CONNECTION_STRING", EnvironmentVariableTarget.Machine)
            );

            SqlCommand Command = new SqlCommand();
            SqlDataAdapter Da = new SqlDataAdapter();
            DataTable UsersData = new DataTable("users");
            string UsersJsonString;
            //User[] Users;

            try
            {
                Command.Connection = Connection;
                Command.CommandText = "sp_MY_CSHARP_APP_GetAllUsers";
                Command.CommandType = CommandType.StoredProcedure;

                // Parameters
                Command.Parameters.Add("@NumRows", SqlDbType.NVarChar).Value = NumRows;
                
                Da.SelectCommand = Command;
                Da.Fill(UsersData);

                UsersJsonString = JsonConvert.SerializeObject(UsersData);
                //Users = JsonConvert.DeserializeObject<User[]>(UsersJsonString);

                Connection.Close();
                Connection.Dispose();

                return Content(UsersJsonString, "application/json", Encoding.UTF8);

            } 
            catch (Exception err)
            {
                Connection.Close();
                Connection.Dispose();

                return Content("[]", "application/json", Encoding.UTF8);
            }

            // using (var streamReader = new StreamReader(new FileStream(@".\Users.json", FileMode.Open, FileAccess.Read), Encoding.UTF8))
            // {
            //     Users = streamReader.ReadToEnd();
            // }

            // return JsonConvert.DeserializeObject<User[]>(Users); ;
        }

        [HttpGet("getUsersInHtmlTable", Name = "GetUsersInHtmlTable", Order = 2)]
        [Produces("text/html")]
        public ContentResult GetUsersInHtmlTable()
        {
            string Html = @"
                <!DOCTYPE html>
                <html>
                  <head>
                    <meta charset=""utf-8"">
                    <meta name=""viewport"" content=""width=device-width, initial-scale=1"">
                    <title></title>
                  </head>
                  <body>
                    <div>
                      <h1>Hola mundo</h1>
                    </div>
                  </body>
                </html>  
            ";
            
            return Content(Html, "text/html", Encoding.UTF8);
        }
    }
}
