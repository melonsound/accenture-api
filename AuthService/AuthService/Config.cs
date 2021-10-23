using System;

namespace AuthService
{
    public class Config
    {
        public static readonly string AuthKey = Environment.GetEnvironmentVariable("AUTH_KEY");

        #region PostgreSQL config

        private static readonly string DbUser = Environment.GetEnvironmentVariable("DB_USER");
        private static readonly string DbPassword = Environment.GetEnvironmentVariable("DB_PASSWORD");
        private static readonly string DbHost = Environment.GetEnvironmentVariable("DB_HOST");
        private static readonly string DbPort = Environment.GetEnvironmentVariable("DB_PORT");
        private static readonly string DbName = Environment.GetEnvironmentVariable("DB_NAME");
        
        public static readonly string DbConnectionString = $"User ID={DbUser};" +
                                                           $"Password={DbPassword};" +
                                                           $"Host={DbHost};" +
                                                           $"Port={DbPort};" +
                                                           $"Database={DbName};" +
                                                           $"SSL Mode=Require;" +
                                                           $"Trust Server Certificate=true";

        #endregion
    }
}