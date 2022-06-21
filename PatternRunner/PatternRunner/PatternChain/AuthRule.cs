namespace PatternRunner.PatternChain
{
    internal class AuthRule : AuthBase, IAuth
    {
        private string _login;

        public AuthRule(string login, IAuth? hanbler = null) : base(hanbler)
        {
            _login = login;
        }

        public override ActionCode ChackTarget() => CheckAccess();

        private ActionCode CheckAccess()
        {
            if (_login == "user1" || _login == "user2")
            {
                return ActionCode.Success;
            }
            else
            {
                return ActionCode.Error;
            }
        }
    }
}