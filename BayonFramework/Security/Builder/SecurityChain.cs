using BayonFramework.Security.Authentication;
using BayonFramework.Security.Builder.Configure;
using BayonFramework.Security.Encryption;
using BayonFramework.Security.Encryption.Enum;
using BayonFramework.Security.PasswordFilter;
using BayonFramework.Security.RegisterFilter;


namespace BayonFramework.Security.Builder
{
    public class SecurityChain : ISecurityChain
    {
        private readonly List<ISecurityFilterChain> _filters = new List<ISecurityFilterChain>();
        internal EncryptAlgorithm _encryptAlgorithm;
        private bool _useEncryptFilter;

        public ISecurityChain BasicPassword()
        {
            return PasswordFilter(
                    password => password
                        .MinLength(6)
                        .Number()
                        .NoSpaces()
                    );
        }

        public ISecurityChain StrongPassword()
        {
            return PasswordFilter(
                    password => password
                            .MinLength(10)
                            .Uppercase()
                            .Number()
                            .NoSpaces()
                            .SpecialCharacters()
                            .NoRepeat(2)
                        );
        }

        public ISecurityChain PasswordFilter(Action<PasswordBuilderConfigure> configure)
        {
            PasswordBuilderConfigure passwordConfigure = new PasswordBuilderConfigure(this);
            configure(passwordConfigure);
            return passwordConfigure.Password();
        }

        public ISecurityChain RegisterFilter(Action<RegisterBuilderConfigure> configure)
        {
            RegisterBuilderConfigure registerConfigure = new RegisterBuilderConfigure(this);
            configure(registerConfigure);
            return registerConfigure.Regiter();
        }

        public ISecurityChain AuthFilter(Action<AuthBuilderConfigure> configure)
        {
            AuthBuilderConfigure authConfigure = new AuthBuilderConfigure(this);
            configure(authConfigure);
            return authConfigure.Auth();
        }

        public ISecurityChain Encrypt(EncryptAlgorithm encryptAlgorithm = EncryptAlgorithm.Bcrypt)
        {
            _encryptAlgorithm = encryptAlgorithm;
            _useEncryptFilter = true;
            return this;
        }

        internal void DoAddPasswordFiltering(List<PasswordFilterChain> passwordFilterChains)
        {
            _filters.AddRange(passwordFilterChains);
        }

        internal void DoAddRegisterFiltering(List<RegisterFilterChain> registerFilterChains)
        {
            _filters.AddRange(registerFilterChains);
        }

        internal void DoAddAuthFiltering(List<AuthenticationFilterChain> authenticationFilterChains)
        {
            _filters.AddRange(authenticationFilterChains);
        }

        public ISecurityFilterChain Build()
        {
            if (_filters.Count == 0 && !_useEncryptFilter)
                throw new InvalidOperationException("At least one filter must be specified.");

            if (_useEncryptFilter) 
                _filters.Insert(_filters.Count,new EncryptFilterChain(_encryptAlgorithm));

            if(_filters.Count > 1)
            {
                for (int i = 0; i < _filters.Count - 1; i++)
                {
                    _filters[i].NextFilter(_filters[i + 1]);
                }
            }

            return _filters[0];
        }
    }
}
