using BayonFramework.Database.Builder.Core.Special;
using BayonFramework.Database.Builder.Query.Condition.Enum;

namespace BayonFramework.Database.Builder.Core;

public interface IQueryOperator
{
    ISpecialQueryBuilder Insert(Dictionary<string, object> values);
    QueryBuilder Where(string column, ComparisonCondition condition, object value, LogicalCondition? logical=null, object? value2 = null);
    QueryBuilder Where(Action<QueryBuilder> nestedBuilder, LogicalCondition? logical = null);
    QueryBuilder OrderBy(string columns, bool isAsc = true);
    QueryBuilder Limit(int limit);
    QueryBuilder Join(string joinType, string tableName, string condition);
    QueryBuilder Update(Dictionary<string, object> values);
    QueryBuilder Select(string[]? columns = null);
    QueryBuilder Delete();
}
