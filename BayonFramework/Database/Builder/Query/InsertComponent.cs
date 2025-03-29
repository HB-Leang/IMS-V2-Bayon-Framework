using BayonFramework.Database.Query;
using System.Text;

namespace BayonFramework.Database.Builder.Query
{
    public class InsertComponent : IQuery
    {
        private StringBuilder _queryStringBuilder = new StringBuilder();
        private Dictionary<string, object> _parameters = new Dictionary<string, object>();
        private readonly string _tableName;
        private readonly Dictionary<string, object> _values;

        public InsertComponent(string tableName, Dictionary<string, object> values)
        {
            _tableName = tableName;
            _values = values ?? new Dictionary<string, object>();
        }

        public void Build(StringBuilder queryStringBuilder, Dictionary<string, object> parameters)
        {
            _queryStringBuilder.Clear();
            _parameters.Clear();

            if (_values.Any())
            {
                var columns = string.Join(", ", _values.Keys);
                var paramNames = string.Join(", ", _values.Keys.Select(k => $"@{k}"));
                _queryStringBuilder.Append($"INSERT INTO {_tableName} ({columns}) VALUES ({paramNames})");

                foreach (var param in _values)
                {
                    _parameters[$"@{param.Key}"] = param.Value;
                }
            }
            queryStringBuilder.Append(_queryStringBuilder);

            //foreach (var param in _parameters)
            //{
            //    parameters[param.Key] = param.Value;
            //}
        }

        public Dictionary<string, object> GetParameters()
        {
            return _parameters;
        }

        public string GetQuery()
        {
            return _queryStringBuilder.ToString();
        }
    }
}
