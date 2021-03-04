using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Constants
{
   public class Messages
    {
        public static string ProductAdded = "Ürün eklendi";
        public static string ProductNameInvalid = "Ürün ismi geçersiz";
        public static string ManintenanceTime = "Sistem bakımda";
        public static string ProductsListed = "Ürünler listelendi";

        public static List<ProductDetailDto> MaintenanceTime { get; internal set; }


    }
