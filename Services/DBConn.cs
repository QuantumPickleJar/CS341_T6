using Npgsql;

namespace CookNook.Services
{
    /// <summary>
    /// Defines the connection string so we don't need to get it from anywhere else
    /// </summary>
    internal class DbConn
    {
        private const string dbPassword = "REDACTED";
        private const string dbUsername = "";
        private const int PORT_NUMBER = 26257;
        private const string dbHost = "cockroachlabs.cloud";
        private const string dbName = "defaultdb";

        /// <summary>
        /// The connection string to the database
        /// </summary>
        public static string GetConnectionString()
        {
            // postgres://<username>:<password>@<host>:<port>/<database>?<parameters>
            //initialize the string builder
            var connStringBuilder = new NpgsqlConnectionStringBuilder();
            //set the properties of the string builder
            connStringBuilder.Host = dbHost;
            connStringBuilder.Port = PORT_NUMBER;
            connStringBuilder.SslMode = SslMode.VerifyFull;
            connStringBuilder.Username = dbUsername;
            connStringBuilder.Password = dbPassword;
            connStringBuilder.Database = dbName;
            connStringBuilder.ApplicationName = "";
            connStringBuilder.IncludeErrorDetail = true;
            //return the completed string
            return connStringBuilder.ConnectionString;
        }

        public static String ConnectionString { get { return GetConnectionString(); } }
    }
}
