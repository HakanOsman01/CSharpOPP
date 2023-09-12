using Microsoft.Extensions.DependencyInjection;
using SoftUniDI_Framework;
using SoftUniDI_Framework.DI;
using SoftUniDI_Framework.Loggers;
using SoftUniDI_Framework.Renderurs;

ServiceProvider provider = DI.BuildServices();
Shape shape=provider.GetService<Shape>();
shape.Draw();
