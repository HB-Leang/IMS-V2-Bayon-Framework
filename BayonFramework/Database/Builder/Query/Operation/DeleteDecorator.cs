using BayonFramework.Database.Query;

namespace BayonFramework.Database.Builder.Query.Operation
{
    public class DeleteDecorator : QueryDecorator
    {
        private readonly string _tableName;
        public DeleteDecorator(IQuery query, string tableName) : base(query)
        {
            _tableName = tableName;
        }
        protected override void BuildQuery()
        {
            _queryStringBuilder.Append($"DELETE FROM {_tableName}");
        }
    }
}
