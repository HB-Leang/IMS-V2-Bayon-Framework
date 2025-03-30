namespace BayonFramework.Database.Builder.Core;

public interface IQueryBuilder : IQueryOperator
{
    SqlQuery Build();
    //QueryBuilder ApplyWhere();
}
