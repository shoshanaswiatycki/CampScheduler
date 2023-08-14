using Dapper;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Reflection;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Framework
{
    public abstract class ObjectData
    {
        public void Save()
        {
            DynamicParameters dp = new();

            foreach (PropertyInfo prop in this.GetType().GetProperties())
            {
                if (!prop.GetCustomAttributes().Any(a => a.ToString() == "Local"))
                {
                    dp.Add(prop.Name, prop.GetValue(this), dbType: (DbType)Enum.Parse(typeof(DbType), prop.PropertyType.ToString()), ParameterDirection.Input);
                }
            }
            SQLUtility.ExecuteSQLDapper(SaveSprocName, dp);

        }
        private string SaveSprocName => this.GetType().Name + "_save";
    }
}
