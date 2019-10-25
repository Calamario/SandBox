using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AzureTasksProvider
{
    public static class Constants
    {
        private static readonly string SQLDBConnectionString = "Data Source=test.database.windows.net;Initial Catalog=test;Persist Security Info=True;User ID=test;Password=[PLACEHOLDER]";

        public const string IssuerKey = "dOTCs2xYkd7CWPJfhRvqCg0U1CRdL8PhhfRGGxgd4Ts="; 

        string sasUrl = @"https://test.table.core.windows.net/test?sv=2013-08-15&tn=test&sig=kfEzhzz4JDTnfOaCgau3sfl4EE2QHrWbBE88FKVjubo%3D"; 
    }
}
