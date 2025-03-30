using BayonFramework.Database.Query;
using System.Text;

namespace BayonFramework.Database.Builder.Query;

public abstract class QueryDecorator : IQuery
{
    protected StringBuilder _queryStringBuilder;
    protected readonly Dictionary<string, object> _parameters = new Dictionary<string, object>();
    protected IQuery _query;
    public QueryDecorator(IQuery query)
    {
        _query = query;
        _queryStringBuilder = new StringBuilder();
    }
    public void Build(StringBuilder queryStringBuilder, Dictionary<string, object> parameters)
    {
        _queryStringBuilder.Clear();
        _parameters.Clear();

        if (_query != null)
        {
            _query.Build(_queryStringBuilder, _parameters);
        }

        this.BuildQuery();

        queryStringBuilder.Append(_queryStringBuilder);

        foreach (var param in _parameters)
        {
            parameters[param.Key] = param.Value;
        }
    }
    public string GetQuery()
    {
        return _queryStringBuilder.ToString();
    }
    public Dictionary<string, object> GetParameters()
    {
        return this._parameters;
    }
    protected abstract void BuildQuery();
}