namespace BayonFramework.Database.Builder.Implementation;

public class SqlQuery
{
    private List<string> _columns = new();
    private bool _distinct;
    public SqlQuery Select(params string[] columns)
    {
        _columns.AddRange(columns);
        return this;
    }
    public SqlQuery Distinct()
    {
        _distinct = true;
        return this;
    }
    public string BuildSqlQuery()
    {
        string columnsPart = _columns.Count > 0 ? string.Join(", ", _columns) : "*";
        string query = $"SELECT {(_distinct ? "DISTINCT" : "")}{columnsPart}";

        return query;
    }
}
