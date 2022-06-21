namespace PatternRunner.PatternChain
{
    internal class ChainSolution : IPatternSolution
    {
        public void Execute()
        {
            string user1 = "user1";
            string pwd1 = "123";
            var authBase = new AuthBase();
            var authRule = new AuthRule(user1, authBase);
            var authPass = new AuthLoginPassword(user1, pwd1, authRule);
            Console.WriteLine($"{user1}::{pwd1}: {authPass.Check()}");

            string user2 = "user2";
            string pwd2 = "000";
            var authRule_ = new AuthRule(user2);
            var authPass_ = new AuthLoginPassword(user2, pwd2, authRule_);
            Console.WriteLine($"{user2}::{pwd2}: {authPass_.Check()}");

            string user3 = "user3";
            string pwd3 = "789";
            var authRule__ = new AuthRule(user3);
            var authPass__ = new AuthLoginPassword(user3, pwd3, authRule__);
            Console.WriteLine($"{user3}::{pwd3}: {authPass__.Check()}");
        }
    }
}