using BayonFramework.Database.Query;

namespace BayonFramework.Database.Builder.Query.Operation;

public class LimitDecorator : QueryDecorator
{
    protected int _limit;
    public LimitDecorator(IQuery query, int limit): base(query)
    {
        _limit = limit;
    }

    protected override void BuildQuery()
    {
        _queryStringBuilder.Append($" LIMIT {_limit}");
    }
}
