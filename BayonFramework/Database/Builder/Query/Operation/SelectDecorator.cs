using BayonFramework.Database.Query;

namespace BayonFramework.Database.Builder.Query.Operation
{
    public class SelectDecorator : QueryDecorator
    {
        private readonly string _tableName;
        private readonly string[] _columns;
        public SelectDecorator(IQuery query, string tableName, string[]? columns = null) : base(query)
        {
            _tableName = tableName;
            _columns = columns ?? Array.Empty<string>();
        }
        protected override void BuildQuery()
        {
            _queryStringBuilder.Append($"SELECT {(_columns.Length > 0 ? string.Join(", ", _columns) : "*")} FROM {_tableName}");
        }
    }
}
