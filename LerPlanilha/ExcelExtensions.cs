using ClosedXML.Excel;

namespace LerPlanilha
{
    public static class ExcelExtensions
    {
        public static decimal ToDecimal(this IXLCell value)
        {
            if (value.DataType != XLDataType.Number)
                throw new System.Exception(string.Format("Erro no valor {0}", value.GetString()));

            return value.GetValue<decimal>();
        }

        public static int ToInt(this IXLCell value)
        {
            return value.DataType == XLDataType.Number ? value.GetValue<int>() : 0;
        }

    }
}
