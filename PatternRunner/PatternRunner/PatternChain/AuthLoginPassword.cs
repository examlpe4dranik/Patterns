namespace PatternRunner.PatternChain
{
    internal class AuthLoginPassword : AuthBase, IAuth
    {
        private readonly string _login;
        private readonly string _password;

        public AuthLoginPassword(string login, string password, IAuth? hanbler = null) : base(hanbler)
        {
            _login = login;
            _password = password;
        }

        public override ActionCode ChackTarget() => CheckLoginPassword();

        private ActionCode CheckLoginPassword()
        {
            if ((_login == "user1" && _password == "123")
                || (_login == "user2" && _password == "456")
                || (_login == "user3" && _password == "789"))
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