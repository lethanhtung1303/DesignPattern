using System.Data;
using System.Data.Common;

namespace quanlyxekhach.AbstractModel
{
    public abstract class AbstractDbFactory
    {
        public abstract DbCommand CreateCommand(string cmdText, DbConnection cn);

        public abstract DbConnection CreateConnection();

        public abstract DbConnection CreateConnection(string cnString);

        public abstract DbDataAdapter CreateDataAdapter(DbCommand selectCmd);

        public abstract DbParameter SqlParameter(string parameterName, SqlDbType dbType);
    }
}