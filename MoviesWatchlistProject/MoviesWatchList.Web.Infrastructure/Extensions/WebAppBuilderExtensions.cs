using Microsoft.Extensions.DependencyInjection;
using System.Reflection;

namespace MoviesWatchList.Web.Infrastructure.Extensions
{
	public static class WebAppBuilderExtensions
	{
		public static void AddAppServices(this IServiceCollection services, Type serviceType)
		{
			Assembly? serviceAssembly = Assembly.GetAssembly(serviceType);

			if (serviceAssembly == null)
			{
				throw new InvalidOperationException("Invalid service type provided!");
			}

			Type[] implementationTypes = serviceAssembly
				.GetTypes()
				.Where(t => t.Name.EndsWith("Service") && !t.IsInterface)
				.ToArray();

			foreach (Type type in implementationTypes)
			{
				Type? interfaceType = type.GetInterface($"I{type.Name}");
				if (interfaceType == null)
				{
					throw new InvalidOperationException($"No interface with name: {type.Name}");
				}

				services.AddScoped(interfaceType, type);
			}
		}
	}
}
