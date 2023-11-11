class Converter
{
    private double usdRate;
    private double eurRate;
    private double plnRate;

    public Converter(double usd, double eur, double pln)
    {
        usdRate = usd;
        eurRate = eur;
        plnRate = pln;
    }

    public double Convert(double amount, string fromCurrency, string toCurrency)
    {
        double result = 0;

        if (fromCurrency.ToLower() == "uah")
        {
            switch (toCurrency.ToLower())
            {
                case "usd":
                    result = amount / usdRate;
                    break;
                case "eur":
                    result = amount / eurRate;
                    break;
                case "pln":
                    result = amount / plnRate;
                    break;
                default:
                    Console.WriteLine("Invalid target currency code");
                    break;
            }
        }
        else if (toCurrency.ToLower() == "uah")
        {
            switch (fromCurrency.ToLower())
            {
                case "usd":
                    result = amount * usdRate;
                    break;
                case "eur":
                    result = amount * eurRate;
                    break;
                case "pln":
                    result = amount * plnRate;
                    break;
                default:
                    Console.WriteLine("Invalid source currency code");
                    break;
            }
        }
        else
        {
            Console.WriteLine("Invalid conversion direction");
        }

        return result;
    }
}