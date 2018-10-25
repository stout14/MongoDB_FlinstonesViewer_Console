using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo_FileIO_NTier
{
    public static class DataSettings
    {
        public const string connectionString = "mongodb://hello:world@nmc-shard-00-00-ltnsd.mongodb.net:27017,nmc-shard-00-01-ltnsd.mongodb.net:27017,nmc-shard-00-02-ltnsd.mongodb.net:27017/test?ssl=true&replicaSet=NMC-shard-0&authSource=admin&retryWrites=true";
    }
}
