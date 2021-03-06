﻿using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CabinetStomatologic.DAL
{
    class DALHelper
    {
        private static readonly string connectionString = ConfigurationManager.ConnectionStrings["CabinetEntities"].ConnectionString;

        internal static SqlConnection Connection
        {
            get
            {
                return new SqlConnection(connectionString);
            }
        }
    }
}
