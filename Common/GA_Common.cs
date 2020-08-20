using GroupAProducts.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GroupAProducts.Common
{
    class GA_Common
    {
        public static string ProID = null;
        public static string BrandID = null;
        public static string PCatID = null;
        public static string PDetailID = null;

        public static ProductDetailModel objProductDetails; //create productdetails object

        public static ProductModel objProducts; //create product object

        public static Brand objBrand; //create brand object

        public static string btnstatus = null;

        public static string PDetailAutoID = null; //autoid for productdetails

        public static string ProductAutoID = null; //autoid for product

        public static string BrandAutoID = null; //autoid for brand

        public static string ProCategoryAutoID { get; internal set; }
    }
}
