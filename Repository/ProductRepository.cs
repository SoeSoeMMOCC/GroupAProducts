using Dapper;
using GroupAProducts.SSMModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GroupAProducts.Abstract;
using GroupAProducts.Model;
using System.Security.Policy;

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
            var sql = 
                "select row_number() over (ORDER BY prod.productid)as rownum,"+
                "prod.productid,prod.productname,prodcat.pcatid,prodcat.pcatname,"+
                "brand.brandid,brand.brandname,count(*) as total_qty from productdetail pdetail " +
                "inner join products prod on pdetail.productid = prod.productid and pdetail.isactive=true " +
                "inner join productcategory prodcat on prodcat.pcatid = prod.pcatid " +
                "inner join brand brand on brand.brandid = prod.brandid " +
                "where  prod.productid like @p_productid and prodcat.pcatid like @p_pcatid " +
                "and brand.brandid like @p_brand " +
                "group by prod.productid,prod.productname,prodcat.pcatid,prodcat.pcatname," +
                "brand.brandid,brand.brandname;" 
                ;
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

        public List<ProductDetailModel> getProductDetailList(
            string p_productid,
            string p_pcatid,
            string p_brand,
            string p_pdetailid,
            out string error)
        {
            error = "";
            List<ProductDetailModel> productlist = new List<ProductDetailModel>();
            var sql =
                "select row_number() over(ORDER BY pdetail.detailid) as rownum,"+
                "pdetail.detailid,pdetail.barcode,pdetail.price,pdetail.productid," +
                "prod.productname,prod.pcatid,prodcat.pcatname,prod.brandid,brand.brandname," +
                "pdetail.sizeid,psize.sizes,pdetail.colorid,color.color " +
                "from productdetail pdetail " +
                "inner join products prod on pdetail.productid = prod.productid and pdetail.isactive=true " +
                "inner join productcategory prodcat on prodcat.pcatid = prod.pcatid " +
                "inner join brand brand on brand.brandid = prod.brandid " +
                "inner join productcolor color on pdetail.colorid = color.colorid " +
                "inner join productsize psize on psize.sizeid = pdetail.sizeid " +
                "where prod.productid like @p_productid and prodcat.pcatid like @p_pcatid " +
                "and brand.brandid like @p_brand and pdetail.isactive = true and pdetail.detailid like @p_pdetailid ; "
            ;
            var parameters = new DynamicParameters();
            parameters.Add("p_productid", p_productid, GetDbType(""));
            parameters.Add("p_pcatid", p_pcatid, GetDbType(""));
            parameters.Add("p_brand", p_brand, GetDbType(""));
            parameters.Add("p_pdetailid", p_pdetailid, GetDbType(""));

            try
            {
                productlist = GADB().Query<ProductDetailModel>(sql, param: parameters).ToList();
            }
            catch (Exception e)
            {
                //MMTSALE.WriteLog($"system error-{e.Message}");
                error = e.Message;
            }

            return productlist;
        }
        public List<ProductSize> getProductSize(
            string p_sizeid,
            out string error)
        {
            error = "";
            List<ProductSize> psizelist = new List<ProductSize>();
            var sql =
                "select sizeid,sizes from productsize where sizeid like @p_sizeid and isactive=true ; "
            ;
            var parameters = new DynamicParameters();
            parameters.Add("p_sizeid", p_sizeid, GetDbType(""));

            try
            {
                psizelist = GADB().Query<ProductSize>(sql, param: parameters).ToList();
            }
            catch (Exception e)
            {
                //MMTSALE.WriteLog($"system error-{e.Message}");
                error = e.Message;
            }

            return psizelist;
        }
        public List<ProductColor> getProductColor(
           string p_colorid,
           out string error)
        {
            error = "";
            List<ProductColor> pcolorlist = new List<ProductColor>();
            var sql =
                "select colorid,color from productcolor where colorid like @p_colorid and isactive=true ; "
            ;
            var parameters = new DynamicParameters();
            parameters.Add("p_colorid", p_colorid, GetDbType(""));

            try
            {
                pcolorlist = GADB().Query<ProductColor>(sql, param: parameters).ToList();
            }
            catch (Exception e)
            {
                //MMTSALE.WriteLog($"system error-{e.Message}");
                error = e.Message;
            }

            return pcolorlist;
        }
        public List<Brand> getProductBrand(
           string p_brandid,
           out string error)
        {
            error = "";
            List<Brand> pbrandlist = new List<Brand>();
            var sql =
                "select brandid,brandname from brand where brandid like @p_brandid and isactive=true ; "
            ;
            var parameters = new DynamicParameters();
            parameters.Add("p_brandid", p_brandid, GetDbType(""));

            try
            {
                pbrandlist = GADB().Query<Brand>(sql, param: parameters).ToList();
            }
            catch (Exception e)
            {
                //MMTSALE.WriteLog($"system error-{e.Message}");
                error = e.Message;
            }

            return pbrandlist;
        }

        public List<ProductCategory> getProductCategory(
          string p_catid,
          out string error)
        {
            error = "";
            List<ProductCategory> pcategorylist = new List<ProductCategory>();
            var sql =
                "select pcatid,pcatname from productcategory where pcatid like @p_catid and isactive=true ; "
            ;
            var parameters = new DynamicParameters();
            parameters.Add("p_catid", p_catid, GetDbType(""));

            try
            {
                pcategorylist = GADB().Query<ProductCategory>(sql, param: parameters).ToList();
            }
            catch (Exception e)
            {
                //MMTSALE.WriteLog($"system error-{e.Message}");
                error = e.Message;
            }

            return pcategorylist;
        }
        public List<Products> getProducts(
         string p_productid,
         string p_pcatid,
         string p_brandid,
         out string error)
        {
            error = "";
            List<Products> productlist = new List<Products>();
            var sql =
                "select productid,productname from products where brandid like @p_brandid " +
                "and pcatid like @p_pcatid and productid like @p_productid and isactive=true; "
            ;
            var parameters = new DynamicParameters();
            parameters.Add("p_productid", p_productid, GetDbType(""));
            parameters.Add("p_pcatid", p_pcatid, GetDbType(""));
            parameters.Add("p_brandid", p_brandid, GetDbType(""));

            try
            {
                productlist = GADB().Query<Products>(sql, param: parameters).ToList();
            }
            catch (Exception e)
            {
                //MMTSALE.WriteLog($"system error-{e.Message}");
                error = e.Message;
            }

            return productlist;
        }

        public ReturnDataModel deleteProductDetail(
        string p_detailid,
        out string error)
        {
            error = "";
            var sql = "update productdetail set isactive=false where detailid= @p_detailid ; ";
            var parameters = new DynamicParameters();
            parameters.Add("p_detailid", p_detailid, GetDbType(""));
            int iresult = 1;
            ReturnDataModel retdata = new ReturnDataModel();
            try
            {
                iresult = GADB().Execute(sql, param: parameters);
                iresult = 1;
                goto returnData;
            }
            catch (Exception e)
            {
                //MMTSALE.WriteLog($"system error-{e.Message}");
                iresult = 0;
                error = e.Message;
                goto returnData;
            }
            returnData:
            retdata.errorMsg = error;
            retdata.retStatus = (iresult == 1) ? true : false;
                
            return retdata;
        }

        public ReturnDataModel updateProductDetail(
       string p_detailid,
       ProductDetailModel p_productdetail,
       out string error)
        {
            error = "";
            int iresult = 1;
            ReturnDataModel retdata = new ReturnDataModel();

            var del_sql = "delete form productdetail where detailid = @p_detailid ; ";
            var parameters = new DynamicParameters();
            parameters.Add("p_detailid", p_detailid, GetDbType(""));            
            try
            {
                iresult = GADB().Execute(del_sql, param: parameters);
                iresult = 1;
                goto insertData;
            }
            catch (Exception e)
            {
                //MMTSALE.WriteLog($"system error-{e.Message}");
                iresult = 0;
                error = "Please Update Again!!Failed to Detele and Update Records.";
                goto returnData;
            }

            insertData:
            var insert_sql = "INSERT INTO productdetail(detailid, price, barcode, isactive, ts, productid, sizeid, " +
                "colorid) VALUES(@p_detailid, @p_price, @p_barcode, @p_isactive, @p_ts, @p_productid, @p_sizeid, @p_colorid); ";
            parameters = new DynamicParameters();
            parameters.Add("p_detailid", p_productdetail.detailid, GetDbType(""));
            parameters.Add("p_price", p_productdetail.price, GetDbType(0));
            parameters.Add("p_barcode", p_productdetail.barcode, GetDbType(""));
            parameters.Add("p_isactive", true, GetDbType(true));
            parameters.Add("p_ts", DateTime.Now, GetDbType(DateTime.Now));
            parameters.Add("p_productid", p_productdetail.productid, GetDbType(""));
            parameters.Add("p_sizeid", p_productdetail.sizeid, GetDbType(""));
            parameters.Add("p_colorid", p_productdetail.colorid, GetDbType(""));
            try
            {
                iresult = GADB().Execute(insert_sql, param: parameters);
                iresult = 1;
                goto updateProdutsInfo;
            }
            catch (Exception e)
            {
                //MMTSALE.WriteLog($"system error-{e.Message}");
                iresult = 0;
                error = "Insertion failed.";
                goto returnData;
            }
            updateProdutsInfo:
            var update_sql = "update products set brandid=@p_brandid,pcatid =@p_pcatid where productid=@p_productid; ";
            parameters = new DynamicParameters();
            parameters.Add("p_brandid", p_productdetail.brandid, GetDbType(""));
            parameters.Add("p_pcatid", p_productdetail.pcatid, GetDbType(""));
            parameters.Add("p_productid", p_productdetail.productid, GetDbType(""));

            try
            {
                iresult = GADB().Execute(update_sql, param: parameters);
                iresult = 1;
                goto returnData;
            }
            catch (Exception e)
            {
                //MMTSALE.WriteLog($"system error-{e.Message}");
                iresult = 0;
                error = "Please Update Again!!Failed to Update Product Records.";
                goto returnData;
            }

            returnData:
            retdata.errorMsg = error;
            retdata.retStatus = (iresult == 1) ? true : false;

            return retdata;
        }
        public string getProductNoSeries(out string error)
        {
            error = "";
            string retn="";
            ProductDetailModel productlist = new ProductDetailModel();
            var sql =
                "select  * from productdetail order by detailid desc limit 1; ";
            

            try
            {
                productlist = GADB().Query<ProductDetailModel>(sql).FirstOrDefault();
            }
            catch (Exception e)
            {
                //MMTSALE.WriteLog($"system error-{e.Message}");
                error = e.Message;
            }

            return retn;
        }
    }
}
