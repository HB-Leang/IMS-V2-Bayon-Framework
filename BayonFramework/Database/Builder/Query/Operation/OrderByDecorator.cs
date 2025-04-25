using BayonFramework.Database.Query;
using static Npgsql.Replication.PgOutput.Messages.RelationMessage;

namespace BayonFramework.Database.Builder.Query.Operation;

public class OrderByDecorator: QueryDecorator
{
    protected string? _column;
    protected bool _isAsc;

    public OrderByDecorator(IQuery query, string column, bool isAsc = true): base(query)
    {
        _column = column;
    }
    protected override void BuildQuery()
    {
        _queryStringBuilder.Append($" ORDER BY {_column} {(_isAsc ? "ASC" : "DESC")}");
    }

}
