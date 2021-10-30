using System;
using System.Collections.Generic;

namespace WishList
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> myWishList = new List<string>();

            Console.WriteLine(myWishList.Count);

            myWishList.Add("coffee machine");
            myWishList.Add("new pair of socks");
            myWishList.Add("box of chocolates");
            myWishList.Add("new pillow");

            Console.WriteLine(myWishList.Count);

            foreach(string wish in myWishList)
            {
                Console.WriteLine(wish);
            }
        }
    }
}
