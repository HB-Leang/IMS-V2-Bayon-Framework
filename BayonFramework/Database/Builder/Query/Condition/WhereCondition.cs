using BayonFramework.Database.Builder.Query.Condition.Enum;

namespace BayonFramework.Database.Builder.Query.Condition
{
    public class WhereCondition
    {
        public string Column { get; }
        public object Value { get; }
        public object? Value2 { get; }
        public ComparisonCondition ComparisonCondition { get; }
        public LogicalCondition? LogicalCondition { get; }
        public List<WhereCondition> NestedConditions { get; }
        public WhereCondition(string column, ComparisonCondition comparisonCondition, object value, LogicalCondition? logicalCondition=null, object? value2 = null
        ){
            Column = column;
            ComparisonCondition = comparisonCondition;
            Value = value;
            Value2 = value2;
            LogicalCondition = logicalCondition;
            NestedConditions = new List<WhereCondition>();
        }
        public WhereCondition AddNested(WhereCondition condition)
        {
            NestedConditions.Add(condition);
            return this;
        }
    }
}
