

using App.DataAccess.Models;
using App.Infrastructure;
using App.Infrastructure.Common;
using App.Infrastructure.Datas;
using App.Infrastructure.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace App.DataAccess.Services
{
    public class DBUserService : IDBUserService
    {
        private Config _config;
        public DBUserService(Config config)
        {
            _config = config;
        }
        public bool CheckUserGroup(string username, UserGroupType groupType)
        {
            bool result = false;
            using (AppDBContext dBContext = new AppDBContext(_config))
            {
                var sqlTemplate = "SELECT PRIVILEGE_TYPE FROM information_schema.table_privileges WHERE table_schema = 'dbo' AND table_name = '{0}' AND grantee = '{1}'";
                if (groupType == UserGroupType.Compliance)
                {
                    string sql = string.Format(sqlTemplate, "EmployeeTrade", username);
                    var entities = dBContext.DbSetTablePrivileges.FromSqlRaw(sql).ToList();
                    result = entities.Count > 0;
                }
                else if (groupType == UserGroupType.Handelsueberwachung)
                {
                    string sql = string.Format(sqlTemplate, "TradData", username);
                    var entities = dBContext.DbSetTablePrivileges.FromSqlRaw(sql).ToList();
                    result = entities.Count > 0;
                }
                else if (groupType == UserGroupType.Admin)
                {
                    string sql = string.Format(sqlTemplate, "TradData", username);
                    var entities = dBContext.DbSetTablePrivileges.FromSqlRaw(sql).ToList();
                    result = entities.Count > 0;
                    if(result)
                    {
                        sql = string.Format(sqlTemplate, "EmployeeTrade", username);
                        var entities2 = dBContext.DbSetTablePrivileges.FromSqlRaw(sql).ToList();
                        result = result && entities2.Count > 0;
                    }                    
                }
            }
            return result;
        }
    }
}
