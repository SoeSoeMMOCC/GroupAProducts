using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GroupAProducts.Model
{
    public class ProductModel
    {
//        row_number() over(ORDER BY prod.productid)as rownum,
//prod.productid,prod.productname,prodcat.pcatid,prodcat.pcatname,
//brand.brandid,brand.brandname,count(*) as total_qty

        public int rownum { get; set; }
        public string productid { get; set; }
        public string productname { get; set; }
        public string pcatid { get; set; }
        public string pcatname { get; set; }
        public string brandid { get; set; }
        public string brandname { get; set; }
        public int total_qty { get; set; }
    }

}
