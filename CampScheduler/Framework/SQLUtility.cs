using Dapper;
using System.Data;
using System.Data.SqlClient;
using System.Runtime.InteropServices;

namespace Framework
{
    public static class SQLUtility
    {
        public enum ExecSQLTypeEnum { NoResultSet, SingleRecord, MultipleRecord }
        public static string ConnectionString { get; set; } = "";
        private static object DoExecuteSQLDapper<T>(string sprocname, DynamicParameters dynamparam, ExecSQLTypeEnum execsqltype)
        {
            object? obj = null;
            //dynamparam.Add("Message", "", direction: ParameterDirection.InputOutput);
            //dynamparam.Add("return_value", "", direction: ParameterDirection.ReturnValue);
            using (SqlConnection conn = new SqlConnection(ConnectionString))
            {
                switch (execsqltype)
                {
                    case ExecSQLTypeEnum.SingleRecord:
                        obj = conn.QueryFirstOrDefault<T>(sprocname, dynamparam, commandType: CommandType.StoredProcedure);
                        break;
                    case ExecSQLTypeEnum.MultipleRecord:
                        obj = conn.Query<T>(sprocname, dynamparam, commandType: CommandType.StoredProcedure).ToList();
                        break;
                    default:
                        conn.Execute(sprocname, dynamparam, commandType: CommandType.StoredProcedure);
                        break;
                }
            }
            //int ret = dynamparam.Get<int>("return_value");
            //string msg = dynamparam.Get<string>("Message");
            //if (ret == 1)
            //{
            //    throw new Exception(msg);
            //}
            return obj;
        }
    }
}