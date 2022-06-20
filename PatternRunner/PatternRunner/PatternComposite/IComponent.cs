namespace PatternRunner.PatternComposite
{
    public interface IComponent
    {
        IComponent Add(IComponent component);

        int Sum();
    }
}