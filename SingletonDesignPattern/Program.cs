using SingletonDesignPattern;

var instance = Singleton.Instance(1);
var countries = instance.GetCountries();

foreach (var country in countries)
{
    Console.WriteLine(country.Name);
}

//validating the thread safety
Thread t1 = new Thread(() =>
{
    var instance = Singleton.Instance(1);
});

Thread t2 = new Thread(() =>
{
    var instance = Singleton.Instance(2);
});

t1.Start();
t2.Start();

t1.Join();
t2.Join();