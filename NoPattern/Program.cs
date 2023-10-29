using BumbleBikesLibrary;

const string errorText = "You must pass in mountainbike, cruiser, recumbent, or roadbike";
Console.Write("Bike want to build: ");
var bicycleType = Console.ReadLine();

if(bicycleType.Length > 0)
{
    Bicycle bikeToBuild;
    switch (bicycleType)
    {
        case "mountainbike":
            bikeToBuild = new MountainBike();
            break;
        case "cruiser":
            bikeToBuild = new Cruiser();
            break;
        case "recumbent":
            bikeToBuild = new Recumbent();
            break;
        case "roadbike":
            bikeToBuild = new RoadBike();
            break;
        default:
            Console.WriteLine(errorText);
            throw new Exception("Unknown bicycle type: " + bicycleType);
    }

    bikeToBuild.Build();
}
else
{
    Console.WriteLine(errorText);
}