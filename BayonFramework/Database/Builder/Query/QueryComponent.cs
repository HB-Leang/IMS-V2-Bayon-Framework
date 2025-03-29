
using BayonFramework.Database.Builder.Core;
using BayonFramework.Database.Query;
using System.Text;

namespace BayonFramework.Database.Builder.Query;

public class QueryComponent : IQuery
{
    private StringBuilder _queryStringBuilder = new StringBuilder();
    private Dictionary<string, object> _parameters = new Dictionary<string, object>();
    public string _tableName;
    public string[] _columns;

    public QueryComponent(string tableName, string[]? columns)
    {
        _tableName = tableName;
        _columns = columns ?? Array.Empty<string>();
        _queryStringBuilder.Clear();
    }

    public void Build(StringBuilder queryStringBuilder, Dictionary<string, object> parameters)
    {
        _queryStringBuilder.Clear();
        _parameters.Clear();
        _queryStringBuilder.Append($"SELECT {(_columns.Length > 0 ? string.Join(", ", _columns) : "*")} FROM {_tableName}");
        queryStringBuilder.Append(_queryStringBuilder);
        foreach (var param in _parameters)
            parameters[param.Key] = param.Value;
    }

    public Dictionary<string, object> Parameters
    {
        get { return _parameters; }
    }

    public Dictionary<string, object> GetParameters()
    {
        return this._parameters;
    }

    public string GetQuery()
    {
        return _queryStringBuilder.ToString();
    }
}