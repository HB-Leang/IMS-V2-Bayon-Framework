using BayonFramework.Database.Builder.Core;
using BayonFramework.Database.Builder.Query.Condition;
using BayonFramework.Database.Builder.Query.Condition.Enum;
using BayonFramework.Database.Query;
using System.Text;

namespace BayonFramework.Database.Builder.Query.Operation;

public class WhereDecorator : QueryDecorator
{
    private List<WhereCondition> _conditions;
    public WhereDecorator(IQuery query, List<WhereCondition> conditions) : base(query)
    {
        _conditions = conditions;
    }
    protected override void BuildQuery()
    {
        if (_conditions.Count > 0)
            _queryStringBuilder.Append(" WHERE ").Append(BuildWhereClause(_conditions));
    }

    private string BuildWhereClause(List<WhereCondition> conditions, int paramIndex = 0)
    {
        StringBuilder sb = new StringBuilder();
        for (int i = 0; i < conditions.Count; i++)
        {
            var cond = conditions[i];
            if (i > 0 && cond.LogicalCondition.HasValue) sb.Append($" {cond.LogicalCondition.Value} ");
            if (cond.NestedConditions.Count > 0)
            {
                sb.Append("(");
                sb.Append(BuildWhereClause(cond.NestedConditions, paramIndex));
                sb.Append(")");
            }
            else
            {
                string paramName = $"@p{paramIndex++}";
                sb.Append(cond.Column);
                sb.Append(GetOperatorSymbol(cond.ComparisonCondition));
                switch (cond.ComparisonCondition)
                {
                    case ComparisonCondition.In:
                        sb.Append($"({string.Join(", ", ((IEnumerable<object>)cond.Value).Select(v => paramName))})");
                        _parameters[paramName] = cond.Value;
                        break;
                    case ComparisonCondition.Between:
                        string paramName2 = $"@p{paramIndex++}";
                        sb.Append($"{paramName} AND {paramName2}");
                        _parameters[paramName] = cond.Value;
                        _parameters[paramName2] = cond.Value2!;
                        break;
                    default:
                        sb.Append(paramName);
                        _parameters[paramName] = cond.Value;
                        break;
                }
            }
        }
        return sb.ToString();
    }
    private string GetOperatorSymbol(ComparisonCondition op) => op switch
    {
        ComparisonCondition.Equal => " = ",
        ComparisonCondition.NotEqual => " != ",
        ComparisonCondition.GreaterThan => " > ",
        ComparisonCondition.LessThan => " < ",
        ComparisonCondition.GreaterOrEqual => " >= ",
        ComparisonCondition.LessOrEqual => " <= ",
        ComparisonCondition.Like => " LIKE ",
        ComparisonCondition.In => " IN ",
        ComparisonCondition.Between => " BETWEEN ",
        _ => throw new ArgumentException("Unsupported operator")
    };
}
