using BayonFramework.Database.Query;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BayonFramework.Database.Builder.Query.Operation
{
    public class UpdateDecorator : QueryDecorator
    {

        private readonly string _tableName;
        private readonly Dictionary<string, object> _values;

        public UpdateDecorator(IQuery query, string tableName, Dictionary<string, object> values) : base(query)
        {
            _tableName = tableName;
            _values = values;
        }

        protected override void BuildQuery()
        {
            if (_values.Any())
            {
                var setClause = string.Join(", ", _values.Keys.Select(k => $"{k} = @{k}"));
                _queryStringBuilder.Append($"UPDATE {_tableName} SET {setClause}");
                foreach (var param in _values)
                {
                    _parameters[param.Key] = param.Value;
                }
            }
        }
    }
}
