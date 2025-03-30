using System.Text;

namespace BayonFramework.Database.Query;

public interface IQuery
{
    void Build(StringBuilder queryStringBuilder, Dictionary<string, object> parameters);
    string GetQuery();
    Dictionary<string, object> GetParameters();
}