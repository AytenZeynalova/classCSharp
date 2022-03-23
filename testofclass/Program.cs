using System;

namespace testofclass
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Notebooklarin sayini daxil edin:");

            int size = Convert.ToInt32(Console.ReadLine());

            Notebook[] notebook = new Notebook[size];

            for (int i = 0; i < notebook.Length; i++)
            {
                Console.WriteLine($"{i+1}. notebookun adini daxil edin:");
                string name = Console.ReadLine();
                Console.WriteLine($"{i + 1}. notebookun markasini daxil edin:");
                string brandName = Console.ReadLine();
                Console.WriteLine($"{i + 1}. notebookun qiymetini daxil edin:");
                double price = Convert.ToDouble(Console.ReadLine());
                Notebook n = new Notebook
                {
                    Name = name,
                    BrandName = brandName,
                    Price = price,
                
                };
                notebook[i] = n;

            }

            double minprice = 1000;
            double maxprice = 4500;
            
            foreach (var item in SelectNotebook(notebook, minprice, maxprice))
            {
                Console.WriteLine("uygun qiymetler:" +item);

            }

        }

        static double [] SelectNotebook (Notebook [] notebook, double MinPrice, double MaxPrice)
        {
            int count = 0;

            for (int i = 0; i < notebook.Length; i++)
            {


                if (notebook[i].Price >= MinPrice && notebook[i].Price <= MaxPrice)
                {
                    count++;

                }

            }
            double[] SelectedNotebooks = new double[count];

            for (int i = 0; i < SelectedNotebooks.Length; i++)
            {
                if (notebook[i].Price >= MinPrice && notebook[i].Price <= MaxPrice)
                {
                    SelectedNotebooks[i] = notebook[i].Price;
                }
            }
            return SelectedNotebooks;



        }


    }
}
