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
                Console.WriteLine("Notebooklarin qiymetlerini daxil edin:");
                int prices=  Convert.ToInt32(Console.ReadLine());
                notebook = new Notebook{ prices};
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
