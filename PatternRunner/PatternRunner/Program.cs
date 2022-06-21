using Autofac;
using PatternRunner;
using PatternRunner.PatternDecorator;

IContainer _container;

void RegisterType()
{
    var builder = new ContainerBuilder();
    builder.RegisterType<DecoratorSolution>().As<IPatternSolution>();
    _container = builder.Build();
}

RegisterType();

using (var scope = _container.BeginLifetimeScope())
{
    var currentSolution = scope.Resolve<IPatternSolution>();
    currentSolution.Execute();
}

Console.ReadLine();