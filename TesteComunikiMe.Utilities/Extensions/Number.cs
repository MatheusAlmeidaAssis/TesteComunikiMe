namespace TesteComunikiMe.Utilities.Extensions
{
    public static class Number
    {
        public static decimal ParseDecimal(this string text)
        {
            decimal.TryParse(text.Replace("R$", ""), out var valor);
            return valor;
        }
    }
}