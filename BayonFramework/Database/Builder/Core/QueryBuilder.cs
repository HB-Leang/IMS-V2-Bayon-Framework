
using BayonFramework.Database.Builder.Query;
using BayonFramework.Database.Builder.Query.Condition;
using BayonFramework.Database.Builder.Query.Condition.Enum;
using BayonFramework.Database.Builder.Query.Operation;
using BayonFramework.Database.Query;
using System.Text;

namespace BayonFramework.Database.Builder.Core;

/// <summary>
/// A builder class for constructing SQL queries dynamically.
/// </summary>
/// <remarks>
/// This class allows users to build SQL queries by chaining methods for 
/// filtering (WHERE), sorting (ORDER BY), limiting results (LIMIT), and joining tables (JOIN).
/// It follows the decorator pattern to apply query modifications dynamically.
/// </remarks>
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
        _query = new QueryComponent(_tableName, _initialColumns);
    }

    public SqlQuery Build()
    {
        var sb = new StringBuilder();

        var parameters = new Dictionary<string, object>();

        ///  Apply Where Cluase
        this.ApplyWhere();

        /// Build Query
        _query.Build(sb, parameters);

        /// Create SqlQuery
        SqlQuery sqlQuery = new SqlQuery.Builder()
            .SetQuery(_query.GetQuery())
            .AddParameters(_query.GetParameters())
            .Build();

        /// Reset
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
    
    /// <summary>
    /// Adds a LIMIT clause to the query.
    /// </summary>
    /// <param name="limit">The maximum number of records to return.</param>
    /// <returns>The current <see cref="QueryBuilder"/> instance.</returns>
    public QueryBuilder Limit(int limit)
    {
        _query = new LimitDecorator(_query, limit);
        return this;
    }

    /// <summary>
    /// Adds a JOIN clause to the query.
    /// </summary>
    /// <param name="joinType">The type of join (e.g., INNER JOIN, LEFT JOIN).</param>
    /// <param name="tableName">The name of the table to join with.</param>
    /// <param name="condition">The join condition specifying how the tables should be joined.</param>
    /// <returns>The current <see cref="QueryBuilder"/> instance.</returns>
    public QueryBuilder Join(string joinType, string tableName, string condition)
    {
        _query = new JoinDecorator(_query, joinType, tableName, condition);
        return this;
    }

    public QueryBuilder Insert(Dictionary<string, object> values)
    {
        _query = new InsertComponent(_tableName, values);
        return this;
    }
}
