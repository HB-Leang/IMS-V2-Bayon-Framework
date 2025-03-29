namespace BayonFramework.Database.Builder.Core;


/// <summary>
/// Defines the contract for building SQL queries dynamically.
/// </summary>
/// <remarks>
/// This interface extends <see cref="IQueryOperator"/> and provides methods 
/// for constructing SQL queries, including WHERE conditions, ordering, 
/// limiting results, and joining tables.
/// </remarks>
public interface IQueryBuilder : IQueryOperator
{
    //string Build();
    SqlQuery Build();
    QueryBuilder ApplyWhere();
}
