using BayonFramework.Security.Request;

namespace BayonFramework.Security.PasswordFilter.Rule
{
    public class NoRepeatFilter : PasswordFilterChain
    {
        private readonly int _maxRepeats;

        public NoRepeatFilter(int maxRepeats = 3)
        {
            _maxRepeats = maxRepeats;
        }

        public override bool Handle(SecurityRequest input, out string errorMessage)
        {
            if (input is not PasswordRequest passowrdRequest)
            {
                throw new InvalidOperationException("NoRepeatFilter => Error : input is not PasswordRequest");
            }
            for (int i = 0; i < passowrdRequest.Password.Length - _maxRepeats; i++)
            {
                if (passowrdRequest.Password.Skip(i).Take(_maxRepeats + 1).Distinct().Count() == 1)
                {
                    errorMessage = $"Password cannot have more than {_maxRepeats} repeated characters in a row";
                    return false;
                }
            }
            errorMessage = string.Empty;
            return NextFilterChain?.Handle(input, out errorMessage) ?? true;
        }
    }
}
