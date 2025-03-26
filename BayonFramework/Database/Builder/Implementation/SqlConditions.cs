namespace BayonFramework.Database.Builder.Implementation;

public class SqlConditions
{
    private string? _table;
    private List<string> _conditions = new();
    private List<string> _joins = new();
    private List<string> _groupBy = new();
    private string? _having;

    public  SqlConditions From(string table)
    {
        _table = table;
        return this;
    }

    public SqlConditions Where(string condition)
    {
        _conditions.Add(condition);
        return this;
    }

    public SqlConditions Join(string table, string onCondition, string type = "INNER")
    {
        _joins.Add($"{type} JOIN {table} ON {onCondition}");
        return this;
    }

    public SqlConditions GroupBy(params string[] columns)
    {
        _groupBy.AddRange(columns);
        return this;
    }

    public SqlConditions Having(string condition)
    {
        _having = condition;
        return this;
    }

    public string BuildSqlCondition()
    {
        if(string.IsNullOrEmpty( _table)) throw new InvalidOperationException("Table name not specified.");
        string query = $"FROM {_table}";

        if (_joins.Count > 0) query += " " + string.Join(" ", _joins);
        if (_conditions.Count > 0) query += " WHERE " + string.Join(" AND ", _conditions);
        if (_groupBy.Count > 0) query += " GROUP BY " + string.Join(", ", _groupBy);
        if (!string.IsNullOrEmpty(_having)) query += " Having " + _having;

        return query;
    }

}
