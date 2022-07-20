using Autofac;
using MindBoxLibrary.Algorithms;
using MindBoxLibrary.Validation;
using MindBoxLibrary.Validation.Internal;

namespace MindBoxLibrary;

public class ApiFactory : IDisposable {
    private readonly IContainer container;
    public ApiFactory(Action<ContainerBuilder> registerAction = null) {
        var builder = new ContainerBuilder();

        builder.RegisterType<CircleValidator>().As<IShapeValidator<Circle>>();
        builder.RegisterType<CircleAreaCalculator>().As<IAreaCalculator<Circle>>();

        builder.RegisterType<TriangleValidator>().As<IShapeValidator<Triangle>>();
        builder.RegisterType<TriangleAreaCalculator>().As<IAreaCalculator<Triangle>>();

        builder.RegisterType<RightTriangleDetector>().As<IRightTriangleDetector>();

        registerAction?.Invoke(builder);
        container = builder.Build();
    }

    public IAreaCalculator<T> CreateAreaCalculator<T>() where T : IShape {
        return container.Resolve<IAreaCalculator<T>>();
    }
    public IRightTriangleDetector CreateRightTriangleDetector() {
        return container.Resolve<IRightTriangleDetector>();
    }
    public void Dispose() {
        container?.Dispose();
    }
}