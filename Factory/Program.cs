using BumbleBikesLibrary;
using SimpleFactory;

const string errorText = "You must pass in mountainbike, cruiser, recumbent, or roadbike";
Console.Write("Bike want to build: ");
var bicycleType = Console.ReadLine();
if (bicycleType.Length > 0)
{
    var bicycleFactory = new SimpleBicycleFactory();
    var bikeToBuild = bicycleFactory.CreateBicycle(bicycleType);
    bikeToBuild.Build();
}
else
{
    Console.WriteLine(errorText);
}