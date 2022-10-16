using Autofac;
using PatternRunner;
using PatternRunner.PatternSingleton;

IContainer _container;

void RegisterType()
{
    var builder = new ContainerBuilder();
    builder.RegisterType<SingletonSolution>().As<IPatternSolution>();
    _container = builder.Build();
}

RegisterType();

using (var scope = _container.BeginLifetimeScope())
{
    var currentSolution = scope.Resolve<IPatternSolution>();
    currentSolution.Execute();
}

Console.ReadLine();