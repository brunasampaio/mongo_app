﻿using Matrix.Core.FrameworkCore;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Matrix.Core.MongoDbBaseRepositories
{
    /// <summary>
    /// This is specific for "MXBusiness" database/dataset. For a newer database; create a new class on similar lines.
    /// Ideally, this should be in DAL as MatrixCore speaks only about core capabilities of the system. But it's ok for now.
    /// </summary>
    public class MXBusinessMongoRepository : MXMongoRepository, IMXBusinessMongoRepository
    {
        public MXBusinessMongoRepository()
        {
            connectionUrl = ConfigurationManager.AppSettings["mongoConnUrl"].ToString();
            databaseName = ConfigurationManager.AppSettings["MXBusinessDatabaseName"].ToString();
        }
    }
}
