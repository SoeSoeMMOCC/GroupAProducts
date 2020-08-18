using Dapper;
using GroupAProducts.SSMModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GroupAProducts.Abstract;
using GroupAProducts.Model;

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
        public List<ProductModel> getProductListByCount(
            string p_productid,
            string p_pcatid,
            string p_brand,
            out string error)
        {
            error = "";
            List<ProductModel> productlist = new List<ProductModel>();
            var sql = "select row_number() over (ORDER BY prod.productid)as rownum,"+
                        "prod.productid,prod.productname,prodcat.pcatid,prodcat.pcatname,"+
                        "brand.brandid,brand.brandname,count(*) as total_qty from productdetail pdetail"+
                        "inner join products prod on pdetail.productid = prod.productid"+
                        "inner join productcategory prodcat on prodcat.pcatid = prod.pcatid"+
                         "inner join brand brand on brand.brandid = prod.brandid"+
                         "where prod.productid like '%' and prodcat.pcatid like '%'"+
                         "and brand.brandid like '%' group by prod.productid,prod.productname,prodcat.pcatid,prodcat.pcatname,"+
                         "brand.brandid,brand.brandname; ";
            var parameters = new DynamicParameters();
            parameters.Add("p_productid", p_productid, GetDbType(""));
            parameters.Add("p_pcatid", p_pcatid, GetDbType(""));
            parameters.Add("p_brand", p_brand, GetDbType(""));
            try
            {
                productlist = GADB().Query<ProductModel>(sql, param: parameters).ToList();
            }
            catch (Exception e)
            {
                //MMTSALE.WriteLog($"system error-{e.Message}");
                error = e.Message;
            }

            return productlist;
        }
    }
}
