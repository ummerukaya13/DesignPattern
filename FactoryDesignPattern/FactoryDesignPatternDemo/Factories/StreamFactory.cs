using FactoryDesignPatternDemo.Enums;
using FactoryDesignPatternDemo.Services;

namespace FactoryDesignPatternDemo.Factories
{

    //this class handles object creation
    public class StreamFactory
    {
        private readonly IServiceProvider _serviceProvider;
        public StreamFactory(IServiceProvider serviceProvider)
        {
            _serviceProvider = serviceProvider;
        }

        //returns an implementation of the IStreamService interface
        public IStreamService GetStreamService(StreamType userSelection)
        {
            if(userSelection == StreamType.Netflix)
                return (IStreamService)_serviceProvider.GetService(typeof(NetflixStreamService))!;

            return (IStreamService)_serviceProvider.GetService(typeof(AmazonStreamService))!;
        }
    }
}
