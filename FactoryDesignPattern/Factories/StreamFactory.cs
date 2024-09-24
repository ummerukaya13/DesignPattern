using FactoryDesignPatternDemo.Enums;
using FactoryDesignPatternDemo.Services;

namespace FactoryDesignPatternDemo.Factories
{

    //this class handles object creation
    public class StreamFactory
    {
        private readonly IServiceProvider _serviceProvider;
        private readonly NetflixStreamService _netflixStreamService;
        private readonly AmazonStreamService _amazonStreamService;

        public StreamFactory(IServiceProvider serviceProvider,
            NetflixStreamService netflixStreamService,
            AmazonStreamService amazonStreamService)
        {
            _serviceProvider = serviceProvider;
            _netflixStreamService = netflixStreamService;
            _amazonStreamService = amazonStreamService;
        }

        //returns an implementation of the IStreamService interface
        public IStreamService GetStreamService(StreamType userSelection)
        {
            if (userSelection == StreamType.Netflix)
                return _netflixStreamService;
            else
                return _amazonStreamService;
                return (IStreamService)_serviceProvider.GetService(typeof(NetflixStreamService))!;

            //return (IStreamService)_serviceProvider.GetService(typeof(AmazonStreamService))!;
        }
    }
}
