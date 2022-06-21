namespace PatternRunner.PatternChain
{
    internal class AuthBase : IAuth
    {
        protected IAuth? _handler;

        public AuthBase(IAuth? handler = null)
        {
            _handler = handler;
        }

        public virtual ActionCode Check()
        {
            ActionCode result = ActionCodeContinue();

            if (_handler != null)
            {
                result = _handler.Check();
            }

            if (result == ActionCodeContinue())
            {
                result = ChackTarget();
            }

            return result;
        }

        public virtual ActionCode ChackTarget() => ActionCodeContinue();

        protected virtual ActionCode ActionCodeContinue() => ActionCode.Success;
    }
}