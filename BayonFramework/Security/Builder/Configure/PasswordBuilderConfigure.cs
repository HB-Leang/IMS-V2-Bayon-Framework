using BayonFramework.Security.PasswordFilter;
using BayonFramework.Security.PasswordFilter.Rule;

namespace BayonFramework.Security.Builder.Configure
{
    public class PasswordBuilderConfigure
    {
        private readonly List<PasswordFilterChain> _filters = new List<PasswordFilterChain>();
        private readonly SecurityChain _securityChain;

        public PasswordBuilderConfigure(SecurityChain passwordSecurity)
        {
            _securityChain = passwordSecurity;
        }

        public PasswordBuilderConfigure MinLength(int minLength)
        {
            _filters.Add(new LengthFilter(minLength));
            return this;
        }

        public PasswordBuilderConfigure Number()
        {
            _filters.Add(new NumberFilter());
            return this;
        }

        public PasswordBuilderConfigure SpecialCharacters(char[]? specialChars = null) {
            _filters.Add(new SpecialCharFilter(specialChars));
            return this;
        }

        public PasswordBuilderConfigure Uppercase()
        {
            _filters.Add(new UppercaseFilter());
            return this;
        }

        public PasswordBuilderConfigure NoSpaces()
        {
            _filters.Add(new NoSpaceFilter());
            return this;
        }

        public PasswordBuilderConfigure NoRepeat(int maxRepeats)
        {
            _filters.Add(new NoRepeatFilter(maxRepeats));
            return this;
        }

        public SecurityChain Password()
        {
            _securityChain.DoAddPasswordFiltering(_filters);
            return _securityChain;
        }
    }
}