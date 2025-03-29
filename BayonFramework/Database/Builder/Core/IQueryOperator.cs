using BayonFramework.Database.Builder.Query.Condition.Enum;

namespace BayonFramework.Database.Builder.Core;

/// <summary>
/// Defines the contract for query operations used in the query-building process.
/// </summary>
/// <remarks>
/// Implementations of this interface should provide mechanisms for constructing 
/// and modifying SQL query components.
/// </remarks>
public interface IQueryOperator
{

    QueryBuilder Insert(Dictionary<string, object> values);
    QueryBuilder Where(string column, ComparisonCondition condition, object value, LogicalCondition? logical=null, object? value2 = null);
    QueryBuilder Where(Action<QueryBuilder> nestedBuilder, LogicalCondition? logical = null);
    QueryBuilder OrderBy(string columns, bool isAsc = true);
    QueryBuilder Limit(int limit);
    QueryBuilder Join(string joinType, string tableName, string condition);
}
