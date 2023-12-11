internal class CsvWriter
{
    private StreamWriter fs;
    private CsvConfiguration csvConfig;

    public CsvWriter(StreamWriter fs, CsvConfiguration csvConfig)
    {
        this.fs = fs;
        this.csvConfig = csvConfig;
    }

    internal void NextRecord()
    {
        throw new NotImplementedException();
    }

    internal void WriteHeader<T>()
    {
        throw new NotImplementedException();
    }

    internal void WriteRecords(List<User> users)
    {
        throw new NotImplementedException();
    }
}