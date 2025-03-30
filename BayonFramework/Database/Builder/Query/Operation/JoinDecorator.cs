using BayonFramework.Database.Query;

namespace BayonFramework.Database.Builder.Query.Operation;

public class JoinDecorator : QueryDecorator
{
    protected string? _joinType;
    protected string? _tableName;
    protected string? _condition;

    public JoinDecorator(IQuery query, string joinType, string tableName, string condition):base(query)
    {
        _joinType = joinType;
        _tableName = tableName;
        _condition = condition;
    }
    
    protected override void BuildQuery()
    {
        _queryStringBuilder.Append($" {_joinType} JOIN {_tableName} ON {_condition}");
    }
}
