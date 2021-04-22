using Microsoft.Extensions.DependencyInjection;

namespace Sdt.Utils
{
    public class DependecyInjectionService
    {
        static IServiceCollection _internalServiceCollection;
        public static IServiceCollection Services {
            get {
                if (_internalServiceCollection == null)
                   _internalServiceCollection = new ServiceCollection();
                return _internalServiceCollection;
            }
        }
    }
}