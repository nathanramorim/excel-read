using LerPlanilha;
using System;

namespace LerPlanilhaExcel
{
    class Program
    {
        static void Main(string[] args)
        {
            var xls = new Excel(@"C://Development//labs//dotnet//LerPlanilha//import.xlsx");
            xls.SetSheet("Planilha1");
            var products = xls.Output();
            foreach (var product in products)
            {
                Console.WriteLine(product.ToString());
            }

        }

    }
}