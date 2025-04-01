namespace BayonFramework.Security.Request
{
    public class AuthRequest : SecurityRequest
    {
        private string _username;
        private string? _password;
        private string? _hashPassword;
        private int _attempt = 0;
        private DateTime _lookTime;
        private bool _isLocked;
        public AuthRequest(string username, string password)
        {
            _username = username;
            _password = password;
        }

        public AuthRequest WithHashPassword(string hashPassword)
        {
            _hashPassword = hashPassword;
            return this;
        }
        public AuthRequest WithAttempt(int attempt)
        {
            _attempt = attempt;
            return this;
        }

        public AuthRequest WithLockTime(DateTime lookTime)
        {
            _lookTime = lookTime;
            return this;
        }

        public AuthRequest WithLocked(bool locked)
        {
            _isLocked = locked;
            return this;
        }

        public Auth Build()
        {
            return new Auth(_username, _password!, _hashPassword!)
            {
                Attempt = _attempt,
                Locked = _isLocked,
                LockTime = _lookTime
            };
        }
    }
}