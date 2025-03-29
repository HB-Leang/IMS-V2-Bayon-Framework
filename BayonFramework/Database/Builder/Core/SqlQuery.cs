using Microsoft.Data.SqlClient;

namespace BayonFramework.Database.Builder.Core
{
    public class SqlQuery
    {
        public readonly string? Query;
        public readonly Dictionary<string, object> Parameters;
        private SqlQuery(string? query, Dictionary<string, object> parameters)
        {
            Query = query;
            Parameters = parameters;
        }

        public SqlCommand GetSqlCommand(SqlCommand cmd) {

            if (this.Parameters == null) return cmd;

            cmd.Parameters.Clear();
            foreach (var param in this.Parameters)
            {
                cmd.Parameters.AddWithValue(param.Key, param.Value ?? DBNull.Value);
            }
            
            return cmd;
        }

        public class Builder
        {
            private string? _query;
            private Dictionary<string, object> _parameters = new Dictionary<string, object>();

            public Builder SetQuery(string query)
            {
                _query = query;
                return this;
            }

            public Builder AddParameter(string key, object value)
            {
                _parameters[key] = value;
                return this;
            }

            public Builder AddParameters(Dictionary<string, object> parameters)
            {
                 _parameters = parameters.ToDictionary(entry => entry.Key, entry => entry.Value);
                return this;
            }

            public SqlQuery Build()
            {
                return new SqlQuery(_query, _parameters);
            }
        }

    }
}
