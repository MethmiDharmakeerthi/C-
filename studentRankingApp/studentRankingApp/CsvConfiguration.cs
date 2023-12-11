using System.Globalization;

internal class CsvConfiguration
{
    private CultureInfo currentCulture;

    public CsvConfiguration(CultureInfo currentCulture)
    {
        this.currentCulture = currentCulture;
    }

    public Func<object, bool> ShouldQuote { get; set; }
}