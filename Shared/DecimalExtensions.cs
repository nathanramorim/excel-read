namespace Shared
{
    public static class DecimalExtension
    {

        public static decimal ConvertDecimal(this object value)
        {
            if (null == value)
                return 0;

            try
            {
                return (decimal)value;
            }
            catch (System.Exception)
            {

                return 0;
            }
        }
    }
}
