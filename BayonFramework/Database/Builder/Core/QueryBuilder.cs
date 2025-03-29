
using BayonFramework.Database.Builder.Core.Special;
using BayonFramework.Database.Builder.Query;
using BayonFramework.Database.Builder.Query.Condition;
using BayonFramework.Database.Builder.Query.Condition.Enum;
using BayonFramework.Database.Builder.Query.Operation;
using BayonFramework.Database.Query;
using System.Text;

namespace BayonFramework.Database.Builder.Core;

public class QueryBuilder : IQueryBuilder
{
    private IQuery _query;
    private List<WhereCondition> _whereConditions = new List<WhereCondition>();
    private readonly string _tableName;
    private readonly string[] _initialColumns;

    public QueryBuilder(string tableName, string[]? columns =null)
    {
        _tableName = tableName;
        _initialColumns = columns?.ToArray() ?? Array.Empty<string>();
        _query = new QueryComponent(_tableName);
    }

    public SqlQuery Build()
    {
        var sb = new StringBuilder();
        var parameters = new Dictionary<string, object>();
        this.ApplyWhere();

        _query.Build(sb, parameters);

        SqlQuery sqlQuery = new SqlQuery.Builder()
            .SetQuery(_query.GetQuery())
            .AddParameters(_query.GetParameters())
            .Build();

        this.Reset();

        return sqlQuery;
    }

    private void Reset()
    {
        _whereConditions.Clear();
    }

    public QueryBuilder ApplyWhere()
    {
        if (_whereConditions.Any())
        {
            _query = new WhereDecorator(_query, _whereConditions);
        }
        return this;
    }

    public QueryBuilder Where(string column, ComparisonCondition condition, object value, LogicalCondition? logical = null, object? value2 = null)
    {
        _whereConditions.Add(new WhereCondition(column, condition, value, logical, value2));
        return this;
    }

    public QueryBuilder Where(Action<QueryBuilder> nestedBuilder, LogicalCondition? logical = null)
    {
        var nested = new QueryBuilder(_tableName, _initialColumns);
        nestedBuilder(nested);
        var condition = new WhereCondition("", ComparisonCondition.Equal, "", logical);
        condition.NestedConditions.AddRange(nested._whereConditions);
        _whereConditions.Add(condition);
        return this;
    }
    
    public QueryBuilder OrderBy(string columns, bool isAsc = true)
    {
        _query = new OrderByDecorator(_query, columns, isAsc);
        return this;
    }

    public QueryBuilder Limit(int limit)
    {
        _query = new LimitDecorator(_query, limit);
        return this;
    }

    public QueryBuilder Join(string joinType, string tableName, string condition)
    {
        _query = new JoinDecorator(_query, joinType, tableName, condition);
        return this;
    }

    public ISpecialQueryBuilder Insert(Dictionary<string, object> values)
    {
        return new SpecialQueryBuilder(new InsertComponent(_tableName, values));
    }

    public QueryBuilder Update(Dictionary<string, object> values)
    {
        _query = new UpdateDecorator(_query, _tableName, values);
        return this;
    }

    public QueryBuilder Select(string[]? columns = null)
    {
        _query = new SelectDecorator(_query, _tableName, columns);
        return this;
    }

    public QueryBuilder Delete()
    {
        _query = new DeleteDecorator(_query, _tableName);
        return this;
    }
}
