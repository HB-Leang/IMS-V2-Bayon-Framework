using BayonFramework.Database.Query;
using System.Text;

namespace BayonFramework.Database.Builder.Core.Special
{
    public class SpecialQueryBuilder : ISpecialQueryBuilder
    {
        private readonly IQuery _query;
        public SpecialQueryBuilder(IQuery query)
        {
            _query = query;
        }
        public SqlQuery Build()
        {
            var sb = new StringBuilder();
            var parameters = new Dictionary<string, object>();
            _query.Build(sb, parameters);
            return new SqlQuery.Builder()
                .SetQuery(_query.GetQuery())
                .AddParameters(_query.GetParameters())
                .Build();
        }
    }
}
