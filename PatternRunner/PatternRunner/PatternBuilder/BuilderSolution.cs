namespace PatternRunner.PatternBuilder
{
    internal class BuilderSolution : IPatternSolution
    {
        public void Execute()
        {
            string input = "123--QWE--456--qwe--zxc--432";

            var directorC = new DirectorReplacer(new CharBuilder());
            var replacerC = directorC.Contstruct();
            Console.WriteLine(replacerC.Replace(input));

            var directorC_ = new DirectorReplacer(new CharBuilder());
            var replacerC_ = directorC_.Contstruct(pattern: "[a-zA-Z]+", marker: "~", postfix: ":::::");
            Console.WriteLine(replacerC_.Replace(input));

            var directorD = new DirectorReplacer(new DigitalBuilder());
            var replacerD = directorD.Contstruct();
            Console.WriteLine(replacerD.Replace(input));
        }
    }
}