
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
    private IQuery? _query;
    private readonly List<WhereCondition> _whereConditions;
    private readonly string _tableName;
    private readonly string[] _initialColumns;
    private bool _isWhereApplied;
    public QueryBuilder(string tableName, string[]? columns =null)
    {
        _tableName = string.IsNullOrWhiteSpace(tableName)? throw new ArgumentException("Table name cannot be empty", nameof(tableName)): tableName;
        _whereConditions = new List<WhereCondition>();
        _initialColumns = columns?.ToArray() ?? Array.Empty<string>();
        _query = new QueryComponent(_tableName);
        _isWhereApplied = false;
    }
    public SqlQuery Build()
    {
        var sb = new StringBuilder();
        var parameters = new Dictionary<string, object>();

        if (!_isWhereApplied && _whereConditions.Any())
            ApplyWhere();

        _query!.Build(sb, parameters);

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
        _query = new QueryComponent(_tableName);
        _isWhereApplied = false;
    }
    private QueryBuilder ApplyWhere()
    {
        if (!_isWhereApplied && _whereConditions.Any())
        {
            _query = new WhereDecorator(_query!, _whereConditions);
            _isWhereApplied = true;
        }
        return this;
    }
    public QueryBuilder Where(string column, ComparisonCondition condition, object value, LogicalCondition? logical = null, object? value2 = null)
    {
        if (string.IsNullOrWhiteSpace(column))
            throw new ArgumentException("Column name cannot be empty", nameof(column));
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
        if (!_isWhereApplied && _whereConditions.Any())
            ApplyWhere();

        _query = new OrderByDecorator(_query!, columns, isAsc);
        return this;
    }
    public QueryBuilder Limit(int limit)
    {

        if (!_isWhereApplied && _whereConditions.Any())
            ApplyWhere();

        _query = new LimitDecorator(_query!, limit);
        return this;
    }
    public QueryBuilder Join(string joinType, string tableName, string condition)
    {
        _query = new JoinDecorator(_query!, joinType, tableName, condition);
        return this;
    }
    public ISpecialQueryBuilder Insert(Dictionary<string, object> values)
    {
        return new SpecialQueryBuilder(new InsertComponent(_tableName, values));
    }
    public QueryBuilder Update(Dictionary<string, object> values)
    {
        _query = new UpdateDecorator(_query!, _tableName, values);
        return this;
    }
    public QueryBuilder Select(string[]? columns = null)
    {
        _query = new SelectDecorator(_query!, _tableName, columns);
        return this;
    }
    public QueryBuilder Delete()
    {
        _query = new DeleteDecorator(_query!, _tableName);
        return this;
    }
}
