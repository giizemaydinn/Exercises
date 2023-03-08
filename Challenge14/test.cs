//using HtmlAgilityPack;
//using System;
//using System.Collections.Generic;
//using System.Collections.Specialized;
//using System.Globalization;
//using System.IO;
//using System.Linq;
//using System.Net;
//using System.Web;

//namespace Challenge14
//{
//    internal class test
//    {
//        //.\project03console\bin\Debug\project03console.exe


//        private static string navbar_query = "//div[@class='navigation']//ul[@class='ResimliMenu1 navUl']/li";
//        private const string BASE_URI = "https://www.buyukanneminsandigi.com/en/";

//        static List<Category> CategoryList = new List<Category>();
//        static List<SubCategory> SubCategoryList = new List<SubCategory>();
//        static List<Product> ProductList = new List<Product>();

//        static void Main(string[] args)
//        {
//            GetCategoriesFromSite();



//            Console.WriteLine("Bitti");
//            Console.ReadLine();
//        }

//        private static void GetCategoriesFromSite()
//        {
//            string url = BASE_URI;

//            HtmlWeb web = new HtmlWeb();
//            web.PreRequest += PreRequest;

//            try
//            {

//                var doc = web.Load(url);

//                var categories = doc.DocumentNode.SelectNodes(navbar_query);

//                foreach (var categoryLi in categories)
//                {
//                    Category _category = new Category();

//                    var category_url_node = categoryLi.SelectSingleNode(".//a");
//                    if (category_url_node != null)
//                    {
//                        TextInfo textInfo = new CultureInfo("en-US", false).TextInfo;
//                        _category.CategoryName = textInfo.ToTitleCase(
//                            category_url_node.Attributes["title"].Value.ToLower(new CultureInfo("en-US")));
//                        if (_category.CategoryName == "New Arrivals" || _category.CategoryName == "Gallery" || _category.CategoryName == "Sale" || _category.CategoryName == "Blog")
//                            continue;
//                        _category.CategoryUrl = category_url_node.Attributes["href"].Value;

//                        _category.CategoryId = CategoryList.Count;
//                        CategoryList.Add(_category);



//                        var subcategories = categoryLi.SelectNodes(".//li");

//                        if (subcategories != null)
//                        {
//                            foreach (var subcategoryLi in subcategories)
//                            {
//                                SubCategory _subcategory = new SubCategory();
//                                _subcategory.CategoryId = _category.CategoryId;

//                                var subcategory_url_node = subcategoryLi.SelectSingleNode(".//a");
//                                if (subcategory_url_node != null)
//                                {
//                                    _subcategory.SubCategoryName = textInfo.ToTitleCase(
//                                        subcategory_url_node.Attributes["title"].Value.ToLower(new CultureInfo("en-US")));

//                                    _subcategory.SubCategoryUrl = subcategory_url_node.Attributes["href"].Value;

//                                    _subcategory.SubCategoryId = SubCategoryList.Count;
//                                    SubCategoryList.Add(_subcategory);


//                                    var document = web.Load(_category.CategoryUrl);
//                                    var products = document.DocumentNode.SelectNodes("//div[@class='productItem']");

//                                    if (products != null)
//                                    {
//                                        foreach (var productsLi in products)
//                                        {
//                                            Product _product = new Product();

//                                            _product.CategoryId = _category.CategoryId;
//                                            _product.SubCategoryId = _subcategory.SubCategoryId;

//                                            var product_url_node = productsLi.SelectSingleNode(".//div[@class='productName detailUrl']/a");
//                                            if (product_url_node != null)
//                                            {
//                                                _product.ProductUri = product_url_node.Attributes["href"].Value;
//                                            }

//                                            var product_title_node = productsLi.SelectSingleNode(".//div[@class='productName detailUrl']/a");
//                                            if (product_title_node != null)
//                                            {
//                                                _product.ProductTitle = textInfo.ToTitleCase(
//                                                    product_url_node.Attributes["title"].Value.ToLower(new CultureInfo("en-US")));
//                                            }

//                                            var product_price_node = productsLi.SelectSingleNode(".//div[@class='discountPrice']/span");
//                                            if (product_price_node != null)
//                                            {
//                                                _product.ProductPrice = product_price_node.InnerText.Trim();
//                                            }

//                                            var product_image_node = productsLi.SelectSingleNode(".//div[@class='productImage']/a");
//                                            if (product_image_node != null)
//                                            {
//                                                _product.ProductImageUri = product_image_node.Attributes["href"].Value;
//                                            }
//                                            ProductList.Add(_product);




//                                        }
//                                    }

//                                }

//                            }
//                        }


//                    }



//                }

//            }
//            catch (Exception e)
//            {
//                Console.WriteLine(e.StackTrace);
//            }

//        }
//        /// <summary>
//        /// HTTP request yapilmadan once cagrilir.
//        /// Server tarafından baska sayfaya yonledirme onlenir.
//        /// </summary>
//        /// <param name="request"></param>
//        /// <returns></returns>
//        private static bool PreRequest(HttpWebRequest request)
//        {
//            request.AllowAutoRedirect = false;
//            return true;
//        }

//        public static string ToQueryString(NameValueCollection nvc)
//        {
//            var array = (
//                from key in nvc.AllKeys
//                from value in nvc.GetValues(key)
//                select string.Format(
//                    "{0}={1}",
//                    HttpUtility.UrlEncode(key),
//                    HttpUtility.UrlEncode(value))
//            ).ToArray();
//            return "?" + string.Join("&", array);
//        }

//        private static void CreateTxt(string path, List<Product> products)
//        {
//            using (StreamWriter streamWriter = new StreamWriter(path))
//            {
//                foreach (var item in products)
//                {
//                    streamWriter.WriteLine(item.ProductTitle);
//                    streamWriter.WriteLine(item.ProductImageUri);
//                    streamWriter.WriteLine(item.ProductPrice);
//                    streamWriter.WriteLine(item.ProductUri);
//                    streamWriter.WriteLine("----------------------------------------------------------------");
//                }
//            }

//        }

//        private static bool IsFinish(string lastPage, params string[] endPages)
//        {
//            foreach (var item in endPages)
//            {
//                if (lastPage == item)
//                {
//                    return false;
//                }
//            }

//            return true;
//        }
//    }
//}
