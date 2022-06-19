namespace PatternRunner.PatternAbstractFactory
{
    public class TargetLogic
    {
        private IFactory _factory;

        public TargetLogic(IFactory factory)
        {
            _factory = factory;
        }

        public string BasicFunc() => _factory.GetProduct().Name();

        public string ExtendedFunc() => _factory.GetProduct().ExtendedFunc();
    }

    public class FactoryA : IFactory
    {
        public IProduct GetProduct() => new ProductA();
    }

    public class FactoryB : IFactory
    {
        public IProduct GetProduct() => new ProductB();
    }

    public class ProductA : IProduct
    {
        public string Name() => nameof(ProductA);

        public string ExtendedFunc() => throw new NotImplementedException();
    }

    public class ProductB : IProduct
    {
        public string Name() => nameof(ProductB);

        public string ExtendedFunc() => nameof(ExtendedFunc);
    }
}