//using System;
//using System.Collections.Generic;
//using System.Linq;

//namespace InterviewQuestions
//{
//    public class Product
//    {
//        public int Id { get; set; }

//        public string Name { get; set; }

//        public string Description { get; set; }
//    }

//    public static class UniqueProducts
//    {
//        public static List<Product> GetUniqueProducts(List<Product> products)
//        {
//            //Write your code here to return unique products based on name
//            return products.DistinctBy(e => e.Name).ToList();
//            //List<Product> uniqueproducts = new List<Product>();
//            //for (int i = 0; i < products.Count; i++)
//            //{
//            //    var product = products[i];

//            //    bool isexists = UniqueProducts.IsProductExist(uniqueproducts, product);
//            //    if (isexists == false)
//            //    {
//            //        uniqueproducts.Add(products[i]);
//            //    }
//            //}
//            //return uniqueproducts;
//        }
//        //public static bool IsProductExist(List<Product> allProducts, Product product)
//        //{
//        //    //This method takes 2 parameters. allProducts and product
//        //    // Check if the product name already exist in allProducts, if yes, return true, else return false
//        //    for (int j = 0; j < allProducts.Count; j++)
//        //    {
//        //        if (allProducts[j].Name == product.Name)
//        //        {
//        //            return true;
//        //            break;
//        //        }
//        //        else
//        //        {
//        //            return false;
//        //            break;
//        //        }
//        //    }
//        //    return false;
//        //}
//    }
//    public class Program
//    {
//        static void Main(string[] args)
//        {
//            List<Product> products = new List<Product>();
//            products.Add(new Product { Id = 1, Name = "Lux", Description = "desc1" });
//            products.Add(new Product { Id = 2, Name = "Rexona", Description = "desc2" });
//            products.Add(new Product { Id = 3, Name = "Lux", Description = "desc3" });
//            products.Add(new Product { Id = 4, Name = "Dove", Description = "desc4" });
//            var distinctProducts = UniqueProducts.GetUniqueProducts(products);
//            foreach (var product in distinctProducts)
//            {
//                Console.WriteLine($"{product.Id} \t {product.Name} \t\t {product.Description}");
//            }
//        }
//    }
//}




//Task 3

using System;


public class AnagramDetector
{
    public static bool CheckIfLettersAreSame(string str1, string str2)
    {
        //We are getting 2 "words" str1, str2 as inputs
        //Return true if both the strings are having exactly same letters in them
        int[] counts = new int[str1.Length];
        char[] strarr1 = str1.ToCharArray();
        char[] strarr2 = str2.ToCharArray();
        if (strarr1.Length == strarr2.Length)
        {
            for (int i = 0; i < strarr1.Length; i++)
            {
                for (int j = 0; j < strarr2.Length; j++)
                {
                    if (strarr1[i] == strarr2[j])
                    {
                        counts[j] =  1;
                       // counts[j] = counts[j] + 1;
                    }
                }

            }
        }
        int c = 0;
        for (int i = 0; i < counts.Length; i++)
        {
            if (counts[i] == 1)
            {
                c++;
            }
        }
        if (c == str1.Length)
        {
            return true;
        }
        return false;
    }






    public static void Main(string[] args)
    {
        string[] wordPairs = {
            "listen|silent",
            "act|cat",
            "b|a",
            "cinema|iceman",
            "post|stop",
            "post|stap",
            "rama|krishna",
            "act|cat",
            "rahul|rahul",
            "a|b",
            "madam|daamm"
        };

        foreach (string pair in wordPairs)
        {
            string[] words = pair.Split('|');
            string word1 = words[0];
            string word2 = words[1];

            if (CheckIfLettersAreSame(word1, word2))
            {
                Console.WriteLine($"{word1,15} |  {word2,15} | same letters.");
            }
            else
            {
                Console.WriteLine($"{word1,15} |  {word2,15} | different letters.");
            }
        }
    }
}
