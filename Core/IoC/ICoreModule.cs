using Microsoft.Extensions.DependencyInjection;
using System.Collections.Generic;
using System.Text;

namespace Core.IoC
{
    public interface ICoreModule
    {
        void Load(IServiceCollection serviceCollection);


    }
}
