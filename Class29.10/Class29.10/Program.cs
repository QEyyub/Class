using System;

namespace Class29._10
{
    class Program
    {
        static void Main(string[] args)
        {
            //#region Task1,2
            Product prd1 = new Product
            {
                Name = "Korivka",
                BrendName = "Roshen",
                Price = 5
            };

            Product prd2 = new Product
            {
                Name = "Moloko",
                BrendName = "Roshen",
                Price = 3
            };

            Product prd3 = new Product
            {
                Name = "Qaretka",
                BrendName = "Roshen",
                Price = 8
            };

            Product prd4 = new Product
            {
                Name = "Malochnaya",
                BrendName = "Roshen",
                Price = 6
            };

            Product prd5 = new Product
            {
                Name = "Jelli",
                BrendName = "Roshen",
                Price = 4
            };

            Console.WriteLine("Daxil edilmis araliqda mehsullar");

            Product[] products = new Product[] { prd1, prd2, prd3, prd4, prd5 };

            products = prdc(products, 2, 5);

            Console.WriteLine(products);

            //                                      Task3

            //Car cr = new Car
            //{
            //    Name = "RV4",
            //    Model = "Toyota RV4",
            //    Brand = "Toyota",
            //    Color = "White"
            //};

        }

        static Product [] prdc (Product [] prArr , double min , double max)
        {
            
            for (int i = 0; i < prArr.Length; i++)
            {
                if (prArr[i].Price>=min && prArr[i].Price <= max)
                {
                    Console.WriteLine($"{prArr[i].Name} {prArr[i].BrendName} {prArr[i].Price}");
                }
                
            }
            return prArr;

        }
    }
        
}
