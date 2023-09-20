using System;
using System.Configuration;

namespace MyCSharpApp.WebService
{
    public static class Globals
    {
        public static string SqlCredentialsConnectionString = ConfigurationManager.ConnectionStrings["SqlCredentialsConnectionString"].ConnectionString;
    }
}