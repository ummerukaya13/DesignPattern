namespace FactoryDesignPatternDemo.Services
{
    public class AmazonStreamService : IStreamService
    {
        public string[] ShowMovies()
        {
            return new string[]
            {
                "Movie A",
                "Movie B",
                "Movie C"
            };
        }
    }
}
