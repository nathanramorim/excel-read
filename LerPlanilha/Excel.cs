using ClosedXML.Excel;
using Infraestructure.Dto;
using System.Collections.Generic;
using System.Linq;

namespace LerPlanilha
{
    public class Excel
    {
        private string FilePath { get; init; }
        private string SheetName { get; init; }
        public IXLWorksheet Sheet { get; set; }

        private XLWorkbook Workbook { get; init; }

        public void SetSheet(string sheet) => this.Sheet = this.Workbook.Worksheets.First(w => w.Name == sheet);
        public int RowNums => this.Sheet.Rows().Count();

        public Excel(string filepath)
        {
            this.Workbook = new XLWorkbook(filepath);
        }

        public List<Product> Output()
        {
            var list = new List<Product>();

            try
            {

                for (int l = 2; l <= this.RowNums; l++)
                {

                    var codigo = this.Sheet.Cell($"A{l}").GetValue<int>();
                    var descricao = this.Sheet.Cell($"B{l}").GetValue<string>();
                    var preco = this.Sheet.Cell($"C{l}").GetValue<decimal>();

                    list.Add(new Product(codigo, descricao, preco));
                }
            }
            catch (System.Exception)
            {
                return list;
            }

            return list;

        }



    }
}
