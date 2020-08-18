using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GroupAProducts.Model
{
    public class ProductDetailModel
    { 
        //row_number() over(ORDER BY pdetail.detailid)as rownum,
        //pdetail.detailid,pdetail.barcode,pdetail.price,pdetail.productid,
        //prod.productname,prod.pcatid,prodcat.pcatname,prod.brandid,brand.brandname,
        //pdetail.sizeid,psize.sizes,pdetail.colorid,color.color
        public int rownum { get; set; }
        public string detailid { get; set; }
        public string barcode { get; set; }
        public int price { get; set; }
        public string productid { get; set; }
        public string productname { get; set; }
        public string pcatid { get; set; }
        public string pcatname { get; set; }
        public string brandid { get; set; }
        public string brandname { get; set; }
        public string sizeid { get; set; }
        public string sizes { get; set; }
        public string colorid { get; set; }
        public string color { get; set; }
    }
}
