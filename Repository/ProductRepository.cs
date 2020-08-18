using Dapper;
using GroupAProducts.SSMModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GroupAProducts.Abstract;

namespace GroupAProducts.Repository
{
    class ProductRepository:DBFactory
    {
        public List<Loginhistory> get_administration_loginhistory_by_user(
            int p_custclassid,
            out string error)
        {
            error = "";
            List<Loginhistory> loginhistory = new List<Loginhistory>();
            var sql = "select customerid,customername from customers where customerclassid= @p_custclassid;";
            var parameters = new DynamicParameters();
            parameters.Add("p_custclassid", p_custclassid, GetDbType(0));
            try
            {
                loginhistory = GADB().Query<Loginhistory>(sql,param:parameters).ToList();
            }
            catch (Exception e)
            {
                //MMTSALE.WriteLog($"system error-{e.Message}");
                error = e.Message;
            }

            return loginhistory;
        }
    }
}
